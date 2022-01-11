using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_SandBox;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using FluentAssertions;

namespace LeetCode_SandBox.Tests {
    [TestClass()]
    public class FirstUniqueCharTests {
        [TestMethod()]
        public void ExecuteTest() {
            var inputs = new[] { "leetcode", "loveleetcode", "aabb" };
            var expexteds = new[] { 0, 2, -1 };
            foreach (var (input, expected) in inputs.Zip(expexteds)) {
                FirstUniqueChar.Execute(input).Should().Be(expected, $"input:{input}");
            }
        }
    }
}