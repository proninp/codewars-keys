package com.kata.kyu7.youCantCodeUnderPressure2.main;

public class YouCantCodeUnderPressure2 {
    private int counter;

    public YouCantCodeUnderPressure2() {
        this(0);
    }

    public YouCantCodeUnderPressure2(int counter) {
        this.counter = counter;
    }

    public int check() {
        return counter;
    }

    public void increment() {
        counter++;
    }
}
