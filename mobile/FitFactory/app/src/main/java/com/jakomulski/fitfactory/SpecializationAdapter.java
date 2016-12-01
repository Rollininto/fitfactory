package com.jakomulski.fitfactory;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;
import com.jakomulski.fitfactory.R;
import com.jakomulski.fitfactory.models.Specialization;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by Adam on 2016-11-16.
 */
public class SpecializationAdapter extends ArrayAdapter<Specialization> {
    public SpecializationAdapter(Context context, List<Specialization> specializations) {
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
        Specialization specialization = getItem(position);
        // Check if an existing view is being reused, otherwise inflate the view
        if (convertView == null) {
            convertView = View.inflate(getContext(),
                    R.layout.item_specialization,
                    null);
        }

        // Lookup view for data population
        TextView name = (TextView) convertView.findViewById(R.id.name);

        name.setText(specialization.getName());

        // Return the completed view to render on screen
        return convertView;
    }
}
