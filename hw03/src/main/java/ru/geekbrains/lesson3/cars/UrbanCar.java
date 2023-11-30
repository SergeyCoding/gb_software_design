package ru.geekbrains.lesson3.cars;

import java.awt.*;

/**
 * Городской авто
 */
public class UrbanCar extends  Car{
    public UrbanCar(String make, String model, Color color) {
        super(make, model, color);
    }

    @Override
    public void movement() {

    }

    @Override
    public void maintenance() {

    }

    @Override
    public boolean gearShifting() {
        return false;
    }

    @Override
    public boolean switchHeadlights() {
        return false;
    }

    @Override
    public boolean switchWipers() {
        return false;
    }
}
