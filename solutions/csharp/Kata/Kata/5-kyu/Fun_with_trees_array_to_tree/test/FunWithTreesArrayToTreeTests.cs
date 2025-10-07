using Kata._5_kyu.Fun_with_trees_array_to_tree.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._5_kyu.Fun_with_trees_array_to_tree.test;

[TestFixture]
public class FunWithTreesArrayToTreeTests
{
    [Test]
    public void EmptyArray()
    {
        TreeNode expected = null;
        ClassicAssert.AreEqual(expected, FunWithTreesArrayToTree.ArrayToTree(new int[] { }));
    }

    [Test]
    public void ArrayWithSingleElement()
    {
        TreeNode expected = new TreeNode(17);
        ClassicAssert.AreEqual(expected, FunWithTreesArrayToTree.ArrayToTree(new int[] { 17 }));
    }

    [Test]
    public void ArrayWithMultipleElements()
    {
        TreeNode expected = new TreeNode(17, new TreeNode(0, new TreeNode(3), new TreeNode(15)), new TreeNode(-4));
        ClassicAssert.AreEqual(expected, FunWithTreesArrayToTree.ArrayToTree(new int[] { 17, 0, -4, 3, 15 }));
    }
}
