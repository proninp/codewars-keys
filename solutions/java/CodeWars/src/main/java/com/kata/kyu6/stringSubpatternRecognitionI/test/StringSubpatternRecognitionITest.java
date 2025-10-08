package com.kata.kyu6.stringSubpatternRecognitionI.test;

import com.kata.kyu6.stringSubpatternRecognitionI.main.StringSubpatternRecognitionI;
import org.junit.Test;

import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertTrue;

public class StringSubpatternRecognitionITest {
    @Test
    public void basicTests() {
        assertFalse(StringSubpatternRecognitionI.hasSubpattern("a"));
        assertTrue(StringSubpatternRecognitionI.hasSubpattern("aaaa"));
        assertFalse(StringSubpatternRecognitionI.hasSubpattern("abcd"));
        assertTrue(StringSubpatternRecognitionI.hasSubpattern("abababab"));
        assertFalse(StringSubpatternRecognitionI.hasSubpattern("ababababa"));
        assertTrue(StringSubpatternRecognitionI.hasSubpattern("123a123a123a"));
        assertFalse(StringSubpatternRecognitionI.hasSubpattern("123A123a123a"));
        assertTrue(StringSubpatternRecognitionI.hasSubpattern("abbaabbaabba"));
        assertFalse(StringSubpatternRecognitionI.hasSubpattern("abbabbabba"));
        assertFalse(StringSubpatternRecognitionI.hasSubpattern("abcdabcabcd"));
    }
}
