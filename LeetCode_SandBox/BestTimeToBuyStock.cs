using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BestTimeToBuyStock {
    public int MaxProfit(int[] prices) {
        return prices.Aggregate(
            (result: new List<int>(), before: null as int?),
            (acc, x) => {
                if (acc.before is not int num) {
                    return (acc.result, x);
                } else {
                    acc.result.Add(x - num);
                    return (acc.result, x);
                }
            },
            x => x.result // 差分リストの生成
        ).Where(x => x > 0)
            .Cast<int?>()
            .Sum() ?? 0;
    }
}

