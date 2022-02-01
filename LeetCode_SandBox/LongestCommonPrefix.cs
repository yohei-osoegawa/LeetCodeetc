using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_SandBox {
    public static class LongestCommonPrefix {
        public static string Execute(string[] strs) {
            // 単なる総当たりで問題ないと判断
            // より早くできる様子。どのように工夫すればいい？

            if (strs.Length == 0) {
                return "";
            }

            var minStr = strs.Aggregate((acc, next) => acc.Length > next.Length ? next : acc);
            string result="";
            for (int i = 0; i < minStr.Length; i++) {
                var head = strs.First()[0..(i+1)];
                if (strs.Select(str => str[0..(i+1)]).All(x => x == head)) {
                    result = head;
                } else {
                    break;
                }
            }
            return result;
        }
    }
}
