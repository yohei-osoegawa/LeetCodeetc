using System.Linq;
using System.Text.RegularExpressions;

namespace LeetCode_SandBox {
    public static class StringToInteger {
        public static int MyAtoi(string s) {
            // 正規表現かなあ
            var resultCollection = Regex.Matches(s, @"(?<=^\s*)[+,-]?[0-9]+");
            var str = resultCollection.FirstOrDefault()?.Value;
            if (string.IsNullOrEmpty(str)) {
                return 0;
            }
            if (int.TryParse(str, out var result)) {
                return result;
            } else if (str[0] == '-') {
                return int.MinValue;
            } else {
                return int.MaxValue;
            }
        }
    }
}
