package ru.geekbrains.lesson4.bustickets;


import ru.geekbrains.lesson4.contracts.Condition;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Date;


public class TicketProvider {

    private final Database database;
    private final PaymentProvider paymentProvider;

    public TicketProvider(Database database, PaymentProvider paymentProvider) throws Exception {
        Condition.Precondition(new boolean[]{database != null, paymentProvider != null});
        this.database = database;
        this.paymentProvider = paymentProvider;
        Condition.Invariant(new boolean[]{this.database != null, this.paymentProvider != null});
    }

    public Collection<Ticket> searchTicket(int clientId, Date date) throws Exception {
        Condition.Precondition(new boolean[]{clientId > 0, date != null});
        Condition.Invariant(new boolean[]{this.database != null, this.paymentProvider != null});

        Collection<Ticket> tickets = new ArrayList<>();
        for (Ticket ticket : database.getTickets()) {
            if (ticket.getCustomerId() == clientId && ticket.getDate().equals(date))
                tickets.add(ticket);
        }

        Condition.Invariant(new boolean[]{this.database != null, this.paymentProvider != null});
        Condition.Postcondition(new boolean[]{tickets != null});
        return tickets;
    }

    public boolean buyTicket(int clientId, String cardNo) throws Exception {
        Condition.Precondition(new boolean[]{clientId > 0, cardNo != null, cardNo.length() == 16});
        Condition.Invariant(new boolean[]{this.database != null, this.paymentProvider != null});

        int orderId = database.createTicketOrder(clientId);
        double amount = database.getTicketAmount();

        boolean result = paymentProvider.buyTicket(orderId, cardNo, amount);

        Condition.Invariant(new boolean[]{this.database != null, this.paymentProvider != null});
        Condition.Postcondition(new boolean[]{true});
        return result;

    }

    public boolean checkTicket(String qrcode) throws Exception {
        Condition.Precondition(new boolean[]{qrcode != null, qrcode.length() > 0});
        Condition.Invariant(new boolean[]{this.database != null, this.paymentProvider != null});

        for (Ticket ticket : database.getTickets()) {
            if (ticket.getQrcode().equals(qrcode)) {
                ticket.setEnable(false);
                // Save database ...
                Condition.Invariant(new boolean[]{this.database != null, this.paymentProvider != null});
                return true;
            }
        }

        Condition.Invariant(new boolean[]{this.database != null, this.paymentProvider != null});
        return false;
    }

}
