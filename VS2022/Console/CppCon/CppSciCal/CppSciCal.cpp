// CppSciCal.cpp
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
    int p, n, s, cmdcode, catop, ca;
    float x, y, z, area, sp;
    int a, b, c, d;
    int A, B, C;


public:
    Cal() { cout << "Welcom to CppSciCal " << endl; }
    ~Cal() { cout << "Thanks for using CppSciCal" << endl; }

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
    void InputSide(int s) {
        if (s >= 1) {
            cout << "Enter side a: ";
            cin >> a;
        }

        if (s >= 2) {
            cout << "Enter side b: ";
            cin >> b;
        }
        if (s >= 3) {
            cout << "Enter side c: ";
            cin >> c;
        }
        if (s == 4) {
            cout << "Enter side d: ";
            cin >> d;
        }
    }
    void CatMenu() {
        
        cout << " Categories \n";
        cout<<"-----------------------------------\n";
        cout << " " << endl;

        cout << "1. OPERATIONS Menu"<< endl;
        cout << " " << endl;

        cout << "2. TRIGONOMETRIC Menu" << endl;
        cout << " " << endl;

        cout << "3. LOGARITHM Menu" << endl;
        //"18.Natural Log 19.Logarithm"
        cout << " " << endl;

        cout << "4. GEOMETRIC Menu" << endl;
        
        cout << " " << endl;
        cout << "5. Exit or Clear Screen" << endl;
        cout << " " << endl;
        cout << "Select Categorie: ";
        cin >> catop;
    }
    int getcat() { return catop; }
    void OpMenu(){
        cout << "Operation:" << endl;
        cout << "Select ' 1' for Addition:" << endl;
        cout << "Select ' 2' for Subtraction:" << endl;
        cout << "Select ' 3' for Multiplication:" << endl;
        cout << "Select ' 4' for Divition:" << endl;
        cout << "Select ' 5' for Exponent:" << endl;
        cout << "Select ' 6' for Square root:" << endl;
        cout << "Select ' 7' for Absolute Value:" << endl;
        cout << "Select ' 8' for Factorial:" << endl;
        cout << "Selection: ";
        cin >> cmdcode;
    }
    void TrigMenu(){
        cout << "TRIGONOMETRIC FUNCTIONS" << endl;
        cout << "Select ' 9' for Sin:" << endl;
        cout << "Select '10' for Cos:" << endl;
        cout << "Select '11' for Tan:" << endl;
        cout << "Select '12' for Asin:" << endl;
        cout << "Select '13' for Acos:" << endl;
        cout << "Select '14' for Atan:" << endl;
        cout << "Select '15' for Sinh:" << endl;
        cout << "Select '16' for Cosh:" << endl;
        cout << "Select '17' for Tanh:" << endl;
        cout << "Selection: ";
        cin >> cmdcode;
    }
    void LogMenu() {
        cout << "LOGARITHM FUNCTIONS" << endl;
        cout << "Select '18' Natural Logarithm::" << endl;
        cout << "Select '19' LOG with Base 10:" << endl;
        cout << "Selection: ";
    }
    void GeoMenu(){
        // GEOMETRIC FUNCTIONS
        cout << "20.Area of Triangle" << endl;
        cout << "21.Area of Rectangle" << endl;
        cout << "22.Area of Circle" << endl;
        cout << "23.Area of Square" << endl;
        cout << "24.Perimeter of Rectangle" << endl;
        cout << "25.Area of Parallelogram" << endl;
        cout << "26.Area of Trapezoid" << endl;
        cout << "27.Circumference of Circle" << endl;
        cout << "28.Perimeter of Square" << endl;
        cout << "29.Volume of Solid Figure" << endl;
        cout << "30. Perimeter of Parallelogram" << endl;
        cout << "Selection: ";
        cin >> cmdcode;
    }
    void ExitMenu() {
        cout << "Select '30 to clear screen:" << endl;
        cout << "Select '31' to Exit:" << endl;
        cout << "Selection: ";
        cin >> cmdcode;
    }
    int getcmd() { return cmdcode; }
    // Operations
    void Add() { cout << x << " + " << y << " = " << x + y; }
    void Sub() { cout << x << " - " << y << " = " << x - y; }
    void Mul() { cout << x << " * " << y << " = " << x * y; }
    void Div() { cout << x << " / " << y << " = " << x / y; }
    void Pow() { cout << x << " ^ " << y << " = " << pow(x, y); }
    void Sqrt() { cout << "Sqrt(" << x << ")" << " = " << sqrt(x); }
    void Abs() { cout << "Abs(" << x << ")" << " = " << abs(x); }
    int factorial()
    {
        cout << "Input Number: ";
        cin >> n;
        if (n == 0)
            return 1;
        int i = n, f = 1;
        while (n / i != n) {
            f = f * i;
            i--;
        }
        return f;
    }
    void Fact(){
        cout << "Factorial of " << n << " is "
            << factorial() << endl;
    }
    //TRIGONOMETRIC FUNCTIONS 
    void Sin() { cout << "Sin(" << x << ")" << " = " << sin(x); }
    void Cos() { cout << "Cos(" << x << ")" << " = " << cos(x); }
    void Tan() { cout << "Tan(" << x << ")" << " = " << tan(x); }
    void Asin() { cout << "Asin(" << x << ")" << " = " << asin(x); }
    void Acos() { cout << "Acos(" << x << ")" << " = " << acos(x); }
    void Atan() { cout << "Atan(" << x << ")" << " = " << atan(x); }
    void Sinh() { cout << "Sinh(" << x << ")" << " = " << sinh(x); }
    void Cosh() { cout << "Cosh(" << x << ")" << " = " << cosh(x); }
    void Tanh() { cout << "Tanh(" << x << ")" << " = " << tanh(x); }
    // LOGARITHM FUNCTIONS
    void Log() { cout << "Log(" << x << ")" << " = " << log(x); }
    void Log10() { cout << "Log10(" << x << ")" << " = " << log10(x); }
    // GEOMETRIC FUNCTIONS
    void TriAreaType() {
        int type;
        cout << "Equation quation to use:" << endl;
        cout << "1. Base Hight Eauation" << endl;
        cout << "2. All Three Sides Equation" << endl;
        cout << "3. Two Sides One Angle(SAS)" << endl;
        cout << "Selection: ";
        cin >> type;
        switch (type) {
        case 1:
            InputPar(2);
            TriAreaBaseHight();
            break;
        case 2:
            InputSide(3);
            TriAreaSides();
            break;
        case 3:
            TriAreaSAS();
            break;
        }
    }
    void TriAreaBaseHight() { cout << "Area = " << (x * y) / 2; }
    void TriAreaSides() {
        sp = (a + b + c) / 2;
        cout << sp << endl;
        area = sqrt(sp * (sp - a) * (sp - b) * (sp - c));
        cout << "Area = " << area;
    }void InputAngA(){
        cout << "Input side b: ";
        cin >> b;
        cout << " " << endl;
        cout << "Input side c: ";
        cin >> c;
        cout << " " << endl;
        cout << "Input angle A: ";
        cin >> A;
        cout << " " << endl;
    }
    void InputAngB(){
        cout << "Input side c: ";
        cin >> c;
        cout << " " << endl;
        cout << "Input side a: ";
        cin >> a;
        cout << " " << endl;
        cout << "Input angle B: ";
        cin >> B;
        cout << " " << endl;
    }
    void InputAngC(){
        cout << "Input side a: ";
        cin >> a;
        cout << " " << endl;
        cout << "Input side b: ";
        cin >> b;
        cout << " " << endl;
        cout << "Input angle C: ";
        cin >> C;
        cout << " " << endl;
    }
    void TriAreaSAS(){
        cout << "Choose angle used: ";
        cout << "1. Angle A" << endl;
        cout << "2. Angle B" << endl;
        cout << "3. Angle C" << endl;
        cout << "Choose : ";
        cin >> ca;
        
        switch (ca) {
        case 1:
            InputAngA();
            area = (b * c * sin(A)) / 2;
        case 2:
            InputAngB();
            area = (c * a * sin(B)) / 2;
        case 3:
            InputAngC();
            area = (a * b * sin(C)) / 2;
        
        }
        cout << "Area = " << area;
    }
};
    


