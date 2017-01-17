package com.jakomulski.fitfactory.models;

/**
 * Created by Adam on 2016-11-16.
 */
public class Specialization {
    private final int id;
    private final String name;
    private final String description;

    public Specialization(int id, String name, String description) {
        this.id = id;
        this.name = name;
        this.description = description;
    }

    public String getName() {
        return name;
    }

    public String getDescription() {
        return description;
    }

    public int getId() {

        return id;
    }
}
