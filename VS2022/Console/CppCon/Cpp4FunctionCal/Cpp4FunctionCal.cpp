// Cpp4FunctionCal.cpp
//
#include <iostream>
#include <fstream>
#include <iomanip>
#include <string>

using namespace std;

class Cal
{
private:
    float fn, sn;
    char opcode;
    string yn;
public:
    Cal() { cout << "Welcom to Cpp4FunctionCal " << endl; }
    ~Cal() { cout << "Thanks for using Cpp4FunctionCal" << endl; }
    void Input2Nums()
    {
        cout << "Enter first number: ";
        cin >> fn;
        cout << "Enter second number: ";
        cin >> sn;
    }
    void MainMenu()
    {
        cout << "Enter operator:  +, -, *, /, or e to exit :";
        cin >> opcode;
    }
    char getOPC() { return opcode; }
    void Add() { cout << fn << " + " << sn << " = " << fn + sn; }
    void Sub() { cout << fn << " - " << sn << " = " << fn - sn; }
    void Mul() { cout << fn << " * " << sn << " = " << fn * sn; }
    void Div() { cout << fn << " / " << sn << " = " << fn / sn; }
};

int main()
{
    Cal c;
    do
    {
        c.MainMenu();

        switch (c.getOPC())
        {
        case '+':
            c.Input2Nums();
            c.Add();
            break;

        case '-':
            c.Input2Nums();
            c.Sub();
            break;

        case '*':
            c.Input2Nums();
            c.Mul();
            break;

        case '/':
            c.Input2Nums();
            c.Div();
            break;

        case 'e':
            cout << "Leaving CppCal now.";
            break;

        default:
            cout << "Error! operator error!";
            break;
        }
        cout << "\n";

    } while (c.getOPC() != 'e');

    return 0;
}

