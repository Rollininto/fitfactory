package com.jakomulski.fitfactory;

import android.content.DialogInterface;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.EditText;
import android.widget.ListView;

import com.jakomulski.fitfactory.dao.DAO;
import com.jakomulski.fitfactory.models.Exercise;
import com.jakomulski.fitfactory.models.Training;

import java.sql.SQLException;
import java.util.List;

public class ExcersisesActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_excersises);
    }

    @Override
    protected void onResume() {
        super.onResume();

        final ListView exercisesListView = (ListView) findViewById(R.id.listView);
        try {
            final DAO dao = DAO.getInstance();
            final List<Exercise> exercises = dao.getExercises();
            ExerciseAdapter adapter = new ExerciseAdapter(this, exercises);
            exercisesListView.setAdapter(adapter);
            exercisesListView.setOnItemClickListener(new AdapterView.OnItemClickListener() {
                @Override
                public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                    //int trainingId = exercises.get(i).getId();
                    //dao.setTrainingId(trainingId);
                    showDialog(exercises.get(i));
                }
            });
        } catch (SQLException e) {
            e.printStackTrace();
        }


    }
    private void showDialog(final Exercise exercise){
        AlertDialog.Builder adb = new AlertDialog.Builder(this);


        //adb.setView(alertDialogView);


        //adb.setTitle("Title of alert dialog");


        adb.setIcon(android.R.drawable.ic_dialog_alert);


        adb.setPositiveButton("WYKONAJ", new DialogInterface.OnClickListener() {
            public void onClick(DialogInterface dialog, int which) {
                try {
                    DAO dao = DAO.getInstance();
                    dao.doExercise(exercise.getNum());
                } catch (SQLException e) {
                    e.printStackTrace();
                }
            } });


        adb.setNegativeButton("ANULUJ", new DialogInterface.OnClickListener() {
            public void onClick(DialogInterface dialog, int which) {


            } });
        adb.show();
    }
}
