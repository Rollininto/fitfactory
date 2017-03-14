package com.jakomulski.fitfactory.models;

import java.sql.Date;

/**
 * Created by Adam on 15.01.2017.
 */

public class Programme {
    private String desc;


    private int id;

    public int getId() {
        return id;
    }

    private Date from;

    public String getDesc() {
        return desc;
    }

    public Date getFrom() {
        return from;
    }

    public Programme(int id, String title, String desc, Date from, Date to) {
        this.id = id;
        this.title = title;
        this.desc = desc;
        this.from = from;
        this.to = to;
    }

    public Date getTo() {
        return to;
    }

    public String getTitle() {
        return title;
    }

    private Date to;
    private String title;

}
