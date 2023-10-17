using System.Globalization;


namespace System
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duratation = DateTime.Now.Subtract(thisObj);
            if (duratation.TotalHours< 24)
            {
                return duratation.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " horas";
            }

            else
            {
                return duratation.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Days";
            }
        }
    }
}
