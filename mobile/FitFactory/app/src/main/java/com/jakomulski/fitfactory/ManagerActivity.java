package com.jakomulski.fitfactory;

import android.content.Intent;
import android.os.Bundle;
import android.app.Activity;
import android.view.View;
import android.widget.Button;
import android.widget.Spinner;

import com.jakomulski.fitfactory.R;
import com.jakomulski.fitfactory.dao.DAO;
import com.jakomulski.fitfactory.models.Specialization;
import com.jakomulski.fitfactory.models.Trainer;

import java.sql.SQLException;
import java.util.List;

public class ManagerActivity extends Activity {

    Spinner trainersSpinner;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_manager);

        Button inviteTrainerButton = (Button) findViewById(R.id.invite_trainer_button);
        inviteTrainerButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startInviteTrainerActivity();
            }
        });
        Button pickDate = (Button) findViewById(R.id.date_picker_button);
        pickDate.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startDatePickerDialog();
            }
        });

        trainersSpinner = (Spinner) findViewById(R.id.trainers);
    }

    @Override
    protected void onResume() {
        super.onResume();
        try {
            DAO dao = DAO.getInstance();
            List<Trainer> trainers = dao.getAvaiableTrainers(1);
            TrainerAdaper adapter = new TrainerAdaper(this, trainers);
            trainersSpinner.setAdapter(adapter);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    private void startDatePickerDialog(){
        final Intent intent = new Intent(this, DatePickerActivity.class);
        startActivity(intent);
    }

    private void startInviteTrainerActivity(){
        final Intent intent = new Intent(this, SelectionActivity.class);
        startActivity(intent);
    }



}
