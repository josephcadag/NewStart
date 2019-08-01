package com.example.function;

public class Addition {

    public int _number1;

    public Addition(){
    }

    public void SetNumber1(int number1) {
        _number1 = number1;
    }

    public int GetNumber1() {
        return _number1;
    }

    public int _number2;

    public void SetNumber2(int number2){
        _number2 = number2;
    }

    public int GetNumber2(){
        return _number2;
    }

    public int Addition(){
        int result = _number1 + _number2;
        return result;
    }
}
