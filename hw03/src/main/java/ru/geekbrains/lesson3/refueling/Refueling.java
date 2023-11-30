package ru.geekbrains.lesson3.refueling;

import ru.geekbrains.lesson3.cars.FuelType;

/**
 * Заправочная станция
 */
public interface Refueling {

    /**
     * Заправка
     */
    void fuel(FuelType fuelType);
}
