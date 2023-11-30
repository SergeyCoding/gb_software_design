package ru.geekbrains.lesson3;

import ru.geekbrains.lesson3.cars.FuelType;
import ru.geekbrains.lesson3.cars.SportCar;
import ru.geekbrains.lesson3.cars.UrbanCar;

import java.awt.*;

public class Program {
    public static void main(String[] args) {
        SportCar sportCar = SportCar.create("Ferrari", "F40", Color.BLACK, 4);
        sportCar.setFuelType(FuelType.Diesel);

        var car2= new UrbanCar("BMW","X5",Color.GRAY );
        car2.setFuelType(FuelType.Diesel);

        var car3= new UrbanCar("Toyota", "Corolla",Color.RED);
        car3.setFuelType(FuelType.Gasoline);
    }
}
