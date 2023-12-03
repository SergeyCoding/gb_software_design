package ru.geekbrains.lesson4.bustickets;


import java.util.ArrayList;
import java.util.Collection;

public class Customer {

    private static int counter = 100;
    private int id;
    private Collection<Ticket> tickets = new ArrayList<>();
    public Customer() {
        id = ++counter;
    }

    public Collection<Ticket> getTickets() {
        return tickets;
    }

    public void setTickets(Collection<Ticket> tickets) {
        this.tickets = tickets;
    }

    public int getId() {
        return id;
    }

}
