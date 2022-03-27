using FluentAssertions;
using System;
using TimeConversion;
using Xunit;

namespace TimeConversionTests
{
    public class TimeConversionHelperTests
    {
        [Fact]
        public void Convert_ShouldConvertAMDateString_ToMilitarHour()
        {
            var dateString = "01:12:13AM";
            var helper = new TimeConversionHelper();

            var actualResult = helper.Convert(dateString);

            var expectedResult = "01:12:13";
            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void Convert_ShouldConvertPMDateString_ToMilitarHour()
        {
            var dateString = "07:12:13PM";
            var helper = new TimeConversionHelper();

            var actualResult = helper.Convert(dateString);

            var expectedResult = "19:12:13";
            actualResult.Should().Be(expectedResult);
        }
    }
}
