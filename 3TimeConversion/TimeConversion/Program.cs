using System.Collections.Generic;
using System.Linq;
using System;
using TimeConversion;

namespace TimeConversion
{
    public class Program
    {
        static void Main(string[] args){
            var date = Console.ReadLine();
            var dateMilitarFormat = new TimeConversionHelper().Convert(date);
            Console.WriteLine($"{dateMilitarFormat}");
        }
    }
}
