using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests {
    [TestClass()]
    public class RotateArrayTests {
        [TestMethod()]
        public void RotateTest() {
            var nums = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var k = 3;
            new RotateArray().Rotate(nums, k);
            var expected = new[] { 5, 6, 7, 1, 2, 3, 4 };
            nums.Should().Equal(expected);
        }

        [TestMethod()]
        public void RotateTest2() {
            var nums = new[] { -1, -100, 3, 99 };
            var k = 2;
            new RotateArray().Rotate(nums, k);
            var expected = new[] { 3, 99, -1, -100 };
            nums.Should().Equal(expected);
        }
    }
}