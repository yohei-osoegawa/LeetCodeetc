using System.Linq;

// https://leetcode.com/explore/interview/card/top-interview-questions-medium/110/sorting-and-searching/799/
public class ClsTopKFlucuent {
    public int[] TopKFrequent(int[] nums, int k) {
        return nums.ToLookup(x => x)
            .Select(x => (value: x.Key, count: x.Count()))
            .OrderByDescending(x => x.count)
            .Select(x=>x.value)
            .Take(k)
            .ToArray();
    }
}

