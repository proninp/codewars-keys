using System;

namespace Kata._6_kyu.String_subpattern_recognition_I.src;

public sealed class StringSubpatternRecognitionI
{
    public static bool HasSubpattern(string str) => 
        (str + str).IndexOf(str, 1, StringComparison.Ordinal) != str.Length;
    
}