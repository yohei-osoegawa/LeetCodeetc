using System.Linq;

namespace LeetCode_20210919 {
    public static class ReverseString {
        public static void Execute(char[] s) {
            // メモリを気にしない単純解、Reverseは使わない
            
            foreach (var (x,i) in s.Select((x,i)=>(x,i))) {
                s[s.Length - i - 1] = x;
            }
        }
    }
}
