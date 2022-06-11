using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests {
    [TestClass()]
    public class ReverseLinkedListTests {
        [TestMethod()]
        public void ReverseList2Test() {
            var listNode = ListNode.CreateRange(new[] { 1, 2, 3, 4, 5 });
            var listNode2 = ListNode.CreateRange(new[] { 1, 2, 3, 4, 5 });
            var expected = ListNode.CreateRange(new[] { 5, 4, 3, 2, 1 });
            var actual = new ReverseLinkedList().ReverseList2(listNode);
            actual.Should().BeEquivalentTo(expected);
            listNode.Should().BeEquivalentTo(listNode2);
        }
    }
}