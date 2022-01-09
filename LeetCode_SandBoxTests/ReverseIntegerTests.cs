using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_SandBox;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using FluentAssertions;

namespace LeetCode_SandBox.Tests {
    [TestClass()]
    public class ReverseIntegerTests {
        [TestMethod()]
        public void ReverseTest() {
            var xList = new[] { 123, -120, 0 };
            var expecteds = new[] { 321, -21,00 };
            foreach (var (x, expected) in xList.Zip(expecteds)) {
                ReverseInteger.Reverse(x).Should().Be(expected);
            }
        }

        [TestMethod()]
        public void Reverse2Test() {
            var xList = new[] { 123, -120, 0 };
            var expecteds = new[] { 321, -21, 0 };
            foreach (var (x, expected) in xList.Zip(expecteds)) {
                ReverseInteger.Reverse2(x).Should().Be(expected);
            }
        }

        [TestMethod()]
        public void Reverse3Test() {
            var xList = new[] { 123, -120, 0 };
            var expecteds = new[] { 321, -21, 0 };
            foreach (var (x, expected) in xList.Zip(expecteds)) {
                ReverseInteger.Reverse3(x).Should().Be(expected);
            }
        }
    }
}