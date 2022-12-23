using System;
using TennisScoring;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expectedString = "Enter your set score in this format 7-5 6-2: ";
            var result = new TennisScoring.SetScore();
            Assert.Equal(expectedString, (System.Collections.Generic.IEnumerable<char>)result);
        }

        public void Test2()
        {
            var expectedString = "Enter your tiebreak in this format 10-7: ";
            var result = new TennisScoring.TiebreakScore();
            Assert.Equal(expectedString, (System.Collections.Generic.IEnumerable<char>)result);
        }

        public void Test3()
        {
            var expectedString = "6-";
            var result = new TennisScoring.SetScore();
            Assert.Equal(expectedString, (System.Collections.Generic.IEnumerable<char>)result);
        }

        public void Test4()
        {
            var expectedString = "6";
            var result = new TennisScoring.SetScore();
            Assert.Contains(expectedString, (string)(System.Collections.Generic.IEnumerable<char>)result);
        }

        public void Test5()
        {
            var expectedString = "10";
            var result = new TennisScoring.TiebreakScore();
            Assert.Contains(expectedString, (string)(System.Collections.Generic.IEnumerable<char>)result);
        }


    }
}
