package ru.geekbrains.lesson8.models;

import ru.geekbrains.lesson8.presenters.Model;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Date;

/**
 * TableService
 */
public class TableService implements Model {

    private final Collection<Reservation> reservations = new ArrayList<>();
    private Collection<Table> tables;

    @Override
    public Collection<Table> loadTables() {
        if (tables == null) {
            tables = new ArrayList<>();

            tables.add(new Table());
            tables.add(new Table());
            tables.add(new Table());
            tables.add(new Table());
            tables.add(new Table());
        }

        return tables;
    }

    public Collection<Reservation> getReservations() {
        return reservations;
    }

    @Override
    public int reservationTable(Date reservationDate, int tableNo, String name) {

        for (Reservation r : reservations) {
            if (r.getTable().getNo() == tableNo && r.getDate().equals(reservationDate)) {
                throw new RuntimeException("Столик уже зарезервирован");
            }
        }

        for (Table table : tables) {
            if (table.getNo() == tableNo) {
                Reservation reservation = new Reservation(table, reservationDate, name);
                reservations.add(reservation);
                return reservation.getId();
            }
        }
        throw new RuntimeException("Некорректный номер столика");
    }

    @Override
    public int changeReservationTable(int oldReservation, Date reservationDate, int tableNo, String name) {
        for (Reservation r : reservations) {
            if (r.getId() == oldReservation) {
                reservations.remove(r);
                break;
            }
        }

        return reservationTable(reservationDate, tableNo, name);
    }
}