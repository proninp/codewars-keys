package com.kata.kyu6.stringSubpatternRecognitionI.main;

public class StringSubpatternRecognitionI {
    public static boolean hasSubpattern(String str) {
        var duplicated = (str + str);
        duplicated = duplicated.substring(1, duplicated.length() - 1);
        return duplicated.contains(str);

    }
}
