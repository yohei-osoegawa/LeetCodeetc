using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests {
    [TestClass()]
    public class KthLargestElementInArrayTests {
        [TestMethod()]
        public void FindKthLargestTest() {
            var nums = new[] { 3, 2, 1, 5, 6, 4 };
            var k = 2;

            var expected = 5;
            var actual = new KthLargestElementInArray().FindKthLargest(nums, k);

            actual.Should().Be(expected);
        }

        [TestMethod()]
        public void FindKthLargestTest2() {
            var nums = new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            var k = 4;

            var expected = 4;
            var actual = new KthLargestElementInArray().FindKthLargest(nums, k);

            actual.Should().Be(expected);
        }

        [TestMethod()]
        public void FindKthLargestTest3() {
            var nums = new[] { 5, 2, 4, 1, 3, 6, 0 };
            var k = 2;

            var expected = 5;
            var actual = new KthLargestElementInArray().FindKthLargest(nums, k);

            actual.Should().Be(expected);
        }
    }
}