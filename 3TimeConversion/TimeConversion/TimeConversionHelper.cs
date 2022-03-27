using System;

namespace TimeConversion
{
    public class TimeConversionHelper
    {
        public string Convert(string date) {
            DateTime.TryParse(date, out var time);
            return time.ToString("HH:mm:ss");
        }
    }
}
