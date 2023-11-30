package ru.geekbrains.lesson3.cars;

import ru.geekbrains.lesson3.refueling.Refueling;

import java.awt.*;

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
      this.fuelType =fuelType;
    }

    public int getWheelsCount() {
        return wheelsCount;
    }

    // Движение
    public abstract void movement();
    // Обслуживание
    public abstract void maintenance();
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

    //endregion

    //region Поля

    private Refueling refueling;

    // Марка автомобиля
    private String make;

    // Модель
    private String model;

    // Цвет
    private Color color;

    // Тип
    protected CarType type;

    // Число колес
    protected int wheelsCount = 4;

    // Тип топлива
    protected FuelType fuelType = FuelType.Diesel;

    // Тип коробки передач
    private GearboxType gearboxType;

    // Объем двигателя
    private double engineCapacity;



    //endregion

}
