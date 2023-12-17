package ru.geekbrains.lesson8;

import ru.geekbrains.lesson8.models.TableService;
import ru.geekbrains.lesson8.presenters.BookingPresenter;
import ru.geekbrains.lesson8.presenters.Model;
import ru.geekbrains.lesson8.views.BookingView;

import java.util.Calendar;
import java.util.Date;

public class Program {

    /**
     * TODO: Домашнее задание - метод changeReservationTable заработал!
     */
    public static void main(String[] args) {

        Model tableService = new TableService();
        BookingView bookingView = new BookingView();
        BookingPresenter bookingPresenter = new BookingPresenter(tableService, bookingView);
        bookingPresenter.updateUILoadTables();

        bookingView.reservationTable(clearDateFromTime(new Date()), 3, "Станислав");
        bookingView.reservationTable(clearDateFromTime(new Date()), 2, "Алиса");
        bookingView.reservationTable(clearDateFromTime(new Date()), 3, "Боб");

        bookingView.showReservations();
        
        bookingView.changeReservationTable(1001, addDays(new Date(), 1), 1, "Станислав");

        bookingView.showReservations();
    }

    private static Date clearDateFromTime(Date date) {
        long millisInDay = 60 * 60 * 24 * 1000;
        long currentTime = new Date().getTime();
        long dateOnly = (currentTime / millisInDay) * millisInDay;
        return new Date(dateOnly);
    }

    public static Date addDays(Date date, int days) {
        Calendar cal = Calendar.getInstance();
        cal.setTime(date);
        cal.add(Calendar.DATE, days); //minus number would decrement the days
        return cal.getTime();
    }

}