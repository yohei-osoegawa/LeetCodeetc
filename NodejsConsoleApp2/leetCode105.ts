import { assert } from "console"

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

    const buildTreeSub = (preorder: number[], inorder: number[]): { tree: TreeNode | null, nextPre: number[] } => {
        // 根が存在しない場合はnullとする
        if (preorder.length === 0) {
            return { tree: null, nextPre: [] }
        }
        // SubTreeとして空配列が与えられている場合はpreorderを変化させずにただちにnullNodeを返す
        if (inorder.length === 0) {
            return { tree: null, nextPre: preorder };
        }

        const [nodeVal, ...nextLeftPreorder] = preorder;  // 分割代入を用いてhead::tail形式に分割する

        // 右SubTreeと左SubTreeを表す配列へとinorderを分割する
        // ※なお、これはhead,tailが空配列だった場合も正しく機能するが、numが見つからない場合は例外を発生させるはず
        const splitArrayAt = (array: number[], num: number): { head: number[], tail: number[] } => {
            const mid = array.indexOf(num);
            return { head: array.slice(0, mid), tail: array.slice(mid + 1, array.length) };
        }
        const { head, tail } = splitArrayAt(inorder, nodeVal);

        // 右SubTreeと左SubTreeの生成は再帰的に任せる
        const { tree: leftSubTree, nextPre: nextRightPreorder } = buildTreeSub(nextLeftPreorder, head);
        const { tree: rightSubTree, nextPre } = buildTreeSub(nextRightPreorder, tail);

        return { tree: new TreeNode(nodeVal, leftSubTree, rightSubTree), nextPre };
    }

    const { tree, ..._ } = buildTreeSub(preorder, inorder);
    return tree;
};

// デバグ用
const preorder = [3, 9, 20, 15, 7];
const inorder = [9, 3, 15, 20, 7];
buildTree(preorder, inorder);