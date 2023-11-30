package ru.geekbrains.lesson3.refueling;

import ru.geekbrains.lesson3.carparts.FuelType;
import ru.geekbrains.lesson3.cars.Car;

/**
 * Заправочная станция
 */
public interface Refueling {

    /**
     * Заправка
     */
    void fuel(Car car);
}
