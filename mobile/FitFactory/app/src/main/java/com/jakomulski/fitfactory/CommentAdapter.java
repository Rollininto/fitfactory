package com.jakomulski.fitfactory;

import android.content.Context;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import com.jakomulski.fitfactory.dao.DAO;
import com.jakomulski.fitfactory.models.Comment;
import com.jakomulski.fitfactory.models.Specialization;

import java.sql.SQLException;
import java.util.List;

/**
 * Created by Adam on 2016-11-16.
 */
public class CommentAdapter extends ArrayAdapter<Comment> {
    public CommentAdapter(Context context, List<Comment> comments) {
        super(context, 0, comments);
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
        Comment comment = getItem(position);
        // Check if an existing view is being reused, otherwise inflate the view
        if (convertView == null) {
            convertView = View.inflate(getContext(),
                    R.layout.item_comment,
                    null);
        }

        // Lookup view for data population
        TextView user = (TextView) convertView.findViewById(R.id.user);
        TextView trainer = (TextView) convertView.findViewById(R.id.trainer);
        DAO dao = null;
        try {
            dao = DAO.getInstance();
            if(comment.getAddressee_id() == dao.getUserId())
                user.setText(comment.getText());
            else
                trainer.setText(comment.getText());
        } catch (SQLException e) {
            e.printStackTrace();
        }

        // Return the completed view to render on screen
        return convertView;
    }
}
