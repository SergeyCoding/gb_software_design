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
        car2.wheelsCount=4;
        car2.carType= CarType.Hatchback;
        car2.fuelType=FuelType.Diesel;
        car2.gearboxType= GearboxType.AT;
        car2.engineCapacity=2500;

        var car3= new UrbanCar("Toyota", "Corolla",Color.RED);
        car3.wheelsCount=4;
        car3.carType= CarType.Sedan;
        car3.fuelType=FuelType.Gasoline;
        car3.gearboxType= GearboxType.MT;
        car3.engineCapacity=1500;

        // Автомойка
        var carWash=new CarWash("Автомойка");

        // Сервисная станция
        var serviceStation=new ServiceStation("Сервисная станция");

        carWash.wipMirrors(sportCar);
        carWash.wipWindshield(car2);
        carWash.wipHeadlights(car3);

        serviceStation.wipMirrors(sportCar);
        serviceStation.fuel(sportCar);

        serviceStation.wipWindshield(car2);
        serviceStation.fuel(car2);

        serviceStation.wipHeadlights(car3);
        serviceStation.fuel(car3);
    }
}
