using System;

namespace TimeConversion
{
    public class TimeConversionHelper
    {
        public string Convert(string date) {
            var period = date.Substring(date.Length-2);

            if(period == "PM") {
                Int16.TryParse(date.Substring(0,2), out var hourInt);
                hourInt += 12;
                return $"{hourInt}:{date.Substring(3, date.Length - 5)}";
            }
            return date.Substring(0, date.Length - 2);
        }
    }
}
