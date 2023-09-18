using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTests
    {
        //[Fact]
        [Theory]
        [InlineData("racecar", true)]
        public void IsPalodromeTest(string tstStr, bool expected)
        {

            //Arrange - prep code, instantiate class
            WordSmith tstAStr = new WordSmith();

            //Act - Call the method
            bool actual = tstAStr.IsAPalindrome(tstStr);

            //Assert - compare expected with the actual
            Assert.Equal(expected, actual);

        }
    }
}
