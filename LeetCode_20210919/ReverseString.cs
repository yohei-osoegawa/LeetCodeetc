using System.Linq;

namespace LeetCode_20210919 {
    public static class ReverseString {
        public static void Execute(char[] s) {
            // メモリを気にしない単純解、Reverseは使わない
            foreach (var (x, i) in s.Select((x, i) => (x, i)).ToList()) {
                s[s.Length - i - 1] = x;
            }
        }

        public static void Execute2(char[] s) {
            // メモリ制約がある場合
            var length = s.Length;
            for (int i = 0; i < length; i++) {
                (s[i], s[length - i - 1]) = (s[length - i - 1], s[i]);
            }
        }
    }
}
