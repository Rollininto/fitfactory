package com.jakomulski.fitfactory;

import android.content.Context;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import com.jakomulski.fitfactory.models.Programme;
import com.jakomulski.fitfactory.models.Training;

import java.util.List;

/**
 * Created by Adam on 15.01.2017.
 */

public class TrainingAdapter extends ArrayAdapter<Training> {
    public TrainingAdapter(Context context, List<Training> specializations) {
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
        Training goal = getItem(position);
        // Check if an existing view is being reused, otherwise inflate the view
        if (convertView == null) {
            convertView = View.inflate(getContext(),
                    R.layout.item_specialization,
                    null);
        }

        // Lookup view for data population
        TextView name = (TextView) convertView.findViewById(R.id.name);

        name.setText(goal.getDate().toString());

        // Return the completed view to render on screen
        return convertView;
    }
}


