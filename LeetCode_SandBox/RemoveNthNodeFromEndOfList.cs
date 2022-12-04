using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class RemoveNthNodeFromEndOfList {
    // https://leetcode.com/problems/remove-nth-node-from-end-of-list/
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        // メモリ制約がないので、リストにそれぞれのノードを記憶させる方針
        var nodes = new List<ListNode> { head };
        var next = head.next;
        while (next is not null) {
            nodes.Add(next);
            next = next.next;
        }
        var shouldRemove = nodes[^n];
        
        // 削除ノードが末尾の場合
        if (n==1) {
            if (nodes.Count == 1)
                return null;
            else
                nodes[^2].next = nodes[^2].next.next;
            return head;
        } else {
            shouldRemove.val = shouldRemove.next.val;
            shouldRemove.next = shouldRemove.next.next;
            return head;
        }
    }
}

