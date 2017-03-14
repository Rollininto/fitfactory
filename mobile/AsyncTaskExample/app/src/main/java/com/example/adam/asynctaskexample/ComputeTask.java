package com.example.adam.asynctaskexample;

import android.content.Context;
import android.hardware.Sensor;
import android.hardware.SensorManager;
import android.os.AsyncTask;

import java.net.URL;


/**
 * Created by Adam on 02.12.2016.
 */

public class ComputeTask extends AsyncTask<Void, Integer, Object> {
    private final Context context;

    public ComputeTask(Context context) {
        this.context = context;
    }


    @Override
    protected Object doInBackground(Void... voids) {
        SensorManager sensorManager = (SensorManager) context.getSystemService(Context.SENSOR_SERVICE);
        Sensor sensor = sensorManager.getDefaultSensor(Sensor.);

        return null;
    }

    @Override
    protected void onPreExecute() {
        super.onPreExecute();
    }




    @Override
    protected void onProgressUpdate(Integer ... progress) {
        super.onPreExecute();
    }


}
