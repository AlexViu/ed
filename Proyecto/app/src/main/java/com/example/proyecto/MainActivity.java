package com.example.proyecto;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.*;

import java.util.*;
import java.util.Random;


public class MainActivity extends AppCompatActivity {

    ArrayList<String> users = new ArrayList<String>();
    private EditText et1;
    private TextView tv1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        et1 = (EditText) findViewById(R.id.num_ini);
        tv1 = (TextView) findViewById(R.id.resultado);
    }


    public void clientes(View view) {
        String nom = et1.getText().toString();
        users.add(nom);
        et1.setText(String.valueOf(""));
    }

    public void random (View view) {

        int random = (int) (Math.random() * users.size());
        String nombre = users.get(random);
        tv1.setText(String.valueOf(nombre));

    }
}
