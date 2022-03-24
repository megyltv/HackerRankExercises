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
            
            for (var index = 0; index < numbers.Count; index++) {
                long sum = 0;
                var indexToSum = 0;
                
                while(indexToSum < numbers.Count) {
                    if (index!=indexToSum) {
                        sum += numbers[indexToSum];
                    }
                    indexToSum++;
                }
                
                if (minSum > sum || index == 0) { minSum = sum; }
                if (maxSum < sum) { maxSum = sum; }
            }
            
            var results = new List<long> { minSum, maxSum };
            return results;
        }
    }
}
