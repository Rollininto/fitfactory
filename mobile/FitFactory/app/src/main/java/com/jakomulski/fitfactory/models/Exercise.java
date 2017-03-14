package com.jakomulski.fitfactory.models;

/**
 * Created by Adam on 15.01.2017.
 */
public class Exercise {
    private int id;
    private String name;
    private int num;
    boolean done;

    public Exercise(int id, String name, int num, boolean done, String value) {
        this.id = id;
        this.name = name;
        this.num = num;
        this.done = done;
        this.value = value;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getNum() {
        return num;
    }

    public void setNum(int num) {
        this.num = num;
    }

    public boolean isDone() {
        return done;
    }

    public void setDone(boolean done) {
        this.done = done;
    }

    public String getValue() {
        return value;
    }

    public void setValue(String value) {
        this.value = value;
    }

    String value;
}
