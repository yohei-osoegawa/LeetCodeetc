using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_SandBox {
    // https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/880/
    public static class ReverseInteger {
        public static int Reverse(int x) {
            // 文字列を使ったやり方に帰着する
            var plus = x >= 0;
            var rev = plus
                ? x.ToString().Reverse().ToArray()
                : x.ToString().Skip(1).Reverse().ToArray();
            var str = new string(rev);
            return plus
                ? int.Parse(str)
                : -int.Parse(str);
        }

        public static int Reverse2(int x) {
            // 数値型のまま実行する場合
            var maxDigit = 0;
            var eachNumList = new List<int>();
            {
                var acc = x;
                while (acc != 0) {
                    eachNumList.Add(acc % 10);
                    acc = acc / 10;
                    maxDigit++;
                }
            }
            var result = 0;
            for (int i = 0; i < maxDigit; i++) {
                var digit = (int)Math.Pow(10, maxDigit - i - 1);
                result += eachNumList[i] * digit;
            }
            return result;
        }

        public static int Reverse3(int x) {
            // Reverse2の冗長な部分をオミット
            var maxDigit = x == 0
                ? 0
                : (int)(MathF.Log10(Math.Abs(x)) + 1);

            var result = 0;
            {
                var acc = x;
                for (int i = 0; i < maxDigit; i++) {
                    var digitRev = (int)Math.Pow(10, maxDigit - i - 1);
                    result += (acc % 10) * digitRev;
                    acc = acc / 10;
                }
            }
            return result;
        }

    }
}
