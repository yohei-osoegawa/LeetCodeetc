using System.Collections.Generic;
using System.Linq;

// https://leetcode.com/explore/interview/card/top-interview-questions-medium/110/sorting-and-searching/799/
public class ClsTopKFlucuent {
    public int[] TopKFrequent(int[] nums, int k) {
        // Hack: GroupBy使ったほうがいい。
        return nums.ToLookup(x => x)
            .Select(x => (value: x.Key, count: x.Count()))
            .OrderByDescending(x => x.count)  
            .Select(x => x.value)
            .Take(k)
            .ToArray();
    }

    public int[] TopKFrequent2(int[] nums, int k) {
        // countupDictionaryを用いる
        var dic = new Dictionary<int, int>();
        foreach (var num in nums) {
            if (!dic.TryAdd(num,1)) {
                dic[num]++;
            }
        }
        // Hack:.Net6.0以降なら優先度付きキューが使える。そっち使ったほうが性能がいいはず。
        // https://leetcode.com/problems/top-k-frequent-elements/solutions/646157/official-solution/ 
        return dic.OrderByDescending(x => x.Value) 
            .Select(x => x.Key)
            .Take(k)
            .ToArray();
    }
}

