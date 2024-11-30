# [Fun with trees: array to tree](https://www.codewars.com/kata/57e5a6a67fbcc9ba900021cd)

You are given an array of integers.
Implement a function which creates a complete binary tree from the array (complete meaning that every level of the tree, except possibly the last, is completely filled).
The elements of the array are to be taken left-to-right, and put into the tree top-to-bottom, left-to-right.
For example, given the array `[17, 0, -4, 3, 15]` you should create the following tree:

```
    17
   /  \
  0   -4
 / \
3   15 
```

A tree node type is preloaded for you:

```
class TreeNode {

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
    
    public override bool Equals(Object other)
    {
        ... // Already implemented for you and used in test cases 
    }
    ...
}
```