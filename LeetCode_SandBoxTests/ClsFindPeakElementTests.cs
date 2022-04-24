using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests {
    [TestClass()]
    public class ClsFindPeakElementTests {
        [TestMethod()]
        public void FindPeakElementTest() {
            var nums = new[] { 1, 2, 1, 3, 5, 6, 4 };
            var expected = 1;
            var expected2 = 5;

            new ClsFindPeakElement().FindPeakElement(nums)
                .Should().Match(actual => actual == expected || actual == expected2);
        }
        [TestMethod()]
        public void FindPeakElementTest2() {
            var nums = new[] { 1, 2 };
            var expected = 1;

            new ClsFindPeakElement().FindPeakElement(nums)
                .Should().Be(expected);
        }
    }
}