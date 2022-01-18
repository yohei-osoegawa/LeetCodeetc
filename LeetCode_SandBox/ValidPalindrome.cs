using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace LeetCode_SandBox {
    public static class ValidPalindrome {
        public static bool Execute(string s) {
            // 正規表現でエスケープすべき文字列の削除ができそうなので、それが回文か判定する（大文字小文字は問わない）
            // https://docs.microsoft.com/ja-jp/dotnet/standard/base-types/character-escapes-in-regular-expressions
            var formated = Regex.Replace(s, "[^a-zA-Z0-9]", "");
            bool result = true;
            foreach (var (c1,c2) in formated.Reverse().Zip(formated.ToCharArray())) {
                if(Char.ToUpper(c1) != Char.ToUpper(c2)) {
                    result = false;
                }
            }
            return result;
        }
    }
}
