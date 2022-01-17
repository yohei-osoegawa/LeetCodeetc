using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_SandBox {
    // https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/882/
    public static class ValidAnagram {
        public static bool IsAnagram(string s, string t) {
            // グルーピングして全一致しているか確認すればいいだけ。
            // ※値がprimitiveなほうが比較の時楽
            var sDic = s.ToCharArray().ToLookup(x => x).ToDictionary(x => x.Key, x => x.Count());
            var tDic = t.ToCharArray().ToLookup(x => x).ToDictionary(x => x.Key, x => x.Count());

            bool same = true;
            same = sDic.Count == tDic.Count;

            foreach (var (key,value) in sDic) {
                if(!tDic.TryGetValue(key,out var value2)) {
                    same = false;
                    break;
                }
                if(value != value2) {
                    same = false;
                    break;
                }
            }
            return same;
        }
    }
}
