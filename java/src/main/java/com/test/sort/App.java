package com.test.sort;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main(String[] args)
    {
        System.out.println("Hello World!");
    }
}

public class SomeSort implements SortAlgorithm {
    @Override
    public <T extends Comparable<T>> T[] sort(T[] array) {
    }

    public static void main(String[] args) {
        SomeSort pancakeSort = new SomeSort(); // comment
        pancakeSort.sort(arr);
    }
}

