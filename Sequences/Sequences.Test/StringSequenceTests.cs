using System;
using Xunit;
using System.Collections.Generic;
using Sequences.Library;

namespace Sequences.Tests
{
    
    public class StringSequenceTests
    {
        [Fact]
        public void AddShouldAdd()
        {
            //arrange (any setup neccesary to prepare for the behavior to test)
            var seq = new StringSequence();

            //act (do the thing you want to test)
            seq.Add("abc");
            seq.Add("def");

            //assert (verify that the behavior was as expected)
            Assert.Equal(expected: "abc", actual: seq[0]);
            Assert.Equal(expected: "def", actual: seq[1]);

        }
        [Fact]
        public void AccessOutOfBoundsShouldThrow()
        {
            var seq = new StringSequence();

            Assert.ThrowsAny < ArgumentOutOfRangeException >(()
               => {
                    var x = seq[0];
               });
        }

        [Fact]
        public void LongestStringShouldReturnLongest()
        {
            var seq = new StringSequence();
            seq.Add("");
            seq.Add("abc");
            seq.Add("0918034");

            var longest = seq.LongestString();

            Assert.Equal("0918034", longest);
        }
    }
}
