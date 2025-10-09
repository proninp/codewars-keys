# [String subpattern recognition I](https://www.codewars.com/kata/5a49f074b3bfa89b4c00002b)

In this kata you need to build a function to return either true/True or false/False if a string can be seen as the repetition of a simpler/shorter subpattern or not.

For example:

```csharp
HasSubpattern("a") == false; //no repeated pattern
HasSubpattern("aaaa") == true; //created repeating "a"
HasSubpattern("abcd") == false; //no repeated pattern
HasSubpattern("abababab") == true; //created repeating "ab"
HasSubpattern("ababababa") == false; //cannot be entirely reproduced repeating a pattern
```
Strings will never be empty and can be composed of any character (just consider upper- and lowercase letters as different entities) and can be pretty long (keep an eye on performances!).