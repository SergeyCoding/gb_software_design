package ru.geekbrains.lesson8.views;

import ru.geekbrains.lesson8.models.Reservation;
import ru.geekbrains.lesson8.models.Table;
import ru.geekbrains.lesson8.presenters.View;
import ru.geekbrains.lesson8.presenters.ViewObserver;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Date;

public class BookingView implements View {

    private final Collection<ViewObserver> observers = new ArrayList<>();

    @Override
    public void registerObserver(ViewObserver observer) {
        observers.add(observer);
    }


    public void showTables(Collection<Table> tables) {
        for (Table table : tables) {
            System.out.println(table);
        }
    }

    @Override
    public void showReservationTableResult(int reservationNo, String message) {
        if (reservationNo > 0)
            System.out.printf("Столик успешно забронирован. Номер вашей брони: #%d\n", reservationNo);
        else
            System.out.println("Не удалось забронировать столик. " + message);

    }

    public void changeReservationTable(int oldReservation, Date reservationDate, int tableNo, String name) {
        for (ViewObserver observer : observers) {
            observer.onChangeReservationTable(oldReservation, reservationDate, tableNo, name);
        }
    }


    public void reservationTable(Date orderDate, int tableNo, String name) {
        for (ViewObserver observer : observers) {
            observer.onReservationTable(orderDate, tableNo, name);
        }
    }

    @Override
    public void showReservations() {
        for (ViewObserver observer : observers) {
            observer.onShowReservations();
        }
    }

    @Override
    public void showAllReservations(Collection<Reservation> reservations) {
        System.out.println("\nСписок брони:");

        for (Reservation r : reservations) {
            System.out.printf("Номер брони: #%d. Столик #%d. Клиент: %s, Дата: %tF\n", r.getId(), r.getTable().getNo(), r.getName(), r.getDate());
        }
    }
}
