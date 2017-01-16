package com.jakomulski.fitfactory.dao;


import com.jakomulski.fitfactory.models.Comment;
import com.jakomulski.fitfactory.models.Exercise;
import com.jakomulski.fitfactory.models.Goal;
import com.jakomulski.fitfactory.models.Programme;
import com.jakomulski.fitfactory.models.Specialization;
import com.jakomulski.fitfactory.models.Trainer;
import com.jakomulski.fitfactory.models.Training;
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
    public abstract String sentInvitation(int userId, int trainerId);
    public abstract List<Trainer> getAvaiableTrainers(int userId);
    public abstract List<Goal> getGoals();
    public abstract List<Trainer> getTrainers();
    public abstract int getUserId();
    public abstract void addComment(String text, int addresseeId);
    public abstract List<Comment> getComments(int addresseeId);
    public abstract List<Programme> getProgrammes(int trainerId);
    public abstract List<Training> getTrainings(int progremmeId);
    public abstract void addTrainigDay(String date);
    public abstract void setProgrammeId(int programmeId);

    public abstract void setTrainerId(int trainerId);
    public abstract void setTrainingId(int trainingId);
    public abstract List<Exercise> getExercises();
    public abstract void doExercise(int num);
}
