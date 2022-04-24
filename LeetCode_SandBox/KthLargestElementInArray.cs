using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/explore/interview/card/top-interview-questions-medium/110/sorting-and-searching/800/
public class KthLargestElementInArray {
    public int FindKthLargest(int[] nums, int k) {
        // クイックソートする
        static void QuickSort(int[] nums, int begin, int end) {
            if (end - begin <= 1) {
                return;
            } else if (end - begin == 2) {
                if (nums[begin] > nums[end - 1]) {
                    (nums[begin], nums[end - 1]) = (nums[end - 1], nums[begin]);
                }
                return;
            }
            var pivot = nums[(begin + end - 1) / 2];

            var lefti = begin;
            var righti = end - 1;
            while (lefti <= righti) {
                while (lefti <= righti && nums[lefti] <= pivot) {
                    lefti++;
                }
                while (lefti <= righti && nums[righti] > pivot) {
                    righti--;
                }
                if (lefti < righti) {
                    (nums[lefti], nums[righti]) = (nums[righti], nums[lefti]);
                } else if (lefti == end) {
                    (nums[(begin + end - 1) / 2], nums[end - 1]) = (nums[end - 1], nums[(begin + end - 1) / 2]);
                    righti = end - 2;
                    break;
                }
            }
            var end1 = righti;
            QuickSort(nums, begin, end1 + 1);
            QuickSort(nums, end1 + 1, end);
        }
        QuickSort(nums, 0, nums.Length);
        return nums[^k];
    }
}

