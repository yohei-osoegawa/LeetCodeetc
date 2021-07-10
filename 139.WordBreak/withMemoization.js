
/**
 * @param {string} s
 * @param {string[]} wordDict
 * @return {boolean}
 */
const wordBreak = (s, wordDict) => {
    // 準備：wordDictをハッシュテーブル化
    const set = new Set(wordDict)

    // メモ化再帰で実行
    let canSegument = new Map();

    const wordBreak = (headI, tailI) => {
        const key = String(headI) + "," + String(tailI);
        const memoize = (result) => {
            canSegument.set(key, result);
            return result;
        }

        if (canSegument.has(key)) {
            return canSegument.get(key);
        }
        if (headI === s.length) {
            return memoize(true);
        }
        if (headI > tailI) {
            return memoize(true);
        }
        if (tailI === s.length) {
            return memoize(true);
        }
        if (set.has(s.substring(headI, tailI + 1))) {
            return memoize(true);
        }
        const width = tailI - headI
        const result = [...new Array(width).keys()]
            .some(i => wordBreak(headI, headI + i) && wordBreak(headI + i + 1, tailI))
        return memoize(result);
    };

    return wordBreak(0, s.length - 1);
}