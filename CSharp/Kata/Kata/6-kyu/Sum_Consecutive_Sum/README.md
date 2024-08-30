# [Sum Consecutive Sum](https://www.codewars.com/kata/66a54f48a70874c7c43ab247)

Given an unordered array of non-negative long integers (including zero) with up to 50 digits,
calculate the sum of the digits of the sum of all consecutive numbers, where there are at least two consecutive numbers when the array is ordered.
Duplicate numbers should be considered only once.

## Example

Consider the array:
```
[3, 1, 100, 120, 101, 99, 2]
```

In its ordered form without duplicates, the array would be:
```
[1, 2, 3, 99, 100, 101, 120]
```

The consecutive numbers in this case are:
```
[1, 2, 3] and [99, 100, 101]
```

Therefore, the sum of the consecutive numbers is:
```
1 + 2 + 3 + 99 + 100 + 101 = 306
```

And the sum of the digits of 306 is:
```
3 + 0 + 6 = 9
```

Consider another array:
```
[3, 1000, 1005, 1000, 9999999, 1000, 1000, 6, 7, 1003, 1004, 4, 5, 1002, 8, 9, 1001, 1004]
```

The consecutive numbers in this case are:
```
[3, 4, 5, 6, 7, 8, 9] and [1000, 1001, 1002, 1003, 1004, 1005]
```

Therefore, the sum of the consecutive numbers is:
```
3 + 4 + 5 + 6 + 7 + 8 + 9 + 1000 + 1001 + 1002 + 1003 + 1004 + 1005 = 6057
```

And the sum of the digits of 6057 is:
```
6 + 0 + 5 + 7 = 18
```

## Requirements
* The function must return an integer which is the sum of the digits of the resulting sum.
* Duplicate numbers are counted only once.
* The array can contain up to `10^5` elements.
* You must efficiently handle edge cases and large inputs.