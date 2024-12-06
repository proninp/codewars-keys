using Kata._5_kyu.Fun_with_trees_is_perfect.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._5_kyu.Fun_with_trees_is_perfect.test;

[TestFixture]
public class TreeNodeTest
{
    /**
     * null
     */
    [Test]
    public void NullTreeShouldBePerfect()
    {
        TreeNode root = null;
        ClassicAssert.AreEqual(true, TreeNode.IsPerfect(root), "null tree should be perfect");
    }

    /**
     *   0
     *  / \
     * 0   0
     */
    [Test]
    public void FullOneLevelTreeShouldBePerfect()
    {
        TreeNode root = TreeNode.Leaf().WithLeaves();
        ClassicAssert.AreEqual(true, TreeNode.IsPerfect(root), "root with two leaves should be perfect");
    }

    /**
     *   0
     *  /
     * 0
     */
    [Test]
    public void OneChildTreeShouldNotBePerfect()
    {
        TreeNode root = TreeNode.Leaf().WithLeftLeaf();
        ClassicAssert.AreEqual(false, TreeNode.IsPerfect(root), "root with single leaf should not be perfect");
    }
}