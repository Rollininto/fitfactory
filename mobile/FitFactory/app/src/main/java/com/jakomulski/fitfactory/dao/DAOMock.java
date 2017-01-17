package com.jakomulski.fitfactory.dao;

import com.jakomulski.fitfactory.models.Goal;
import com.jakomulski.fitfactory.models.Specialization;
import com.jakomulski.fitfactory.models.Trainer;
import com.jakomulski.fitfactory.models.User;

import java.util.ArrayList;
import java.util.List;


public class DAOMock extends DAO {
    @Override
    public void addUser(User user) {
    }

    @Override
    public boolean isCorrectLoginAndPassword(String login, String password) {
        return true;
    }

    @Override
    public List<Specialization> getSpecializations() {
        List<Specialization> specializations = new ArrayList<Specialization>();
        specializations.add(new Specialization(1,"spec1", "desc"));
        specializations.add(new Specialization(2,"spec2", "desc"));
        specializations.add(new Specialization(3,"spec3", "desc"));
        specializations.add(new Specialization(4,"spec4", "desc"));
        return specializations;
    }

    @Override
    public List<Trainer> getTrainers(int specializationId) {
        List<Trainer> trainers = new ArrayList<>();
        trainers.add(new Trainer(1, "t1", "trainer1", "cel", "spec"));
        trainers.add(new Trainer(2, "t2", "trainer2", "cel", "spec"));
        trainers.add(new Trainer(3, "t3", "trainer3", "cel", "spec"));
        return trainers;
    }

    @Override
    public void sentInvitation(int userId, int trainerId) {

    }

    @Override
    public List<Trainer> getAvaiableTrainers(int userId) {
        return null;
    }

    @Override
    public List<Goal> getGoals() {
        List<Goal> goals = new ArrayList<>();
        goals.add(new Goal(1,"utrata wagi"));
        goals.add(new Goal(2,"siła"));
        goals.add(new Goal(3,"wytrzymałość"));
        return goals;
    }
}
