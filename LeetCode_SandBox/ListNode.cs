using System.Collections.Generic;
using System.Linq;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }

    public static ListNode CreateRange(IEnumerable<int> list) {
        if (!list.Any()) {
            return null;
        }
        return new ListNode(list.First(), CreateRange(list.Skip(1)));
    }
}
