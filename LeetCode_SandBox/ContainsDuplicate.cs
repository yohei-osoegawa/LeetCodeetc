using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace LeetCode_SandBox {
    // https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/578/
    public class ContainsDuplicate {
        public static bool Execute(int[] input) {
            // 単純解ならSet使う
            return new HashSet<int>(input).Count != input.Length;
        }

        public static bool Execute2(int[] input) {
            // Execute1は重複があるときも計算を打ち切らず最後まで実施するので、そこを改善する。
            // O(nlogn)のmerge sortを用いて重複が存在するときには計算を打ち切ることとする。
            return MergeSort(input).hasDuplicate;
        }

        /// <summary>
        /// 再帰関数を利用したマージソート、ただし重複があったら処理を打ち切る
        /// </summary>
        static (int[] sorted, bool hasDuplicate) MergeSort(int[] input) {
            // 自明解、再帰の終了条件
            if (input.Length<=1) {
                return (input, false);
            }

            var (arr1, arr2) = Split(input);
            var (sorted1, hasDuplicate1) = MergeSort(arr1);
            if (hasDuplicate1) {
                return (null, true);
            }
            var(sorted2, hasDuplicate2) = MergeSort(arr2);
            if (hasDuplicate2) {
                return (null, true);
            }
            return Sort(sorted1, sorted2);
        }

        /// <summary>
        /// 配列を真ん中で分割、右寄せ。
        /// </summary>
        static (int[] splited1, int[] splited2) Split(int[] input) {
            return (input[..(input.Length / 2)], input[(input.Length / 2)..]);
        }

        /// <summary>
        /// 引数を合成してソート、重複があったら処理を打ち切って重複がある旨を返す
        /// </summary>
        /// <param name="sorted1">ソート済み配列</param>
        /// <param name="sorted2">ソート済み配列</param>
        /// <returns>(ソート済み配列 or null, 重複があるか)</returns>
        static (int[] sorted, bool hasDuplicate) Sort(int[] sorted1, int[] sorted2) {
            var (i, j) = (0, 0);
            var result = new List<int>();
            while (i < sorted1.Length || j < sorted2.Length) {
                if (i == sorted1.Length) {
                    result.Add(sorted2[j]);
                    j++;
                }else if(j == sorted2.Length) {
                    result.Add(sorted1[i]);
                    i++;
                }else if(sorted1[i] < sorted2[j]) {
                    result.Add(sorted1[i]);
                    i++;
                }else if(sorted1[i] > sorted2[j]) {
                    result.Add(sorted2[j]);
                    j++;
                }else{
                    // 重複あり、処理打ち切り
                    return (null, true);
                }
            }
            return (result.ToArray(), false);
        }
    }
}
