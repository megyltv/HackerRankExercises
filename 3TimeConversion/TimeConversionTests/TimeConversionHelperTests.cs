using FluentAssertions;
using System;
using TimeConversion;
using Xunit;

namespace TimeConversionTests
{
    public class TimeConversionHelperTests
    {
        private readonly TimeConversionHelper _helper;

        public TimeConversionHelperTests()
        {
            _helper = new TimeConversionHelper();
        }

        [Fact]
        public void Convert_ShouldConvertAMDateString_ToMilitarHour()
        {
            var dateString = "01:12:13AM";
            
            var actualResult = _helper.Convert(dateString);

            var expectedResult = "01:12:13";
            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void Convert_ShouldConvertPMDateString_ToMilitarHour()
        {
            var dateString = "07:12:13PM";

            var actualResult = _helper.Convert(dateString);

            var expectedResult = "19:12:13";
            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void Convert_ShouldConvert12AMDateString_To00MilitarHour()
        {
            var dateString = "12:00:00AM";

            var actualResult = _helper.Convert(dateString);

            var expectedResult = "00:00:00";
            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void Convert_ShouldConvert12PMDateString_To00MilitarHour()
        {
            var dateString = "12:00:00PM";

            var actualResult = _helper.Convert(dateString);

            var expectedResult = "12:00:00";
            actualResult.Should().Be(expectedResult);
        }
    }
}
