"use strict";
class TreeNode {
    constructor(val, left, right) {
        this.val = (val === undefined ? 0 : val);
        this.left = (left === undefined ? null : left);
        this.right = (right === undefined ? null : right);
    }
}
function buildTree(preorder, inorder) {
    // �������݂��Ȃ��ꍇ��null�Ƃ���
    if (preorder.length === 0) {
        return null;
    }
    // ���������p����head::tail�`���ɕ�������
    const [nodeVal, ...nextPreorder] = preorder;
    // �ESubTree�ƍ�SubTree��\���z��ւ�inorder�𕪊�����
    // ���Ȃ��A�����head,tail����z�񂾂����ꍇ���������@�\���邪�Anum��������Ȃ��ꍇ�͗�O�𔭐�������͂�
    const splitArrayAt = (array, num) => {
        const mid = array.indexOf(num);
        return { head: array.slice(0, mid), tail: array.slice(mid + 1, array.length) };
    };
    const { head: nextLeftInorder, tail: nextRightInorder } = splitArrayAt(inorder, nodeVal);
    // �ESubTree�ƍ�SubTree�̗v�f����p����Preorder����������
    const nextLeftPreorder = nextPreorder.slice(0, nextLeftInorder.length);
    const nextRightPreorder = nextPreorder.slice(nextLeftInorder.length);
    // �ESubTree�ƍ�SubTree�̐����͍ċA�I�ɔC����
    return new TreeNode(nodeVal, buildTree(nextLeftPreorder, nextLeftInorder), buildTree(nextRightPreorder, nextRightInorder));
}
;
// �f�o�O�p
const preorder = [3, 9, 20, 15, 7];
const inorder = [9, 3, 15, 20, 7];
buildTree(preorder, inorder);
//# sourceMappingURL=leetCode105.js.map