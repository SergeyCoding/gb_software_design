package ru.geekbrains.lesson3.refueling;

import ru.geekbrains.lesson3.carparts.FuelType;

/**
 * Заправочная станция
 */
public interface Refueling {

    /**
     * Заправка
     */
    void fuel(FuelType fuelType);
}
