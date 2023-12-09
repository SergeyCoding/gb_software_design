package ru.geekbrains.lesson5.bl;

import ru.geekbrains.lesson5.db.Entity;
import ru.geekbrains.lesson5.db.entities.Model3D;
import ru.geekbrains.lesson5.db.entities.Texture;

import java.util.Collection;

public interface DatabaseAccess {

    void addEntity(Entity entity);

    void removeEntity(Entity entity);

    Collection<Texture> getAllTextures();

    Collection<Model3D> getAllModels();
}
