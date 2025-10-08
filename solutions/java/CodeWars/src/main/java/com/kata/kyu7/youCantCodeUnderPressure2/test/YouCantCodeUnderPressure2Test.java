package com.kata.kyu7.youCantCodeUnderPressure2.test;

import com.kata.kyu7.youCantCodeUnderPressure2.main.YouCantCodeUnderPressure2;
import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class YouCantCodeUnderPressure2Test {
    @Test
    public void simpleTest() {
        YouCantCodeUnderPressure2 myCounter = new YouCantCodeUnderPressure2();
        myCounter.increment();
        myCounter.increment();
        assertEquals(2, myCounter.check());
    }

    @Test
    public void shouldAllowConcurrentCounters() {
        final YouCantCodeUnderPressure2 a = new YouCantCodeUnderPressure2(), b = new YouCantCodeUnderPressure2();
        a.increment();
        a.increment();
        assertEquals(2, a.check());
        assertEquals(0, b.check());
        b.increment();
        assertEquals(2, a.check());
        assertEquals(1, b.check());
    }
}
