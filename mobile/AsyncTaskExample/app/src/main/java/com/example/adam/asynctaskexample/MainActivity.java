package com.example.adam.asynctaskexample;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import java.net.URL;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Button maintainComute = (Button)findViewById(R.id.maintainComute);
        maintainComute.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                new ComputeTask();
            }
        });

    }
}
