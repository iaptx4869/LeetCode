/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} head
 * @param {number} n
 * @return {ListNode}
 */
var removeNthFromEnd = function(head, n) {
    var array = [];
    var nodeCur = head;
    while (nodeCur !== null) {
        array.push(nodeCur);
        nodeCur = nodeCur.next;
    }
    var len = array.length;
    var node = array[len - n];
    var nodePrev = n < len ? array[len - n - 1] : null;
    var nodeNext = n == 1 ? null : array[len - n + 1];
    if (nodePrev === null) return nodeNext;
    else {
        nodePrev.next = nodeNext;
        return head;
    }
};
