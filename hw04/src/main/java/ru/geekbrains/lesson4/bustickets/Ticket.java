package ru.geekbrains.lesson4.bustickets;


import java.util.Date;

public class Ticket {

    static int counter = 4000;
    private int id;
    private int customerId;
    private Date date;
    private String qrcode;
    private boolean enable = true;

    public Ticket() {
        id = ++counter;
    }

    public int getId() {
        return id;
    }

    public boolean isEnable() {
        return enable;
    }

    public void setEnable(boolean enable) {
        this.enable = enable;
    }

    public String getQrcode() {
        return qrcode;
    }

    public int getCustomerId() {
        return customerId;
    }

    public Date getDate() {
        return date;
    }
}
