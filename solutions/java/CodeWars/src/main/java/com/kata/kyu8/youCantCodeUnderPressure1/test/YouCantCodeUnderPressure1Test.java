package com.kata.kyu8.youCantCodeUnderPressure1.test;

import com.kata.kyu8.youCantCodeUnderPressure1.main.YouCantCodeUnderPressure1;
import org.junit.Assert;
import org.junit.Test;

public class YouCantCodeUnderPressure1Test {
    @Test
    public final void test_two() {
        Assert.assertEquals(
                "Nope!" ,
                4,
                YouCantCodeUnderPressure1.doubleInteger(2));
    }

    @Test
    public final void test_eight() {
        Assert.assertEquals(
                "Nope!" ,
                16,
                YouCantCodeUnderPressure1.doubleInteger(8));
    }
}