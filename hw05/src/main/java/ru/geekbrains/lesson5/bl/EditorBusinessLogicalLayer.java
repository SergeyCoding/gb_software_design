package ru.geekbrains.lesson5.bl;

import ru.geekbrains.lesson5.db.entities.Model3D;
import ru.geekbrains.lesson5.db.entities.Texture;
import ru.geekbrains.lesson5.ui.BusinessLogicalLayer;

import java.util.Collection;
import java.util.Random;

/**
 * Business Logical Layer
 * Описываем реализацию конкретных функций проекта
 */
public class EditorBusinessLogicalLayer implements BusinessLogicalLayer {

    private DatabaseAccess databaseAccess;
    private Random random = new Random();

    public EditorBusinessLogicalLayer(DatabaseAccess databaseAccess) {
        this.databaseAccess = databaseAccess;
    }

    @Override
    public Collection<Model3D> getAllModels() {
        return databaseAccess.getAllModels();
    }

    @Override
    public Collection<Texture> getAllTextures() {
        return databaseAccess.getAllTextures();
    }

    @Override
    public void renderModel(Model3D model) {
        processRender(model);
    }

    @Override
    public void renderAllModels() {
        for (Model3D model : getAllModels()) {
            processRender(model);
        }
    }

    @Override
    public void deleteModel(Model3D model3D) {
        databaseAccess.removeEntity(model3D);
    }

    private void processRender(Model3D model) {
        try {
            Thread.sleep(2500 - random.nextInt(2000));
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }

}
