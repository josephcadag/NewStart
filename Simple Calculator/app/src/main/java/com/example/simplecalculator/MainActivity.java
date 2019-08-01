package com.example.simplecalculator;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import com.example.function.Addition;
import com.example.function.Division;
import com.example.function.Multiply;
import com.example.function.Subtract;
import static java.lang.Integer.parseInt;

public class MainActivity extends AppCompatActivity {
    EditText number1;
    EditText number2;
    TextView result;
    Button Add_button;
    Button Sub_button;
    Button Mul_button;
    Button Div_button;
    Button Clear_button;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        number1 = findViewById(R.id.num_1);
        number2 = findViewById(R.id.num_2);
        result = findViewById(R.id.result);
        Add_button = findViewById(R.id.btn_add);
        Sub_button = findViewById(R.id.btn_sub);
        Mul_button = findViewById(R.id.btn_mul);
        Div_button = findViewById(R.id.btn_div);
        Clear_button = findViewById(R.id.btn_clear);

        Add_button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Addition addition = new Addition();
                addition.SetNumber1(parseInt(number1.getText().toString()));
                addition.SetNumber2(parseInt(number2.getText().toString()));
                result.setText(String.valueOf(addition.Addition()));
            }
        });

        Sub_button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Subtract subtract = new Subtract();
                subtract.SetNumber1(parseInt(number1.getText().toString()));
                subtract.SetNumber2(parseInt(number2.getText().toString()));
                result.setText(String.valueOf(subtract.Subtract()));
            }
        });

        Mul_button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Multiply multiply = new Multiply();
                multiply.SetNumber1(parseInt(number1.getText().toString()));
                multiply.SetNumber2(parseInt(number2.getText().toString()));
                result.setText(String.valueOf(multiply.Multiply()));
            }
        });

        Div_button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Division division = new Division();
                division.SetNumber1(parseInt(number1.getText().toString()));
                division.SetNumber2(parseInt(number2.getText().toString()));
                result.setText(String.valueOf(division.Division()));
            }
        });

        final EditText num_1 = findViewById(R.id.num_1);
        final EditText num_2 = findViewById(R.id.num_2);
        final TextView result = findViewById(R.id.result);

        Clear_button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                num_1.setText("");
                num_2.setText("");
                result.setText("");
            }
        });
    }
}
