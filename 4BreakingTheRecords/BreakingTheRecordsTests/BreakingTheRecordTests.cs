using BreakingTheRecords;
using FluentAssertions;
using System.Collections.Generic;
using System.Linq;
using System;
using Xunit;

namespace BreakingTheRecordsTests
{
    public class BreakingTheRecordTests
    {
        [Fact]
        public void CalculateRecord_ShouldRecordsBeZero_WhenThereIsOnlyOneScore()
        {
            var scores = new List<int> { 10 };

            var actualResults = BreakingTheRecord.CalculateRecord(scores);

            actualResults.Should().Equal(new List<int> {0,0});
        }

        [Fact]
        public void CalculateRecord_ShouldRecordsStayAsZero_WhenNoScoreHasBeenBroken()
        {
            var scores = new List<int> { 10, 10 };

            var actualResults = BreakingTheRecord.CalculateRecord(scores);

            actualResults.Should().Equal(new List<int> {0,0});
        }

        [Fact]
        public void CalculateRecord_ShouldAddsRecordForMostPoints_WhenTheScoreIsBroken()
        {
            var scores = new List<int> { 10, 20 };

            var actualResults = BreakingTheRecord.CalculateRecord(scores);

            actualResults.Should().Equal(new List<int> {1,0});
        }

        [Fact]
        public void CalculateRecord_ShouldAddsRecordForLessPoints_WhenTheScoreIsBroken()
        {
            var scores = new List<int> { 10, 5 };

            var actualResults = BreakingTheRecord.CalculateRecord(scores);

            actualResults.Should().Equal(new List<int> {0, 1});
        }

        [Fact]
        public void CalculateRecord_ShouldAddsRecord_WhenSendingMultipleScores()
        {
            var scores = new List<int> { 10, 5, 20, 20, 4, 5, 2, 25, 1 };

            var actualResults = BreakingTheRecord.CalculateRecord(scores);

            actualResults.Should().Equal(new List<int> {2, 4});
        }
    }
}
