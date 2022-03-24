using System.Collections.Generic;
using System.Linq;
using System;
using MiniMaxSum;

namespace MiniMaxSum
{
    public class Program
    {
        static void Main(string[] args){
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            var results = MiniMaxSumCalculator.MiniMaxSum(arr);
            Console.WriteLine($"{results.First()} {results.Last()}");
        }
    }
}
