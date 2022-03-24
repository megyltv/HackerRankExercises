using FluentAssertions;
using MiniMaxSum;
using System.Collections.Generic;
using System.Linq;
using System;
using Xunit;

namespace MiniMaxSumTest
{
    public class MiniMaxSumCalculatorTests
    {
        [Fact]
        public void MiniMaxSum_ShouldPrintMinimunValue_AsFirstValueInList()
        {
            var numbers =  new List<int>{ 1,2,3,4,5 };

            var actualSum = MiniMaxSumCalculator.MiniMaxSum(numbers);

            actualSum.First().Should().Be(10);
        }

        [Fact]
        public void MiniMaxSum_ShouldReturnMaximunValue_AsLastValueInList()
        {
            var numbers =  new List<int>{ 1,2,3,4,5 };

            var actualSum = MiniMaxSumCalculator.MiniMaxSum(numbers);

            actualSum.Last().Should().Be(14);
        }

        [Fact]
        public void MiniMaxSum_ShouldReturnMinAndMaxSumValue_IndependentlyOfTheSorting()
        {
            var numbers =  new List<int>{ 4, 80, 13, 20, 1 };

            var actualSum = MiniMaxSumCalculator.MiniMaxSum(numbers);

            actualSum.First().Should().Be(38);
            actualSum.Last().Should().Be(117);
        }

        [Fact]
        public void MiniMaxSum_ShouldReturnMinAndMaxSumValue_GivenBigIntegers()
        {
            var numbers =  new List<int>{ 364801279, 396285104, 573261094, 759641832, 819230764 };

            var actualSum = MiniMaxSumCalculator.MiniMaxSum(numbers);

            actualSum.First().Should().Be(2093989309);
            actualSum.Last().Should().Be(2548418794);
        }
    }
}
