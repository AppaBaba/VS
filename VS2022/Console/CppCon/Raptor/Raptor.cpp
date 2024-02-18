// Raptor.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

class Raptor
{
public:
    string Bird = "Raptor";
    void Raptors() {
        cout << "A Raptor is a bird of prey.\n";
        cout << "hooked beaks with sharp edges.\n";
        cout << "feet with sharp, curved claws or talons.\n";
        cout << "keen eyesight.\n";
    }
};

class Eagle : public Raptor
{
public:
    string Raptor = "Eagle";
    void Eagles() {
        cout << "An adult bald eagle is evenly dark brown\n";
        cout << "with a white head and tail.\n\n";
    }
};

class Osprey : public Raptor
{
public:
    string Raptor = "Osprey";
    void Ospreys()
    {
        cout << "white heads\n";
        cout << "distinctive black eyestripe\n";
        cout << "that goes down the side of their faces\n\n";
    }
};

int main()
{
    Eagle theEagle;
    cout << theEagle.Bird + " " + theEagle.Raptor + "\n";
    theEagle.Raptors();
    theEagle.Eagles();

    Osprey theOsprey;
    cout << theOsprey.Bird + " " + theOsprey.Raptor + "\n";
    theOsprey.Raptors();
    theOsprey.Ospreys();
    return 0;

}