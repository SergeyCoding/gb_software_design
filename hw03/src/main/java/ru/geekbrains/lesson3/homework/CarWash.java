package ru.geekbrains.lesson3.homework;

import ru.geekbrains.lesson3.cars.Car;
import ru.geekbrains.lesson3.refueling.Wiping;

/**
 * автомойка
 */
public class CarWash implements Wiping {

    private final String name;

    public CarWash(String Name) {
        name = Name;
    }

    @Override
    public void wipMirrors(Car car) {
        car.maintenance(name+" wipMirrors");
    }

    @Override
    public void wipWindshield(Car car) {
        car.maintenance(name+" wipWindshield");
    }

    @Override
    public void wipHeadlights(Car car) {
        car.maintenance(name+ " wipHeadlights");
    }

}
