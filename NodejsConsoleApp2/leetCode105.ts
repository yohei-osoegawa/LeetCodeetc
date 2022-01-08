class TreeNode {
    val: number
    left: TreeNode | null
    right: TreeNode | null
    constructor(val?: number, left?: TreeNode | null, right?: TreeNode | null) {
        this.val = (val === undefined ? 0 : val)
        this.left = (left === undefined ? null : left)
        this.right = (right === undefined ? null : right)
    }
}

function buildTree(preorder: number[], inorder: number[]): TreeNode | null {

    // 根が存在しない場合はnullとする
    if (preorder.length === 0) {
        return null
    }

    // 分割代入を用いてhead::tail形式に分割する
    const [nodeVal, ...nextPreorder] = preorder;  

    // 右SubTreeと左SubTreeを表す配列へとinorderを分割する
    // ※なお、これはhead,tailが空配列だった場合も正しく機能するが、numが見つからない場合は例外を発生させるはず
    const splitArrayAt = (array: number[], num: number): { head: number[], tail: number[] } => {
        const mid = array.indexOf(num);
        return { head: array.slice(0, mid), tail: array.slice(mid + 1, array.length) };
    }
    const { head: nextLeftInorder, tail: nextRightInorder } = splitArrayAt(inorder, nodeVal);

    // 右SubTreeと左SubTreeの要素数を用いてPreorderも分割する
    const nextLeftPreorder = nextPreorder.slice(0, nextLeftInorder.length);
    const nextRightPreorder = nextPreorder.slice(nextLeftInorder.length);

    // 右SubTreeと左SubTreeの生成は再帰的に任せる
    return new TreeNode(nodeVal, buildTree(nextLeftPreorder, nextLeftInorder), buildTree(nextRightPreorder, nextRightInorder));
};

// デバグ用
const preorder = [3, 9, 20, 15, 7];
const inorder = [9, 3, 15, 20, 7];
buildTree(preorder, inorder);