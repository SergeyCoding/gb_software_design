package ru.geekbrains.lesson4.bustickets;

/**
 * Автобусная станция (отдельный комплекс)
 */
public class BusStation {

    private final TicketProvider ticketProvider;

    public BusStation(TicketProvider ticketProvider) {
        this.ticketProvider = ticketProvider;
    }

    public boolean checkTicket(String qrCode) throws Exception {
        return ticketProvider.checkTicket(qrCode);
    }

}
