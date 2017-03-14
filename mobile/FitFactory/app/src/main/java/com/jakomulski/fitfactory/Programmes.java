package com.jakomulski.fitfactory;

import android.content.Intent;
import android.os.Bundle;
import android.app.Activity;
import android.view.View;
import android.widget.AdapterView;
import android.widget.EditText;
import android.widget.ListView;

import com.jakomulski.fitfactory.dao.DAO;
import com.jakomulski.fitfactory.dao.DBAccessObject;
import com.jakomulski.fitfactory.models.Programme;
import com.jakomulski.fitfactory.models.Training;

import java.sql.SQLException;
import java.util.List;

public class Programmes extends Activity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_programmes);

    }

    @Override
    protected void onResume() {
        super.onResume();

        final ListView programmesListView = (ListView) findViewById(R.id.listView);
        try {
            final DAO dao = DAO.getInstance();
            final List<Training> traninings = dao.getTrainings(3);
            TrainingAdapter adapter = new TrainingAdapter(this, traninings);
            programmesListView.setAdapter(adapter);
            programmesListView.setOnItemClickListener(new AdapterView.OnItemClickListener() {
                @Override
                public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                    int trainingId = traninings.get(i).getId();
                    dao.setTrainingId(trainingId);
                    openExercises();

                }
            });
        } catch (SQLException e) {
            e.printStackTrace();
        }



    }
    private void openExercises(){
        final Intent intent = new Intent(this, ExcersisesActivity.class);
        startActivity(intent);
    }
}
