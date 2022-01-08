using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_20210919;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace LeetCode_20210919.Tests {
    [TestClass()]
    public class ReverseStringTests {
        [TestMethod()]
        public void ExecuteTest() {
            var s = new[] { 'h', 'e', 'l', 'l', 'o' };
            var expected = new[] { 'o', 'l', 'l', 'e', 'h' };
            ReverseString.Execute(s);
            s.Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void Execute2Test() {
            var s = new[] { 'h', 'e', 'l', 'l', 'o' };
            var expected = new[] { 'o', 'l', 'l', 'e', 'h' };
            ReverseString.Execute2(s);
            s.Should().BeEquivalentTo(expected);
        }
    }
}