# [Guess the array](https://www.codewars.com/kata/59392ff00203d9686a0000c6)

In this kata, you should determine the values in an unknown array of numbers. You'll be given a function `f`,
which you can call like this: `f(a, b)` where `a` and `b` are indexes of two different elements in the unknown array,
1 or 2 indexes apart. `f` will return the sum of those two elements.

The absolute difference between a and b must not be 0 nor greater than 2 (that is: the chosen indexes must be exactly 1 or 2 apart).

Your goal is to figure out the correct array.

The whole procedure is:

1. You are given `f` and the length of the array `n`.
2. Ask `f` for any element sums you want.
3. Create and return the correct array according to the answers.

The array will always have at least 3 elements.