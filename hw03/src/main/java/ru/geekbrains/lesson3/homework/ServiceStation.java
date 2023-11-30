package ru.geekbrains.lesson3.homework;

import ru.geekbrains.lesson3.carparts.FuelType;
import ru.geekbrains.lesson3.cars.Car;
import ru.geekbrains.lesson3.refueling.Refueling;
import ru.geekbrains.lesson3.refueling.Wiping;

/**
 *сервисная станция
 */
public  class ServiceStation implements Refueling, Wiping {

    private final String name;

    public ServiceStation(String name) {

        this.name = name;
    }

    @Override
    public void fuel(Car car) {
        System.out.println(name+ ": заправить "+ car.carType+" - "+car.fuelType);
        car.setFuelType(car.fuelType);
    }

    @Override
    public void wipMirrors(Car car) {
        car.maintenance(name+" wipMirrors");
    }

    @Override
    public void wipWindshield(Car car) {
        car.maintenance(name+" wipMirrors");
    }

    @Override
    public void wipHeadlights(Car car) {
        car.maintenance(name+" wipMirrors");
    }
}
