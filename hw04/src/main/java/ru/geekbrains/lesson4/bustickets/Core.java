package ru.geekbrains.lesson4.bustickets;

public class Core {

    private final CustomerProvider customerProvider;

    private final TicketProvider ticketProvider;

    private final PaymentProvider paymentProvider;
    private final Database database;

    public Core() throws Exception {
        database = new Database();
        customerProvider = new CustomerProvider(database);
        paymentProvider = new PaymentProvider();
        ticketProvider = new TicketProvider(database, paymentProvider);
    }

    /**
     * Внешний сервис
     *
     * @return возвращает сервис по работе с билетами
     */
    public TicketProvider getTicketProvider() {
        return ticketProvider;
    }

    /**
     * Внешний сервис
     *
     * @return возвращает сервис по работе с покупателями
     */
    public CustomerProvider getCustomerProvider() {
        return customerProvider;
    }


}
