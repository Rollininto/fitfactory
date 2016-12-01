package com.jakomulski.fitfactory.models;

/**
 * Created by Adam on 2016-11-17.
 */
public class Goal {
    private int id;
    private String description;

    public int getId() {
        return id;
    }

    public String getDescription() {
        return description;
    }

    public Goal(int id, String description) {

        this.id = id;
        this.description = description;
    }
}
