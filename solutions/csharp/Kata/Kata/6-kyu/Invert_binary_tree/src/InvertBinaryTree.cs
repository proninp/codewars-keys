namespace Kata._6_kyu.Invert_binary_tree.src;
public class InvertBinaryTree
{
    public static TreeNode InvertTree(TreeNode root)
    {
        if (root is null)
            return root;
        InvertTree(root.Left);
        InvertTree(root.Right);
        (root.Left, root.Right) = (root.Right, root.Left);
        return root;
    }
}

public class TreeNode
{
    public int Value { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }
}