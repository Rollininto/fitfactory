package com.jakomulski.fitfactory;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.app.Activity;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Spinner;

import com.jakomulski.fitfactory.R;
import com.jakomulski.fitfactory.dao.DAO;
import com.jakomulski.fitfactory.models.Comment;
import com.jakomulski.fitfactory.models.Programme;
import com.jakomulski.fitfactory.models.Specialization;
import com.jakomulski.fitfactory.models.Trainer;

import java.sql.SQLException;
import java.util.List;

public class ManagerActivity extends Activity {

    Spinner trainersSpinner;
    Spinner programmesSpinner;
    ListView commentsListView;
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
        Button trainingsButton = (Button) findViewById(R.id.trainings_button);
        trainingsButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startProgramsDialog();
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
        programmesSpinner = (Spinner) findViewById(R.id.programmes);
        commentsListView = (ListView) findViewById(R.id.comments);


        final EditText commentText = (EditText) findViewById(R.id.editText);
        Button button = (Button) findViewById(R.id.button);
        final Context context = this;
        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                DAO dao = null;
                try {
                    dao = DAO.getInstance();
                    dao.addComment(commentText.getText().toString(), 5);
                } catch (SQLException e) {
                    e.printStackTrace();
                }
                setComments();
            }
        });
    }

    private void startProgramsDialog() {
        final Intent intent = new Intent(this, Programmes.class);
        startActivity(intent);
    }

    private void setComments()  {
        try {
            DAO dao = DAO.getInstance();
            List<Comment> comments = dao.getComments(1);
            CommentAdapter adapter = new CommentAdapter(this, comments);
            commentsListView.setAdapter(adapter);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    @Override
    protected void onResume() {
        super.onResume();
        try {
            final DAO dao = DAO.getInstance();
            final List<Trainer> trainers = dao.getTrainers();
            TrainerAdaper adapter = new TrainerAdaper(this, trainers);
            trainersSpinner.setAdapter(adapter);


            trainersSpinner.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
                @Override
                public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                    int trainerId = trainers.get(i).getId();
                    dao.setTrainerId(trainerId);
                    setComments();
                }

                @Override
                public void onNothingSelected(AdapterView<?> adapterView) {

                }
            });

            final List<Programme> programmes = dao.getProgrammes(3);
            ProgrammeAdapter padapter = new ProgrammeAdapter(this, programmes);
            programmesSpinner.setAdapter(padapter);
            programmesSpinner.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
                @Override
                public void onItemSelected(AdapterView<?> adapterView, View view, int i, long l) {
                    int programmeId = programmes.get(i).getId();
                    dao.setProgrammeId(programmeId);
                    dao.getTrainings(programmeId);
                }

                @Override
                public void onNothingSelected(AdapterView<?> adapterView) {

                }
            });


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
