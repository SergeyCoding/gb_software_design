package ru.geekbrains.lesson3;

import ru.geekbrains.lesson3.carparts.CarType;
import ru.geekbrains.lesson3.carparts.FuelType;
import ru.geekbrains.lesson3.carparts.GearboxType;
import ru.geekbrains.lesson3.cars.SportCar;
import ru.geekbrains.lesson3.cars.UrbanCar;
import ru.geekbrains.lesson3.homework.CarWash;
import ru.geekbrains.lesson3.homework.ServiceStation;

import java.awt.*;

public class Program {
    public static void main(String[] args) {
        SportCar sportCar = SportCar.create("Ferrari", "F40", Color.BLACK, 4);
        sportCar.wheelsCount=4;
        sportCar.carType= CarType.Sport;
        sportCar.fuelType=FuelType.Diesel;
        sportCar.gearboxType= GearboxType.AT;
        sportCar.engineCapacity=3000;


        var car2= new UrbanCar("BMW","X5",Color.GRAY );
        car2.setFuelType(FuelType.Diesel);

        var car3= new UrbanCar("Toyota", "Corolla",Color.RED);
        car3.setFuelType(FuelType.Gasoline);

        // Автомойка
        var carWash=new CarWash();

        // Сервисная станция
        var serviceStation=new ServiceStation();

        carWash.wipMirrors(sportCar);
        carWash.wipWindshield(sportCar);
        carWash.wipHeadlights(sportCar);
    }
}
