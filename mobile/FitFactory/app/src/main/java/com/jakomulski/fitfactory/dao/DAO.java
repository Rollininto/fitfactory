package com.jakomulski.fitfactory.dao;


import com.jakomulski.fitfactory.models.Goal;
import com.jakomulski.fitfactory.models.Specialization;
import com.jakomulski.fitfactory.models.Trainer;
import com.jakomulski.fitfactory.models.User;

import java.sql.SQLException;
import java.util.List;

public abstract class DAO {
    private static DAO instance = null;

    public static DAO getInstance() throws SQLException {
        if(instance == null)
            instance = new DBAccessObject();
        return instance;
    }

    public abstract void addUser(User user);
    public abstract boolean isCorrectLoginAndPassword(String login, String password);
    public abstract List<Specialization> getSpecializations();
    public abstract List<Trainer> getTrainers(int specializationId);
    public abstract void sentInvitation(int userId, int trainerId);
    public abstract List<Trainer> getAvaiableTrainers(int userId);
    public abstract List<Goal> getGoals();
}
