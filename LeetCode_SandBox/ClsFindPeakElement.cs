using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// https://leetcode.com/problems/find-peak-element/
public class ClsFindPeakElement {
    public int FindPeakElement(int[] nums) {
        return FindPeakElement(nums, 0, nums.Length);
    }

    static int FindPeakElement(int[] nums, int begin, int end) {
        if (end - begin == 1) {
            return begin;
        }
        var halfi = (begin + end - 1) / 2;
        if ((halfi == 0 || nums[halfi - 1] < nums[halfi])
            && (halfi == nums.Length - 1 || nums[halfi] > nums[halfi + 1])
        ) {
            return halfi;
        } else if (halfi == 0 || nums[halfi - 1] < nums[halfi]) {
            return FindPeakElement(nums, halfi + 1, end);
        } else {
            return FindPeakElement(nums, begin, halfi + 1);
        }
    }
}

