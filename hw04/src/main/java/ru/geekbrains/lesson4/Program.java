package ru.geekbrains.lesson4;


import ru.geekbrains.lesson4.bustickets.BusStation;
import ru.geekbrains.lesson4.bustickets.Core;
import ru.geekbrains.lesson4.bustickets.MobileApp;
import ru.geekbrains.lesson4.bustickets.Ticket;

import java.util.Collection;
import java.util.Date;

public class Program {

    /**
     * Разработать контракты и компоненты системы "Покупка онлайн билетов на автобус в час пик".
     */
    public static void main(String[] args) throws Exception {

        System.out.println("Task 04");

        Core core = new Core();

        MobileApp mobileApp = new MobileApp(core.getTicketProvider(), core.getCustomerProvider());

        BusStation busStation = new BusStation(core.getTicketProvider());


        mobileApp.buyTicket("1000000000001");
        mobileApp.searchTicket(new Date());
        Collection<Ticket> tickets = mobileApp.getTickets();

        //busStation.checkTicket("AAA");
    }
}
