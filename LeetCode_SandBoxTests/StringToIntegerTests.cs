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
    public class StringToIntegerTests {
        [TestMethod()]
        public void MyAtoiTest() {
            var input = "42";
            var expected = 42;
            StringToInteger.MyAtoi(input).Should().Be(expected);
        }

        [TestMethod()]
        public void MyAtoiTest2() {
            var input = "   -42";
            var expected = -42;
            StringToInteger.MyAtoi(input).Should().Be(expected);
        }

        [TestMethod()]
        public void MyAtoiTest3() {
            var input = "4193 with words";
            var expected = 4193;
            StringToInteger.MyAtoi(input).Should().Be(expected);
        }

        [TestMethod()]
        public void MyAtoiTest4() {
            var input = "words and 987";
            var expected = 0;
            StringToInteger.MyAtoi(input).Should().Be(expected);
        }


        [TestMethod()]
        public void MyAtoiTest5() {
            var input = "-91283472332";
            var expected = int.MinValue;
            StringToInteger.MyAtoi(input).Should().Be(expected);
        }

        [TestMethod()]
        public void MyAtoiTest6() {
            var input = "90000000000";
            var expected = int.MaxValue;
            StringToInteger.MyAtoi(input).Should().Be(expected);
        }
    }
}