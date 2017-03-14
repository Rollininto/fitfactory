package com.jakomulski.fitfactory;

import android.content.Context;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import com.jakomulski.fitfactory.models.Goal;
import com.jakomulski.fitfactory.models.Programme;

import java.util.List;

/**
 * Created by Adam on 15.01.2017.
 */

public class ProgrammeAdapter  extends ArrayAdapter<Programme> {
    public ProgrammeAdapter(Context context, List<Programme> specializations) {
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
        Programme programme = getItem(position);
        // Check if an existing view is being reused, otherwise inflate the view
        if (convertView == null) {
            convertView = View.inflate(getContext(),
                    R.layout.item_programme,
                    null);
        }

        // Lookup view for data population
        TextView title = (TextView) convertView.findViewById(R.id.title);
        TextView desc = (TextView) convertView.findViewById(R.id.desc);

        title.setText(programme.getTitle());
        desc.setText(programme.getDesc());

        // Return the completed view to render on screen
        return convertView;
    }
}
