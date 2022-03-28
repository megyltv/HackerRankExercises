using BreakingTheRecords;
using System.Collections.Generic;
using System.Linq;
using System;

namespace BreakingTheRecords
{
    public class Program
    {
        static void Main(string[] args){
            List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();
            
            List<int> result = BreakingTheRecord.CalculateRecord(scores);

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
