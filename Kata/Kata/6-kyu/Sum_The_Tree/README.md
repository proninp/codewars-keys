# [Sum The Tree](https://www.codewars.com/kata/5800580f8f7ddaea13000025)

Given a node object representing a binary tree:

```csharp
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
```

write a function that returns the sum of all values, including the root. Absence of a node will be indicated with a `null` value.

Examples:

```
10
| \
1  2
=> 13
```

```
1
| \
0  0
    \
     2
=> 3
```