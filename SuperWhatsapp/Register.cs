using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32;
using Standard.Licensing;
using Standard.Licensing.Validation;

namespace MultiWhatsapp
{
    public static class Register
    {
        internal static readonly string AppDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CefSharp\\Cache\\SuperWhatsapp");
        public static readonly string LicensePath = $"{AppDataPath}\\license";

        //public static string ComputeSha256Hash(string text)
        //{
        //    using (var sha256 = new SHA256Managed())
        //    {
        //        return BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(text))).Replace("-", "");
        //    }
        //}

        //private static string Encode64(string text)
        //{
        //    return Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
        //}

        //public static string Decode64(string text)
        //{
        //    return Encoding.UTF8.GetString(Convert.FromBase64String(text));
        //}

        private static Guid MungeTwoGuids(Guid guid1, Guid guid2)
        {
            const int bytecount = 16;
            var destByte = new byte[bytecount];
            var guid1Byte = guid1.ToByteArray();
            var guid2Byte = guid2.ToByteArray();

            for (int i = 0; i < bytecount; i++)
            {
                destByte[i] = (byte)(guid1Byte[i] ^ guid2Byte[i]);
            }
            return new Guid(destByte);
        }

        public static Guid GetAppGuid()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var attr = (GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
            var appGuid = Guid.Parse(attr.Value);
            return appGuid;
        }

        public static Guid GetRegisterGuid()
        {
            return GetRegisterGuid(GetAppGuid());
        }

        public static Guid GetRegisterGuid(Guid appGuid)
        {
            return MungeTwoGuids(GetMachineGuid(), appGuid);
        }

        private static Guid GetMachineGuid()
        {
            const string location = @"SOFTWARE\Microsoft\Cryptography";
            const string name = "MachineGuid";

            using (var localMachineX64View =
                RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (var rk = localMachineX64View.OpenSubKey(location))
                {
                    if (rk == null)
                        throw new KeyNotFoundException(
                            $"Key Not Found: {location}");

                    var machineGuid = rk.GetValue(name);
                    if (machineGuid == null)
                        throw new IndexOutOfRangeException(
                            $"Index Not Found: {name}");

                    return Guid.Parse(machineGuid.ToString());
                }
            }
        }

        //public static void WriteLicense(License license, string pk, string path)
        //{
        //    File.WriteAllText(path, $@"{Encode64(license.ToString())}.{pk}", Encoding.UTF8);
        //}

        //public static void WriteLicense(string license, string pk, string path)
        //{
        //    File.WriteAllText(path, $@"{license}.{pk}", Encoding.UTF8);
        //}

        public static License ReadLicense(string path, out string pk)
        {
            pk = null;
            if (!File.Exists(path)) return null;
            try
            {
                var content = File.ReadAllText(path).Split('.');
                var data = Convert.FromBase64String(content[0]);
                var xml = Encoding.UTF8.GetString(data);
                pk = content[1];
                return License.Load(xml);
            }
            catch
            {
                // ignored
            }
            return null;
        }
    }

    public static class Validator
    {
        public static bool IsLicenseValidated(License license, string publicKey)
        {
            // ReSharper disable once RedundantAssignment
            var validationFailures = new List<IValidationFailure>();
            try
            {
                validationFailures = license.Validate()
                                            .ExpirationDate()
                                            .When(lic => lic.Type == LicenseType.Standard)
                                            .And()
                                            .Signature(publicKey)
                                            .AssertValidLicense().ToList();
            }
            catch
            {
                return false;
            }

            try
            {
                if (!validationFailures.Any())
                    if (license.Id == Register.GetRegisterGuid())
                        return true;
            }
            catch
            {
                return false;
            }

            return false;
        }
    }
}
