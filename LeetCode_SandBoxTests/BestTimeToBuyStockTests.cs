using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests {
    [TestClass()]
    public class BestTimeToBuyStockTests {
        [TestMethod()]
        public void MaxProfitTest() {
            var input = new[] { 7, 1, 5, 3, 6, 4 };
            var expected = 7;
            var actual = new BestTimeToBuyStock().MaxProfit(input);
            actual.Should().Be(expected);
        }

        [TestMethod()]
        public void MaxProfitTest2() {
            var input = new[] { 7, 6, 4, 3, 1 };
            var expected = 0;
            var actual = new BestTimeToBuyStock().MaxProfit(input);
            actual.Should().Be(expected);
        }
    }
}