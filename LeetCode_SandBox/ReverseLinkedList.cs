using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseLinkedList {
    public ListNode ReverseList(ListNode head) {
        // 破壊的再帰実装
        if (head is null || head.next is null) {
            return head;
        }
        var parent = ReverseList(head.next);
        head.next.next = head;
        head.next = null;
        return parent;
        // 多少性能が悪くなっても非破壊的な実装をする場合は？
    }

    // 多分、非破壊的実装。
    // ToDo: テスト
    public ListNode ReverseList2(ListNode head) {
        if (head is null) {
            return null;
        }
        (ListNode head, ListNode last) LocReverseList(ListNode head) {
            if (head.next is null) {
                var result = new ListNode(head.val, null);
                return (result, result);
            }
            var (rev, last2) = LocReverseList(head.next);
            last2.next = new ListNode(head.val, null);
            return (rev, last2.next);
        }
        return LocReverseList(head).head;
    }
}

