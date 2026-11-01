using System;
using System.IO;
using System.Windows.Forms;

namespace MultiWhatsapp.Forms
{
    public partial class ActivateForm : BaseForm
    {
        public ActivateForm()
        {
            InitializeComponent();

            var appGuid = Register.GetAppGuid();
            var registerGuid = Register.GetRegisterGuid(appGuid);
            idBox.Text = registerGuid.ToString();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(idBox.Text);
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK &&
                !string.IsNullOrWhiteSpace(openFileDialog1.FileName))
                browseBox.Text = openFileDialog1.FileName;
        }

        private void ActivateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(browseBox.Text))
                MessageBox.Show("لطفا فایل فعالساز را انتخاب کنید");
            else if (!File.Exists(browseBox.Text))
                MessageBox.Show("فایل فعالساز یافت نشد");
            else
            {
                Directory.CreateDirectory(Register.AppDataPath);
                File.Copy(browseBox.Text, Register.LicensePath);
                MessageBox.Show("کد فعالساز ثبت شد. لطفا برنامه را دوباره باز کنید");
                Close();
            }
        }
    }
}