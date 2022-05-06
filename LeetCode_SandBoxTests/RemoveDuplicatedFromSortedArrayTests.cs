using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests {
    [TestClass()]
    public class RemoveDuplicatedFromSortedArrayTests {
        [TestMethod()]
        public void RemoveDuplicatesTest() {
            var input = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var expected = 5;
            var actual = new RemoveDuplicatedFromSortedArray().RemoveDuplicates(input);
            actual.Should().Be(expected);
            input.Should().StartWith(new[] { 0, 1, 2, 3, 4 });
        }
    }
}