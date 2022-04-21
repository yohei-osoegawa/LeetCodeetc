using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Tests {
    [TestClass()]
    public class ClsTopKFlucuentTests {
        [TestMethod()]
        public void TopKFrequentTest() {
            var nums = new[] { 1, 1, 1, 2, 2, 3 };
            var k = 2;
            var expected = new[] { 1, 2 };
            new ClsTopKFlucuent().TopKFrequent(nums, 2).Should().BeEquivalentTo(expected);
        }
    }
}