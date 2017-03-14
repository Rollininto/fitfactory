package com.jakomulski.fitfactory.models;

import java.sql.Date;

/**
 * Created by Adam on 15.01.2017.
 */
public class Training {
    private int id;

    public Training(int id, Date date, boolean hasExcersise) {
        this.id = id;
        this.date = date;
        this.hasExcersise = hasExcersise;
    }

    public int getId() {
        return id;
    }

    public Date getDate() {
        return date;
    }

    public boolean isHasExcersise() {
        return hasExcersise;
    }

    private Date date;
    private boolean hasExcersise;
}
