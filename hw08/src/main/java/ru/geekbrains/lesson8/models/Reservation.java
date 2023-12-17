package ru.geekbrains.lesson8.models;

import java.util.Date;

/**
 * Reservation
 */
public class Reservation {
    private static int counter = 1000;
    private final int id;
    private final Table table;
    private final Date date;
    private final String name;

    {
        id = ++counter;
    }

    public Reservation(Table table, Date date, String name) {
        this.table = table;
        this.date = date;
        this.name = name;
    }

    public Table getTable() {
        return table;
    }

    public int getId() {
        return id;
    }

    public Date getDate() {
        return date;
    }

    public String getName() {
        return name;
    }

}
