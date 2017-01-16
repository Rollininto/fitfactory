package com.jakomulski.fitfactory;

import android.app.Activity;
import android.app.DatePickerDialog;
import android.app.Dialog;
import android.content.Context;
import android.content.DialogInterface;
import android.support.annotation.IntDef;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.KeyEvent;
import android.view.View;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import com.jakomulski.fitfactory.dao.DAO;
import com.jakomulski.fitfactory.dao.DBAccessObject;
import com.jakomulski.fitfactory.models.User;

import java.io.BufferedInputStream;
import java.io.BufferedReader;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;
import java.sql.Date;
import java.sql.SQLException;
import java.util.Calendar;
import java.util.GregorianCalendar;

import java.net.URLConnection;

public class RegisterActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register);

        final EditText login = (EditText) findViewById(R.id.login);
        final EditText password = (EditText) findViewById(R.id.password);
        final EditText email = (EditText) findViewById(R.id.email);
        final EditText name = (EditText) findViewById(R.id.name);
        final EditText lastname = (EditText) findViewById(R.id.lastname);
        final EditText birthdate = (EditText) findViewById(R.id.birthdate);
        final User user = new User();

        Button mEmailSignInButton = (Button) findViewById(R.id.register_button);
        final Context context = this;
        mEmailSignInButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                try {

                    DAO dao = DAO.getInstance();

                    user.login = login.getText().toString();
                    user.email = email.getText().toString();
                    user.name = name.getText().toString();
                    user.lastName = lastname.getText().toString();
                    user.sex = 'M';
                    user.password = password.getText().toString();

                    dao.addUser(user);
                    finish();


                } catch (SQLException e) {
                    e.printStackTrace();
                    Helpers.createAlert(context, "Brak połączenia z internetem");
                }
            }
        });
        birthdate.setKeyListener(null);
        final DatePickerDialog dialog = new DatePickerDialog(this, new DatePickerDialog.OnDateSetListener() {
            @Override
            public void onDateSet(DatePicker datePicker, int year, int month, int day) {
                birthdate.setText(String.format("%s-%s-%s", year, month + 1, day));
                Calendar calendar = new GregorianCalendar();


                calendar.set(year, month, day);
                user.birthDate = new Date(calendar.getTimeInMillis());
            }
        }, 1999, 1, 1);


        birthdate.setOnFocusChangeListener(new View.OnFocusChangeListener() {
            @Override
            public void onFocusChange(View view, boolean b) {
                if (b) {
                    dialog.show();
                }
            }
        });
        birthdate.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                dialog.show();
            }
        });


    }
}

