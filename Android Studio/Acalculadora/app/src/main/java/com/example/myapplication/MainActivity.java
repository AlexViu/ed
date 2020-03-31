package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.*;


public class MainActivity extends AppCompatActivity {

    private EditText et1,et2;
    private TextView tv1;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        et1 = (EditText) findViewById(R.id.txt_num1);
        et2 = (EditText) findViewById(R.id.txt_num2);
        tv1 = (TextView) findViewById(R.id.txt_Resultado);
    }

    public void suma(View view) {

        int num1 = Integer.parseInt(et1.getText().toString());
        int num2 = Integer.parseInt(et2.getText().toString());
        int suma = num1 + num2;
        tv1.setText(String.valueOf(suma));
    }

    public void restar(View view) {

        int num1 = Integer.parseInt(et1.getText().toString());
        int num2 = Integer.parseInt(et2.getText().toString());
        int restar = num1 - num2;
        tv1.setText(String.valueOf(restar));
    }

    public void multiplicacion(View view) {

        int num1 = Integer.parseInt(et1.getText().toString());
        int num2 = Integer.parseInt(et2.getText().toString());
        int multiplicar = num1 * num2;
        tv1.setText(String.valueOf(multiplicar));
    }

    public void division(View view) {

        int num1 = Integer.parseInt(et1.getText().toString());
        int num2 = Integer.parseInt(et2.getText().toString());
        int dividir = num1 / num2;
        tv1.setText(String.valueOf(dividir));
    }

}

