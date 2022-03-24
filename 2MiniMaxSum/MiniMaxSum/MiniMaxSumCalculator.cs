using System.Collections.Generic;
using System.Linq;
using System;

namespace MiniMaxSum
{
    public static class MiniMaxSumCalculator
    {
        public static List<long> MiniMaxSum(List<int> numbers)
        {
            long minSum = 0;
            long maxSum = 0;
            numbers.Sort();
            
            for (var index = 0; index < numbers.Count; index++) {
                if (index != numbers.Count - 1) { minSum += numbers.ElementAt(index); }
                if (index != 0) { maxSum += numbers.ElementAt(index); }
            }
            
            var results = new List<long> { minSum, maxSum };
            return results;
        }
    }
}
