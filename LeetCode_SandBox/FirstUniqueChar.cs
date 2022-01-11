using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/881/
namespace LeetCode_SandBox {
    public static class FirstUniqueChar {
        public static int Execute(string s) {
            // とりあえずDictionaryを使った単純解
            var countDic = new Dictionary<char, (int count, int index)>();
            foreach (var (c,i) in s.Select((c,i)=>(c,i))) {
                countDic[c] = countDic.TryGetValue(c, out var pair)
                    ? (pair.count + 1, pair.index)
                    : (1, i);
            }
            return countDic.Where(x => x.Value.count == 1)
                .OrderBy(x => x.Value.index)
                .Select(x => x.Value.index as int?)
                .FirstOrDefault() ?? -1;
        }

        public static int Execute2(string s) {
            // Dictionaryを後でSortするのでなく、予めソート済みの配列を用意してそちらに書き込んだほうが早いかも
            var duplicateDic = new Dictionary<char, int>();
            int[] countArray = new int[s.Length];
            foreach (var (c, i) in s.Select((c, i) => (c, i))) {
                if(duplicateDic.TryAdd(c,i)) {
                    countArray[i]++;
                }else{
                    countArray[duplicateDic[c]]++;
                }
            }
            for (int i = 0; i < countArray.Length; i++) {
                if (countArray[i] == 1) {
                    return i;
                }
            }
            return -1;
        }
    }
}
