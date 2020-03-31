package com.example.acalculadora2;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.*;


public class MainActivity extends AppCompatActivity {

    private EditText et1, et2;
    private TextView tv1;
    private RadioButton rb1, rb2, rb3, rb4;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        et1 = (EditText) findViewById(R.id.t_num1);
        et2 = (EditText) findViewById(R.id.t_num2);
        tv1 = (TextView) findViewById(R.id.t_resultado);
        rb1 = (RadioButton) findViewById(R.id.b_sumar);
        rb2 = (RadioButton) findViewById(R.id.b_restar);
        rb3 = (RadioButton) findViewById(R.id.b_multiplicar);
        rb4 = (RadioButton) findViewById(R.id.b_dividir);

    }

    public void Calcular (View view) {

        int num1 = Integer.parseInt(et1.getText().toString());
        int num2 = Integer.parseInt(et2.getText().toString());

        if (rb1.isChecked()==true) {
            int suma = num1 + num2;
            tv1.setText(String.valueOf(suma));
        }

        if (rb2.isChecked()==true) {
            int resta = num1 - num2;
            tv1.setText(String.valueOf(resta));
        }

        if (rb3.isChecked()==true) {
            int multiplicacion = num1 * num2;
            tv1.setText(String.valueOf(multiplicacion));
        }

        if (rb4.isChecked()==true) {
            if(num2==0){
                Toast.makeText(this,"No se puede dividir entre 0",Toast.LENGTH_LONG).show();
            } else {
                int division = num1 / num2;
                tv1.setText(String.valueOf(division));
            }
        }
    }

    public void limpiar (View view) {

    }
}
