using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests {
    [TestClass()]
    public class ClsSingleNumberTests {
        [TestMethod()]
        public void SingleNumberTest() {
            var nums = new[] { 4, 1, 2, 1, 2 };
            var expected = 4;
            new ClsSingleNumber().SingleNumber(nums).Should().Be(expected);
        }
    }
}