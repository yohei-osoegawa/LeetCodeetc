using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_SandBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace LeetCode_SandBox.Tests {
    [TestClass()]
    public class ImplementstrStrTests {
        [TestMethod()]
        public void StrStrTest() {
            var input1 = "hello";
            var input2 = "ll";
            var expected = 2;
            ImplementstrStr.StrStr(input1, input2).Should().Be(expected);
        }

        [TestMethod()]
        public void StrStrTest2() {
            var input1 = "aaaaa";
            var input2 = "bba";
            var expected = -1;
            ImplementstrStr.StrStr(input1, input2).Should().Be(expected);
        }

        [TestMethod()]
        public void StrStrTest3() {
            var input1 = "";
            var input2 = "";
            var expected = 0;
            ImplementstrStr.StrStr(input1, input2).Should().Be(expected);
        }
    }
}