package ru.geekbrains.lesson6.notes.domain;

import java.util.Date;

public class Note {


    private int userId;
    private int id;
    private String title;
    private String details;
    private Date creationDate;
    private Date editDate;
    public Note(int id, int userId, String title, String details, Date creationDate) {
        this.id = id;
        this.title = title;
        this.details = details;
        this.creationDate = creationDate;
        this.userId = userId;
    }

    @Override
    public String toString() {
        return "Note{" +
                "userId=" + userId +
                ", id=" + id +
                ", title='" + title + '\'' +
                ", details='" + details + '\'' +
                ", creationDate=" + creationDate +
                ", editDate=" + editDate +
                '}';
    }

    public int getUserId() {
        return userId;
    }

    public void setUserId(int userId) {
        this.userId = userId;
    }

    public int getId() {
        return id;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getDetails() {
        return details;
    }

    public void setDetails(String details) {
        this.details = details;
    }

    public Date getCreationDate() {
        return creationDate;
    }

    public Date getEditDate() {
        return editDate;
    }

    public void setEditDate(Date editDate) {
        this.editDate = editDate;
    }
}
