package ru.geekbrains.lesson3.homework;

import ru.geekbrains.lesson3.carparts.FuelType;
import ru.geekbrains.lesson3.cars.Car;
import ru.geekbrains.lesson3.cars.SportCar;
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
    public void wipMirrors(Car car) {

    }

    @Override
    public void wipWindshield(Car car) {

    }

    @Override
    public void wipHeadlights(Car car) {

    }
}
