package ru.geekbrains.lesson5.dbaccess;

import ru.geekbrains.lesson5.db.Entity;

import java.util.Collection;

/**
 * Интерфейс БД
 */
public interface Database {

    void load();

    void save();

    Collection<Entity> getAll();

}

