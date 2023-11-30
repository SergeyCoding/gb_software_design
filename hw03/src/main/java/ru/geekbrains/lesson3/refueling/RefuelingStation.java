package ru.geekbrains.lesson3.refueling;

import ru.geekbrains.lesson3.cars.FuelType;
import ru.geekbrains.lesson3.refueling.Refueling;

public class RefuelingStation implements Refueling {
    @Override
    public void fuel(FuelType fuelType) {
        switch (fuelType){
            case Diesel -> System.out.println("Заправка дизельным топливом");
            case Gasoline -> System.out.println("Заправка бензином");
        }
    }
}
