using System;

namespace Kata._6_kyu.Fun_With_Trees_max_sum.src;
public class FunWithRreesMaxSum
{
    public static int MaxSum(TreeNode root)
    {
        if (root is null)
            return 0;
        if (root.left is not null && root.right is not null)
            return root._value + Math.Max(MaxSum(root.left), MaxSum(root.right));
        else
            return root._value +
                (root.left is not null ? MaxSum(root.left) : 0) +
                (root.right is not null ? MaxSum(root.right) : 0);
    }
}

public class TreeNode
{
    public TreeNode? left;
    public TreeNode? right;
    public int _value;

    private TreeNode(int v) 
    {
        _value = v;
    }

    public static TreeNode Leaf(int value)
    {
        var node = new TreeNode(value);
        return node;
    }

    public TreeNode WithLeftLeaf(int value)
    {
        var left = new TreeNode(value);
        this.left = left;
        return this;
    }
    
    public TreeNode WithLeaves(int leftValue, int rightValue)
    {
        var left = new TreeNode(leftValue);

        var right = new TreeNode(rightValue);

        this.left = left;
        this.right = right;
        return this;
    }

    internal static TreeNode Join(int v, TreeNode left, TreeNode right)
    {
        var node = new TreeNode(v);

        node.left = left;
        node.right = right;

        return node;
    }
}