int main()
{
    int cmd, cat;
    Cal c;
    do
    {
        c.CatMenu();
        cat = c.getcat();
        switch (cat) {
        case 1:
            c.OpMenu();
            break;
        case 2 :
            c.TrigMenu();
            break;
        case 3 :
            c.LogMenu();
            break;
        case 4 :
            c.GeoMenu();
            break;
        case 5 :
            c.ExitMenu();
            break;

        }
        
        cmd = c.getcmd();

        switch (cmd) {

        case 1:
            c.InputPar(2);
            c.Add();
            break;

        case 2:
            c.InputPar(2);
            c.Sub();
            break;

        case 3:
            c.InputPar(2);
            c.Mul();
            break;
        case 4:
            c.InputPar(2);
            c.Div();
            break;
        case 5:
            c.InputPar(2);
            c.Pow();
            break;
        case 6:
            c.InputPar(1);
            c.Sqrt();
            break;
        case 7:
            c.InputPar(1);
            c.Abs();
            break;
        case 8:
            c.Fact();
            break;
        case 9:
            c.InputPar(1);
            c.Sin();
            break;
        case 10:
            c.InputPar(1);
            c.Cos();
            break;
        case 11:
            c.InputPar(1);
            c.Tan();
            break;
        case 12:
            c.InputPar(1);
            c.Asin();
            break;
        case 13:
            c.InputPar(1);
            c.Acos();
            break;
        case 14:
            c.InputPar(1);
            c.Atan();
            break;
        case 15:
            c.InputPar(1);
            c.Sinh();
            break;
        case 16:
            c.InputPar(1);
            c.Cosh();
            break;
        case 17:
            c.InputPar(1);
            c.Tanh();
        case 18:
            c.InputPar(1);
            c.Log();
            break;
        case 19:
            c.InputPar(1);
            c.Log10();
            break;
        case 20:
            c.TriAreaType();
            break;

        case 30 :
            cout << "\033[2J\033[1;1H";
            break;
        case 31:
            cout << "Leaving CppMFCal now.";
            break;

        default:
            cout << "Error! operator error!";
            break;
        }
        cout << "\n";

    } while (c.getcmd() != 31);

    return 0;
}

