'use strict';

const input1 = ["c", "a", "b", "c", "b", "d"];
const input2 = ["a", "b", "a", "b", "c", "d"];
// const expect = ["a", "b", "c"];

const findDuplicateSubString = (input1, input2) => {

    // グルーピング
    const groupedId1 = input1.reduce(
        (acc, str, i) => {
            if (!acc[str]) {
                acc[str] = []
            }
            acc[str].push(i)
            return acc;
        },
        {}
    );

    // input2と共通しているstrがあったら、idをペアにしてSet化
    const idPairSet = input2.reduce(
        (set, str2, i2) => {
            if (groupedId1[str2]) {
                groupedId1[str2].forEach(i1 => set.add(JSON.stringify([i1, i2]))); // オブジェクトをset代わりに使ったらJsonstringfyは要らんかも、正直これがつらい
            }
            return set;
        },
        new Set()
    );

    // 重複した文字のインデックス情報を使って、最長の重複したSubstringを生成
    const strs = [...idPairSet].reduce(
        (array, strIdPair) => {
            const idPair = JSON.parse(strIdPair);
            let [i1, i2] = idPair;
            // インデックス+1されたidは、文字的には直後の文字
            while (idPairSet.has(JSON.stringify([++i1, ++i2]))) {
                if (i1 - idPair[0] + 1 > array.length) {
                    return input1.slice(idPair[0], i1 + 1);
                }
            }
            return array;
        },
        []
    )

    return strs;
}

console.log(findDuplicateSubString(input1, input2));
