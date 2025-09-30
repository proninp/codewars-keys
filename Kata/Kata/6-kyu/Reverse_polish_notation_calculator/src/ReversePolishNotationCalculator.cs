using System;
using System.Collections.Generic;

namespace Kata._6_kyu.Reverse_polish_notation_calculator.src;

public class ReversePolishNotationCalculator
{
    public double evaluate(string expr)
    {
        var stack = new Stack<double>();
        stack.Push(0);
        var ops = new Dictionary<char, Func<double, double, double>>();
        ops['+'] = (b, a) => a + b;
        ops['-'] = (b, a) => a - b;
        ops['*'] = (b, a) => a * b;
        ops['/'] = (b, a) => a / b;
        
        var parts = expr.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (var part in parts)
        {
            if (ops.ContainsKey(part[0]))
            {
                stack.Push(ops[part[0]](stack.Pop(), stack.Pop()));
            }
            else
            {
                stack.Push(double.Parse(part));
            }
        }
        return stack.Pop();
    }
}