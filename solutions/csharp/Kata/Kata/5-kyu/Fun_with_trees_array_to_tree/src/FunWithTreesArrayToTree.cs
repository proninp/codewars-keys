using System.Collections.Generic;

namespace Kata._5_kyu.Fun_with_trees_array_to_tree.src;
public class FunWithTreesArrayToTree
{
    public static TreeNode ArrayToTree(int[] array)
    {
        if (array is null || array.Length == 0)
            return null;

        var root = new TreeNode(array[0]);
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var i = 1;
        while (i < array.Length)
        {
            var node = queue.Dequeue();
            if (i < array.Length)
            {
                node.left = new TreeNode(array[i++]);
                queue.Enqueue(node.left);
            }
            if (i < array.Length)
            {
                node.right = new TreeNode(array[i++]);
                queue.Enqueue(node.right);
            }
        }
        return root;
    }
}


public class TreeNode
{

    public TreeNode left;
    public TreeNode right;
    public int value;

    public TreeNode(int value, TreeNode left, TreeNode right)
    {
        this.value = value;
        this.left = left;
        this.right = right;
    }

    public TreeNode(int value)
    {
        this.value = value;
    }

    public override bool Equals(object? obj)
    {
        return obj is TreeNode node &&
               EqualityComparer<TreeNode>.Default.Equals(left, node.left) &&
               EqualityComparer<TreeNode>.Default.Equals(right, node.right) &&
               value == node.value;
    }
}