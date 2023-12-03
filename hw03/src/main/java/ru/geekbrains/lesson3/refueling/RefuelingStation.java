package ru.geekbrains.lesson3.refueling;

import ru.geekbrains.lesson3.carparts.FuelType;
import ru.geekbrains.lesson3.cars.Car;

public class RefuelingStation implements Refueling {
    @Override
    public void fuel(Car car) {
        switch (car.fuelType){
            case Diesel -> System.out.println("Заправка дизельным топливом");
            case Gasoline -> System.out.println("Заправка бензином");
        }
    }
}
