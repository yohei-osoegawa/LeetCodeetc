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
    public class ValidPalindromeTests {
        [TestMethod()]
        public void ExecuteTest() {
            var inputs = new[] {
                "A man, a plan, a canal: Panama",
                "race a car",
                " ",
            };
            var expecteds = new[] {
                true,
                false,
                true,
            };
            foreach (var (input,expect) in inputs.Zip(expecteds)) {
                ValidPalindrome.Execute(input).Should().Be(expect);
            }
            
        }
    }
}