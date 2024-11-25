namespace Kata._6_kyu.Sum_The_Tree.src;

public class SumTheTree
{
    public static int SumTree(Node root)
    {
        return (root is null) ? 0 :
            root.Value + SumTree(root.Left) + SumTree(root.Right);
    }
}


public class Node
{
    public int Value;
    public Node Left;
    public Node Right;

    public Node(int value, Node left = null, Node right = null)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}