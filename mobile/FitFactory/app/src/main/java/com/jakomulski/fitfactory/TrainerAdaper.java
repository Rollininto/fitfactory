package com.jakomulski.fitfactory;

import android.content.Context;
import android.support.annotation.LayoutRes;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;
import com.jakomulski.fitfactory.models.Specialization;
import com.jakomulski.fitfactory.models.Trainer;

import java.util.List;

public class TrainerAdaper extends ArrayAdapter<Trainer> {
    public TrainerAdaper(Context context, List<Trainer> trainers) {
        super(context, 0, trainers);
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        return initView(position, convertView);
    }

    @Override
    public View getDropDownView(int position, View convertView,
                                ViewGroup parent) {
        return initView(position, convertView);
    }

    private View initView(int position, View convertView){
        Trainer trainer = getItem(position);
        // Check if an existing view is being reused, otherwise inflate the view
        if (convertView == null) {
            convertView = View.inflate(getContext(),
                    R.layout.item_trainer,
                    null);
        }

        // Lookup view for data population
        TextView name = (TextView) convertView.findViewById(R.id.name);
        TextView login = (TextView) convertView.findViewById(R.id.login);

        name.setText(trainer.getName());
        login.setText(trainer.getLogin());
        // Return the completed view to render on screen
        return convertView;
    }

}
