package ru.geekbrains.lesson8.models;

import java.util.Locale;

/**
 * Table
 */
public class Table {

    private static int counter;
    private final int no;

    {
        no = ++counter;
    }

    public int getNo() {
        return no;
    }

    @Override
    public String toString() {
        return String.format(Locale.getDefault(), "Столик #%d", no);
    }

}
