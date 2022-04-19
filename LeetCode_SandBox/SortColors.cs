using System;

public class ClsSortColors {
    public void SortColors(int[] nums) {
        // 3状態しかないことに着目して、先頭と末尾へ選択ソートすれば線形時間で終わる。
        var tail0 = 0;
        var head2 = nums.Length - 1;
        int i = 0;
        while (i < head2 + 1) { 
            if (nums[i] == 0) {
                (nums[i], nums[tail0]) = (nums[tail0],nums[i]);
                tail0++;
                i = Math.Max(i, tail0);
            } else if (nums[i] == 2) {
                (nums[i], nums[head2]) = (nums[head2], nums[i]);
                head2--;
            } else {
                i++;
            }
        }
    }
}
