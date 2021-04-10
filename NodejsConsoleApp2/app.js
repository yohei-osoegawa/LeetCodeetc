"use strict";
var __rest = (this && this.__rest) || function (s, e) {
    var t = {};
    for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p) && e.indexOf(p) < 0)
        t[p] = s[p];
    if (s != null && typeof Object.getOwnPropertySymbols === "function")
        for (var i = 0, p = Object.getOwnPropertySymbols(s); i < p.length; i++) {
            if (e.indexOf(p[i]) < 0 && Object.prototype.propertyIsEnumerable.call(s, p[i]))
                t[p[i]] = s[p[i]];
        }
    return t;
};
class TreeNode {
    constructor(val, left, right) {
        this.val = (val === undefined ? 0 : val);
        this.left = (left === undefined ? null : left);
        this.right = (right === undefined ? null : right);
    }
}
const preorder = [3, 9, 20, 15, 7];
const inorder = [9, 3, 15, 20, 7];
function buildTree(preorder, inorder) {
    const buildTreeSub = (preorder, inorder) => {
        // �������݂��Ȃ��ꍇ��null�Ƃ���
        if (preorder.length === 0) {
            return { tree: null, nextPre: [] };
        }
        const [nodeVal, ...nextLeftPreorder] = preorder; // �c�]�\����p����head::tail�`���ɕ�������
        // �ESubTree�ƍ�SubTree��\���z��ւ�inorder�𕪊�����
        // ���Ȃ��A�����head,tail����z�񂾂����ꍇ���������@�\���邪�Anum��������Ȃ��ꍇ�͗�O�𔭐�������
        const splitArrayAt = (array, num) => {
            const mid = array.indexOf(num);
            return { head: array.slice(0, mid), tail: array.slice(mid + 1, array.length) };
        };
        const { head, tail } = splitArrayAt(inorder, nodeVal);
        // �ESubTree�ƍ�SubTree�̐����͍ċA�I�ɔC����
        const { tree: leftSubTree, nextPre: nextRightPreorder } = buildTreeSub(nextLeftPreorder, head);
        const { tree: rightSubTree, nextPre } = buildTreeSub(nextRightPreorder, tail);
        return { tree: new TreeNode(nodeVal, leftSubTree, rightSubTree), nextPre };
    };
    const _a = buildTreeSub(preorder, inorder), { tree } = _a, _ = __rest(_a, ["tree"]);
    return tree;
}
;
buildTree(preorder, inorder);
//# sourceMappingURL=app.js.map