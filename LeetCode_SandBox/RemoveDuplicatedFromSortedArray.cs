using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/727/
public class RemoveDuplicatedFromSortedArray {
    public int RemoveDuplicates(int[] nums) {
        int? acc = null;
        int count = 0;
        int dsti = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (acc != nums[i]) {
                acc = nums[dsti] = nums[i];
                dsti++;
                count++;
            }
        }
        return count;
    }
}

