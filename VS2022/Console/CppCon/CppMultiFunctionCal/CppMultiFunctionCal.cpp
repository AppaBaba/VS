// CppMultiFunctionCal.cpp
//
#include <iostream>
#include <fstream>
#include <iomanip>
#include <string>
#include <cmath>

using namespace std;

class Cal
{
private:
    int p, cmdcode ;
    float x, y, z;
    
public:
    Cal() { cout << "Welcom to CppMultiFunctionCal " << endl; }
    ~Cal() { cout << "Thanks for using CppMultiFunctionCal" << endl; }
    
    void InputPar(int p) {
        if (p >= 1) {
            cout << "Enter x: ";
            cin >> x;
        }

        if (p >= 2) {
            cout << "Enter y: ";
            cin >> y;
        }
        if (p == 3) {
            cout << "Enter z";
            cin >> z;
        }
    }

    void MainMenu()
    {
        cout << "Enter operator:  ADD, -, *, /,:";
        cout << "Select '1' for Addition:" << endl;
        cout << "Select '2' for Subtracion:" << endl;
        cout << "Select '3' for Multiplication:" << endl;
        cout << "Select '4' for Divition:" << endl;
        cout << "Select '5' for Power:" << endl;
        cout << "Select '6' for Square Root:" << endl;
        cout << "Select '7' for Sin:" << endl;
        cout << "Select '8' for Cos:" << endl;
        cout << "Select '9' for Tan:" << endl;
        cout << "Select '10' Natural Logarithm::" << endl;
        cout << "Select '11' LOG with Base 10:" << endl;
        cout << "Select '12' for Exit:" << endl;
        cin >> cmdcode;
    }
    int getcmd() { return cmdcode; }
    void Add() { cout << x << " + " << y << " = " << x + y; }
    void Sub() { cout << x << " - " << y << " = " << x - y; }
    void Mul() { cout << x << " * " << y << " = " << x * y; }
    void Div() { cout << x << " / " << y << " = " << x / y; }
    void Pow() { cout << x << " ^ " << y << " = " << pow(x, y); }
    void Sqrt() { cout << "Sqrt(" << x << ")" <<  " = " << sqrt(x); }
    void Sin() { cout << "Sin(" << x << ")" << " = " << sin(x); }
    void Cos() { cout << "Cos(" << x << ")" << " = " << cos(x); }
    void Tan() { cout << "Tan(" << x << ")" << " = " << tan(x); }
    void Log() { cout << "Log(" << x << ")" <<  " = " << log(x); }
    void Log10() { cout << "Log10(" << x << ")" << " = " << log10(x); }
};

int main()
{
    int cmd;
    Cal c;
    do
    {
        c.MainMenu();
        cmd = c.getcmd();

        switch (cmd) {

        case 1 :
            c.InputPar(2);
            c.Add();
            break;

        case 2 :
            c.InputPar(2);
            c.Sub();
            break;

        case 3 :
            c.InputPar(2);
            c.Mul();
            break;
        case 4 :
            c.InputPar(2);
            c.Div();
            break;
        case 5 :
            c.InputPar(2);
            c.Pow();
            break;
        case 6 :
            c.InputPar(1);
            c.Sqrt();
            break;
        case 7 :
            c.InputPar(1);
            c.Sin();
            break;
        case 8 :
            c.InputPar(1);
            c.Cos();
            break;
        case 9 :
            c.InputPar(1);
            c.Tan();
            break;
        case 10 :
            c.InputPar(1);
            c.Log();
            break;
        case 11 :
            c.InputPar(1);
            c.Log10();
            break;

        case 12 :
            cout << "Leaving CppMFCal now.";
            break;

        default:
            cout << "Error! operator error!";
            break;
        }
        cout << "\n";

    } while (c.getcmd() != 12);

    return 0;
}

