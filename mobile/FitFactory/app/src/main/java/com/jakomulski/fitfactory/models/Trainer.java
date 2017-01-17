package com.jakomulski.fitfactory.models;

/**
 * Created by Adam on 2016-11-16.
 */
public class Trainer {
    private final String name;
    private final String goal;
    private final String login;
    private final String specialization;
    private final int id;

    public String getGoal() {
        return goal;
    }

    public String getLogin() {
        return login;
    }

    public String getSpecialization() {
        return specialization;
    }

    public int getId() {
        return id;
    }

    public Trainer(int id, String login, String name, String goal, String specialization) {
        this.name = name;
        this.specialization = specialization;
        this.id = id;
        this.login = login;
        this.goal = goal;
    }


    public String getName() {
        return name;
    }
}
