public class MergeTwoBinaryTrees {
    public static void main(String[] args) {
        TreeNode Tree1 = new TreeNode(1);
        Tree1.left = new TreeNode(3);
        Tree1.right = new TreeNode(2);
        Tree1.left.left = new TreeNode(5);

        TreeNode Tree2 = new TreeNode(2);
        Tree2.left = new TreeNode(1);
        Tree2.right = new TreeNode(3);
        Tree2.left.right = new TreeNode(4);
        Tree2.right.right = new TreeNode(7);

        TreeNode mergedTree = new Solution().mergeTrees(Tree1, Tree2);
        System.out.print(mergedTree);

    }
}

class TreeNode {
    int val;
    TreeNode left;
    TreeNode right;

    TreeNode(int x) {
        val = x;
    }
}