package ru.geekbrains.lesson6;

import ru.geekbrains.lesson6.database.NotesDatabase;
import ru.geekbrains.lesson6.notes.application.ConcreteNoteEditor;
import ru.geekbrains.lesson6.notes.domain.Note;
import ru.geekbrains.lesson6.notes.infrastructure.persistance.DatabaseContext;
import ru.geekbrains.lesson6.notes.presentation.queries.controllers.NotesController;
import ru.geekbrains.lesson6.notes.presentation.queries.views.NotesConsolePresenter;

import java.util.Date;

public class Program {

    public static void main(String[] args) {
        NotesController notesController = new NotesController(new ConcreteNoteEditor(new NotesConsolePresenter(), new DatabaseContext(new NotesDatabase())));
        notesController.routeGetAll();

        System.out.println("Добавление записи");

        notesController.routeAddNote(new Note(0, 11, "hw06", "hw06", new Date()));

        notesController.routeGetAll();
    }

}
