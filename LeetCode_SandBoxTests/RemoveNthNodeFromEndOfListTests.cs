using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests {
    [TestClass()]
    public class RemoveNthNodeFromEndOfListTests {
        [TestMethod()]
        public void RemoveNthFromEndTest() {
            var head = new ListNode(
                1,
                new ListNode(
                    2,
                    new ListNode(
                        3,
                        new ListNode(
                            4,
                            new ListNode(5)
                        )
                    )
                )
            );

            var expected = new ListNode(
                1,
                new ListNode(
                    2,
                    new ListNode(
                        3,
                        new ListNode(5)
                    )
                )
            );

            new RemoveNthNodeFromEndOfList().RemoveNthFromEnd(head, 2).Should().BeEquivalentTo(expected);
        }

        [TestMethod()]
        public void RemoveNthFromEndTest2() {
            var head = new ListNode(
                1
            );

            ListNode expected = null;

            new RemoveNthNodeFromEndOfList().RemoveNthFromEnd(head, 1).Should().BeEquivalentTo(expected);
        }
    }
}