using System;

namespace Kata._5_kyu.Fun_with_trees_is_perfect.src;
public class TreeNode
{
    public TreeNode left;
    public TreeNode right;

    public static bool IsPerfect(TreeNode root)
    {
        int depth = Depth(root);
        return IsPerfect(root, depth);
    }

    private static bool IsPerfect(TreeNode root, int d)
    {
        if (root is null)
            return true;

        if (root.left is null && root.right is null)
            return d == 1;

        if (root.left is null || root.right is null)
            return false;

        return IsPerfect(root.left, d - 1) && IsPerfect(root.right, d - 1);
    }

    public static int Depth(TreeNode node)
    {
        if (node is null) return 0;
        return Math.Max(Depth(node.left), Depth(node.right)) + 1;
    }

    public static TreeNode Leaf()
    {
        return new TreeNode();
    }

    public static TreeNode Join(TreeNode left, TreeNode right)
    {
        return new TreeNode().WithChildren(left, right);
    }

    public TreeNode WithLeft(TreeNode left)
    {
        this.left = left;
        return this;
    }

    public TreeNode WithRight(TreeNode right)
    {
        this.right = right;
        return this;
    }

    public TreeNode WithChildren(TreeNode left, TreeNode right)
    {
        this.left = left;
        this.right = right;
        return this;
    }

    public TreeNode WithLeftLeaf()
    {
        return WithLeft(Leaf());
    }

    public TreeNode WithRightLeaf()
    {
        return WithRight(Leaf());
    }

    public TreeNode WithLeaves()
    {
        return WithChildren(Leaf(), Leaf());
    }
}
