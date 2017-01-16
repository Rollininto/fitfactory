package com.jakomulski.fitfactory.models;

/**
 * Created by Adam on 2016-11-17.
 */
public class Goal {
    private int id;
    private String name;
    private String description;

    public int getId() {
        return id;
    }

    public String getDescription() {
        return description;
    }
    public String getName() {
        return name;
    }
    public Goal(int id, String description, String name) {

        this.id = id;
        this.name = name;
        this.description = description;
    }
}
