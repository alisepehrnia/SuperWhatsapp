using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MultiWhatsapp
{
    public static class UI
    {
        #region SplashScreen
        public static void ShowSplashScreen(Form form)
        {
            var splashThread = new Thread(() => Application.Run(form));
            splashThread.SetApartmentState(ApartmentState.STA);
            splashThread.Start();
        }
        public static void SafeSplashClose(Form form)
        {
            form?.Invoke(new Action(form.Close));
        }
        #endregion
    }

    public static class DateAndTime
        {
            public static int CalculateDate(DateTime? dateTime = null)
            {
                PersianCalendar pCal = new PersianCalendar();
                DateTime date = DateTime.Now;
                if (dateTime.HasValue) date = dateTime.Value;
                return pCal.GetYear(date) * 10000 + pCal.GetMonth(date) * 100 + pCal.GetDayOfMonth(date);
            }
            public static int CalculateTime(DateTime? dateTime = null)
            {
                DateTime date = DateTime.Now;
                if (dateTime.HasValue) date = dateTime.Value;
                return date.Hour * 100 + date.Minute;
            }
        }

    public static class Text
    {
        public static bool AnyNullOrWhiteSpace(params string[] strings)
        {
            return strings.Any(string.IsNullOrWhiteSpace);
        }
    }
}
