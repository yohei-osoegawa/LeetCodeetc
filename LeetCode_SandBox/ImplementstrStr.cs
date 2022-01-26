using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_SandBox {
    // https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/885/
    public static class ImplementstrStr {
        public static int StrStr(string haystack, string needle) {
            // window関数があれば一発
            // CSharpには存在しないのでWindow関数を作って適用する。
            static IEnumerable<string> StrWindow(string input, int length) {
                if (length > input.Length) {
                    yield return input ;
                    yield break;
                }
                for (int i = 0; i < input.Length - length + 1; i++) {
                    yield return input[i..(i+length)];
                }
            }

            if(needle is "") {
                return 0;
            }

            var windowed = StrWindow(haystack, needle.Length);
            var cand = windowed.Select((value, i) => (value, i) ).FirstOrDefault(x=>x.value==needle);
            if(cand == default) {
                return -1;
            } else {
                return cand.i;
            }

        }
    }
}
