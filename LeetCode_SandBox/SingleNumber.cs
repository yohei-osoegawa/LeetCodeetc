using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ClsSingleNumber {
    public int SingleNumber(int[] nums) {
        // ビットXOR演算を用いると偶数個数のものが消去される。
        return nums.Aggregate((acc, x) => acc ^ x);
    }
}

