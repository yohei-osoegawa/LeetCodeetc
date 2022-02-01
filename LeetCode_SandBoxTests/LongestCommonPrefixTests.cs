using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_SandBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace LeetCode_SandBox.Tests {
    [TestClass()]
    public class LongestCommonPrefixTests {
        [TestMethod()]
        public void ExecuteTest() {
            var strs = new[] { "flower", "flow", "flight" };
            var expected = "fl";
            LongestCommonPrefix.Execute(strs).Should().Be(expected);
        }
        [TestMethod()]
        public void ExecuteTest2() {
            var strs = new[] { "dog", "racecar", "car" };
            var expected = "";
            LongestCommonPrefix.Execute(strs).Should().Be(expected);
        }
    }
}