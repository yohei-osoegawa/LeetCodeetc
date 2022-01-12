using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_SandBox;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using System.Linq;

namespace LeetCode_SandBox.Tests {
    [TestClass()]
    public class ContainsDuplicateTests {
        [TestMethod()]
        public void ExecuteTest() {
            var inputs = new[] {
                new[]{ 1, 2, 3, 1 },
                new[]{ 1, 2, 3, 4 },
                new[]{ 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }
            };
            var expecteds = new[] { true, false, true };
            foreach (var (input, expected) in inputs.Zip(expecteds)) {
                ContainsDuplicate.Execute(input).Should().Be(expected);
            }
        }

        [TestMethod()]
        public void ExecuteTest2() {
            var inputs = new[] {
                new[]{ 1, 2, 3, 1 },
                new[]{ 1, 2, 3, 4 },
                new[]{ 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }
            };
            var expecteds = new[] { true, false, true };
            foreach (var (input, expected) in inputs.Zip(expecteds)) {
                ContainsDuplicate.Execute2(input).Should().Be(expected);
            }
        }
    }
}