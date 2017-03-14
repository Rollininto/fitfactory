package com.jakomulski.fitfactory;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import com.jakomulski.fitfactory.dao.DAO;
import com.squareup.timessquare.CalendarPickerView;

import java.sql.SQLException;
import java.text.Format;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.List;

import static com.squareup.timessquare.CalendarPickerView.SelectionMode.MULTIPLE;
import static com.squareup.timessquare.CalendarPickerView.SelectionMode.RANGE;

public class DatePickerActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_date_picker);

        Calendar nextYear = Calendar.getInstance();
        nextYear.add(Calendar.YEAR, 1);

        final CalendarPickerView calendar = (CalendarPickerView) findViewById(R.id.calendar_view);
        Date today = new Date();
        calendar.init(today, nextYear.getTime())
                .withSelectedDate(today)
                .inMode(MULTIPLE);

        Button okButton = (Button) findViewById(R.id.ok_button);
        okButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                List<Date> dates =  calendar.getSelectedDates();
                try {
                    DAO dao = DAO.getInstance();
                    StringBuilder sb = new StringBuilder();
                    for(Date date : dates) {
                        Format formatter = new SimpleDateFormat("dd/MM/yyyy");

                        String dateStr = formatter.format(date);
                        sb.append(dateStr+',');

                    }
                    dao.addTrainigDay(sb.toString());

                } catch (SQLException e) {
                    e.printStackTrace();
                }
                finish();
            }
        });
    }
}
