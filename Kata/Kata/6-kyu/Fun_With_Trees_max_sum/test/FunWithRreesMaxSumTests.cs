using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kata._6_kyu.Fun_With_Trees_max_sum.src;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Kata._6_kyu.Fun_With_Trees_max_sum.test;
public class FunWithRreesMaxSumTests
{
    /**
     * null
     */
    [Test]
    public void MaxSumInNullTree()
    {
        TreeNode root = null;
        ClassicAssert.AreEqual(0, FunWithRreesMaxSum.MaxSum(root));
    }

    /**
     * 17
     */
    [Test]
    public void MaxSumInLeaf()
    {
        TreeNode root = TreeNode.Leaf(17);
        ClassicAssert.AreEqual(17, FunWithRreesMaxSum.MaxSum(root));
    }

    /**
     *   1
     *  /
     * 2
     */
    [Test]
    public void MaxSumInOneChildTree()
    {
        TreeNode root = TreeNode.Leaf(1).WithLeftLeaf(2);
        ClassicAssert.AreEqual(3, FunWithRreesMaxSum.MaxSum(root));
    }

    /**
     *      5
     *    /   \
     *  -22    11
     *  / \    / \
     * 9  50  9   2
     */
    [Test]
    public void MaxSumInPerfectTree()
    {
        TreeNode left = TreeNode.Leaf(-22).WithLeaves(9, 50);
        TreeNode right = TreeNode.Leaf(11).WithLeaves(9, 2);
        TreeNode root = TreeNode.Join(5, left, right);
        ClassicAssert.AreEqual(33, FunWithRreesMaxSum.MaxSum(root));
    }

    /**
     *         5
     *       /   \
     *    4        10
     *   /  \     /
     * -80  -60 -90 
     */
    [Test]
    public void ShouldStopOnlyAtLeaves()
    {
        TreeNode left = TreeNode.Leaf(4).WithLeaves(-80, -60);
        TreeNode right = TreeNode.Leaf(10).WithLeftLeaf(-90);
        TreeNode root = TreeNode.Join(5, left, right);
        ClassicAssert.AreEqual(-51, FunWithRreesMaxSum.MaxSum(root));
    }

    /**
     *      6
     *     /  \
     *    50   40
     *   /  \
     * -100  -10
     */
    [Test]
    public void MaxSumInUnbalancedTree()
    {
        TreeNode left = TreeNode.Leaf(50).WithLeaves(-100, -10);
        TreeNode right = TreeNode.Leaf(40);
        TreeNode root = TreeNode.Join(6, left, right);
        ClassicAssert.AreEqual(46, FunWithRreesMaxSum.MaxSum(root));
    }
}
