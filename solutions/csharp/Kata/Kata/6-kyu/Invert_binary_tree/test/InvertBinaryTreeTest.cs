using Kata._6_kyu.Invert_binary_tree.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._6_kyu.Invert_binary_tree.test;
public class InvertBinaryTreeTest
{
    [Test]
    public void TestFromExample()
    {
        TreeNode root1 = new TreeNode
        {
            Value = 4,
            Left = new TreeNode
            {
                Value = 2,
                Left = new TreeNode { Value = 1 },
                Right = new TreeNode { Value = 3 }
            },
            Right = new TreeNode
            {
                Value = 7,
                Left = new TreeNode { Value = 6 },
                Right = new TreeNode { Value = 9 }
            }
        };

        TreeNode root2 = new TreeNode
        {
            Value = 4,
            Left = new TreeNode
            {
                Value = 7,
                Left = new TreeNode { Value = 9 },
                Right = new TreeNode { Value = 6 }
            },
            Right = new TreeNode
            {
                Value = 2,
                Left = new TreeNode { Value = 3 },
                Right = new TreeNode { Value = 1 }
            }
        };

        CompareTrees(InvertBinaryTree.InvertTree(root1), root2);
    }

    private static void CompareTrees(TreeNode root1, TreeNode root2)
    {
        if (root1 == null && root2 == null)
            return;

        ClassicAssert.False(root1 == null && root2 != null);
        ClassicAssert.False(root1 != null && root2 == null);
        ClassicAssert.AreEqual(root1.Value, root2.Value);

        CompareTrees(root1.Left, root2.Left);
        CompareTrees(root1.Right, root2.Right);
    }
}

