using System.Collections.Generic;
using System.Linq;
using System;

namespace BreakingTheRecords
{
    public static class BreakingTheRecord
    {
        public static List<int> CalculateRecord(List<int> scores) {
            var maxScoreRecord = 0;
            var minScoreRecord = 0;
            var maxScore = scores.First();
            var minScore = scores.First();

            foreach(var score in scores) {
                if (maxScore < score) { 
                    maxScore = score;
                    maxScoreRecord++; 
                } else if (minScore > score) {
                    minScore = score;
                    minScoreRecord++;
                }
            }
            return new List<int> { maxScoreRecord, minScoreRecord };
        }
    }
}
