# [The PaperFold sequence](https://www.codewars.com/kata/5d26721d48430e0016914faa/train/csharp)

[Wikipedia](https://en.wikipedia.org/wiki/Regular_paperfolding_sequence): The **regular paperfolding sequence**, also known as the **dragon curve sequence**,
is an infinite automatic sequence of `0`s and `1`s defined as the **limit** of inserting
an alternating sequence of `1`s and `0`s around and between the terms of the previous sequence:

<span style="color:red">1</span>

<span style="color:blue">1</span> <span style="color:red">1</span> <span style="color:blue">0</span>

1 <span style="color:blue">1</span> 0 <span style="color:red">1</span> 1 <span style="color:blue">0</span> 0

<span style="color:purple">1</span> 1 <span style="color:purple">0</span> <span style="color:blue">1</span> <span style="color:purple">1</span> 0 <span style="color:purple">0</span> <span style="color:red">1</span> <span style="color:purple">1</span> 1 <span style="color:purple">0</span> <span style="color:blue">0</span> <span style="color:purple">1</span> 0 <span style="color:purple">0</span>

...

Note how each intermediate sequence is a prefix of the next.

Define a generator `PaperFold` that sequentially generates the values of this sequence:

<span style="color:green">1</span> <span style="color:purple">1</span> <span style="color:green">0</span> 1 <span style="color:green">1</span> <span style="color:purple">0</span> <span style="color:green">0</span> <span style="color:blue">1</span> <span style="color:green">1</span> <span style="color:purple">1</span> <span style="color:green">0</span> 0 <span style="color:green">1</span> <span style="color:purple">0</span> <span style="color:green">0</span> <span style="color:red">1</span> <span style="color:green">1</span> <span style="color:purple">1</span> <span style="color:green">0</span> 1 <span style="color:green">1</span> <span style="color:purple">0</span> <span style="color:green">0</span> <span style="color:blue">0</span> <span style="color:green">1</span> <span style="color:purple">1</span> <span style="color:green">0</span> 0 <span style="color:green">1</span> <span style="color:purple">0</span> <span style="color:green">0</span> ...

It will be tested for up to `1 000 000` values.