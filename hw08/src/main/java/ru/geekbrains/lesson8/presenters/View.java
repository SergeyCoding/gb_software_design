package ru.geekbrains.lesson8.presenters;

import ru.geekbrains.lesson8.models.Reservation;
import ru.geekbrains.lesson8.models.Table;

import java.util.Collection;

public interface View {

    void showTables(Collection<Table> tables);

    void showReservationTableResult(int reservationNo, String message);

    void registerObserver(ViewObserver observer);

    void showReservations();

    void showAllReservations(Collection<Reservation> reservations);
}
