using System;

namespace TimeConversion
{
    public class TimeConversionHelper
    {
        public string Convert(string date) {
            var period = date.Substring(date.Length-2);
            Int16.TryParse(date.Substring(0,2), out var hourInt);

            if (period == "AM" && hourInt == 12) {
                return $"00:{date.Substring(3, date.Length - 5)}";
            }

            if (period == "PM" && hourInt != 12) {
                hourInt += 12;
                return $"{hourInt}:{date.Substring(3, date.Length - 5)}";
            }
            return date.Substring(0, date.Length - 2);
        }
    }
}
