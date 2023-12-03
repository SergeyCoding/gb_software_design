package ru.geekbrains.lesson3.cars;

import ru.geekbrains.lesson3.carparts.CarType;
import ru.geekbrains.lesson3.carparts.FuelType;
import ru.geekbrains.lesson3.carparts.GearboxType;
import ru.geekbrains.lesson3.refueling.Refueling;

import java.awt.*;
import java.io.Console;
import java.util.Scanner;

public abstract class Car {

    public Car(String make, String model, Color color) {
        this.make = make;
        this.model = model;
        this.color = color;
    }

    /**
     * Заправить автомобиль
     */
    public void setFuelType(FuelType fuelType) {
      System.out.println(make+" "+model+" заправлен " + fuelType);
    }

    // Движение
    public abstract void movement();

    // Обслуживание
    public  void maintenance(String maintanceType){
        System.out.println(make+" "+model+" "+maintanceType);
    }

    // Переключение передач
    public abstract boolean gearShifting();
    // Включение фар
    public abstract boolean switchHeadlights();
    // Включение дворников
    public abstract boolean switchWipers();

    // Состояние противотуманных фар
    private boolean fogLights = false;
    public boolean switchFogLights(){
        fogLights = !fogLights;
        return fogLights;
    }

    private Refueling refueling;

    // Марка автомобиля
    private String make;

    // Модель
    private String model;

    // Цвет
    private Color color;

    // Тип
    public CarType carType;

    // Число колес
    public int wheelsCount = 4;

    // Тип топлива
    public FuelType fuelType = FuelType.Diesel;

    // Тип коробки передач
    public GearboxType gearboxType;

    // Объем двигателя
    public double engineCapacity;
}
