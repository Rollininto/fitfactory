package com.jakomulski.fitfactory.models;

/**
 * Created by Adam on 14.01.2017.
 */

public class Comment {
    private String text;
    private int addressee_id;
    private int target_id;

    public Comment(String text, Boolean wasRead, int addressee_id, int target_id) {
        this.text = text;
        this.wasRead = wasRead;
        this.addressee_id = addressee_id;
        this.target_id = target_id;
    }

    public int getAddressee_id() {
        return addressee_id;
    }

    public int getTarget_id() {
        return target_id;
    }

    public Comment(String text, Boolean wasRead) {
        this.text = text;
        this.wasRead = wasRead;
    }

    public String getText() {
        return text;
    }

    public Boolean getWasRead() {
        return wasRead;
    }

    private Boolean wasRead;
}
