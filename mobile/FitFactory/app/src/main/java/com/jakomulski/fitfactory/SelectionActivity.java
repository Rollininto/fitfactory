package com.jakomulski.fitfactory;

import java.util.Calendar;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;
import android.widget.Spinner;
import android.widget.SpinnerAdapter;

import com.jakomulski.fitfactory.dao.DAO;
import com.jakomulski.fitfactory.models.Goal;
import com.jakomulski.fitfactory.models.Specialization;
import com.jakomulski.fitfactory.models.Trainer;


import java.sql.SQLException;
import java.util.Date;
import java.util.List;

import com.squareup.timessquare.CalendarCellDecorator;
import com.squareup.timessquare.CalendarPickerView;
import com.squareup.timessquare.CalendarPickerView.SelectionMode;
import com.squareup.timessquare.DefaultDayViewAdapter;

import static com.squareup.timessquare.CalendarPickerView.SelectionMode.RANGE;


public class SelectionActivity extends AppCompatActivity {

    private ListView trainersView;
    private Spinner specializationsSpinner;
    private Spinner goalsSpinner;

    private void sendInvitation(TrainerAdaper adapter, int i) {
        try {
            DAO dao = DAO.getInstance();

            Trainer trainer = adapter.getItem(i);
            dao.sentInvitation(1,trainer.getId());
        } catch (SQLException e) {
            e.printStackTrace();
            Helpers.createAlert(this, "Brak połączenia z internetem");
        }
    }

    @Override
    protected void onResume() {
        super.onResume();
        try {
            DAO dao = DAO.getInstance();

            List<Specialization> specializations = dao.getSpecializations();
            SpecializationAdapter adapter = new SpecializationAdapter(this, specializations);
            specializationsSpinner.setAdapter(adapter);

            List<Goal> goals = dao.getGoals();
            GoalsAdapter goalsAdapter = new GoalsAdapter(this, goals);
            goalsSpinner.setAdapter(goalsAdapter);

        } catch (SQLException e) {
            e.printStackTrace();
            finish();
        }
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_selection);



        trainersView = (ListView) findViewById(R.id.listView1);
        trainersView.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
            TrainerAdaper adapter = (TrainerAdaper)adapterView.getAdapter();
            sendInvitation(adapter, i);
            }
        });

        goalsSpinner = (Spinner) findViewById(R.id.goals);

        specializationsSpinner = (Spinner) findViewById(R.id.spinner);
        specializationsSpinner.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> adapterView, View arg1, int position,
                                       long arg3) {
                SpecializationAdapter adapter = (SpecializationAdapter)adapterView.getAdapter();
                Specialization specialization = adapter.getItem(position);
                setTrainers(specialization.getId());
            }
            @Override
            public void onNothingSelected(AdapterView<?> arg0) {
                //optionally do something here
            }
        });
    }



    private void setTrainers(int specializationId){
        try {
            DAO dao = DAO.getInstance();

            List<Trainer> trainers = dao.getTrainers(specializationId);
            TrainerAdaper trainerAdapter = new TrainerAdaper(this, trainers);
            trainersView.setAdapter(trainerAdapter);
        } catch (SQLException e) {
            e.printStackTrace();
            Helpers.createAlert(this, "Brak połączenia z internetem");
        }
    }


}
