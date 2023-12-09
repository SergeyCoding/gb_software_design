package ru.geekbrains.lesson5.ui;

import ru.geekbrains.lesson5.db.entities.Model3D;
import ru.geekbrains.lesson5.db.entities.Texture;

import java.util.Collection;

public interface BusinessLogicalLayer {

    Collection<Model3D> getAllModels();

    Collection<Texture> getAllTextures();

    void renderModel(Model3D model);

    void renderAllModels();

    void deleteModel(Model3D model3D);
}
