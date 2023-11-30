package ru.geekbrains.lesson3.homework;

import ru.geekbrains.lesson3.cars.FuelType;
import ru.geekbrains.lesson3.refueling.Refueling;
import ru.geekbrains.lesson3.refueling.Wiping;

/**
 *сервисная станция
 */
public  class ServiceStation implements Refueling, Wiping {
    @Override
    public void fuel(FuelType fuelType) {

    }

    @Override
    public void wipMirrors() {

    }

    @Override
    public void wipWindshield() {

    }

    @Override
    public void wipHeadlights() {

    }
}
