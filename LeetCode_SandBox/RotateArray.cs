using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RotateArray {
    public void Rotate(int[] nums, int k) {
        // Hack: メモリ性能が悪い。タプルを用いたスワップのせい？
        var length = nums.Length;
        var tmp = nums[0];
        int j = k % length;
        var sheed = 0;
        for (int i = 0; i < length ; i++) {
            if (j == sheed) {
                (nums[j], tmp) = (tmp, nums[j]);
                sheed = (sheed + 1) % length;
                j = (sheed + k) % length;
                tmp = nums[sheed];
            }
            else{
                (nums[j], tmp) = (tmp, nums[j]);
                j = (j + k) % length;
            }
        }
    }
}
