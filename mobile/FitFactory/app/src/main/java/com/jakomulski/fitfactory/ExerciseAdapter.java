package com.jakomulski.fitfactory;

import android.content.Context;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.CheckBox;
import android.widget.TextView;

import com.jakomulski.fitfactory.models.Exercise;
import com.jakomulski.fitfactory.models.Programme;

import java.util.List;

/**
 * Created by Adam on 15.01.2017.
 */

public class ExerciseAdapter extends ArrayAdapter<Exercise> {
    public ExerciseAdapter(Context context, List<Exercise> specializations) {
        super(context, 0, specializations);
    }

    @Override
    public View getDropDownView(int position, View convertView,
                                ViewGroup parent) {
        return initView(position, convertView);
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        return initView(position, convertView);
    }

    private View initView(int position, View convertView){
        Exercise exercise = getItem(position);
        // Check if an existing view is being reused, otherwise inflate the view
        if (convertView == null) {
            convertView = View.inflate(getContext(),
                    R.layout.item_exercise,
                    null);
        }

        // Lookup view for data population
        TextView name = (TextView) convertView.findViewById(R.id.name);
        TextView value = (TextView) convertView.findViewById(R.id.value);
        CheckBox idDone = (CheckBox) convertView.findViewById(R.id.checkBox);

        name.setText(exercise.getName());
        value.setText(exercise.getValue());
        idDone.setChecked(exercise.isDone());
        // Return the completed view to render on screen
        return convertView;
    }
}
