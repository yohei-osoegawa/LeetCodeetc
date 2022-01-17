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
    public class ValidAnagramTests {
        [TestMethod()]
        public void IsAnagramTest() {
            var inputs1 = new[] {
                "anagram",
                "rat"
            };
            var inputs2 = new[] {
                "nagaram",
                "car"
            };
            var expecteds = new[] { true, false };


            foreach (var ((s,t),expected) in inputs1.Zip(inputs2).Zip(expecteds)) {
                ValidAnagram.IsAnagram(s, t).Should().Be(expected);
            }
        }

        [TestMethod()]
        public void IsAnagram2Test() {
            var inputs1 = new[] {
                "anagram",
                "rat"
            };
            var inputs2 = new[] {
                "nagaram",
                "car"
            };
            var expecteds = new[] { true, false };


            foreach (var ((s, t), expected) in inputs1.Zip(inputs2).Zip(expecteds)) {
                ValidAnagram.IsAnagram2(s, t).Should().Be(expected);
            }
        }
    }
}