#include <iostream>
using namespace std;
int main()
{
    cout << "\t GPA (c++)\n";
    double total;
    double average;
    double math, english, physics, chemistry, biology;
    cout << "math : ";
    cin >> math;
    if (math > 100 || math < 0)
    {
        cout << "Enter the correct number ";
        return 0;
    }
    cout << "English : ";
    cin >> english;
    if (english > 100 || english < 0)
    {
        cout << "Enter the correct number ";
        return 0;
    }
    cout << "Physics : ";
    cin >> physics;
    if (physics > 100 || physics < 0)
    {
        cout << "Enter the correct number ";
        return 0;
    }
    cout << "Chemistry : ";
    cin >> chemistry;
    if (chemistry > 100 || chemistry < 0)
    {
        cout << "Enter the correct number ";
        return 0;
    }
    cout << "Biology : ";
    cin >> biology;
    if (biology > 100 || biology < 0)
    {
        cout << "Enter the correct number ";
        return 0;
    }
    total = math + english + physics + chemistry + biology;
    cout << "total : " << total << endl;
    average = total / 5;
    cout << "average : " << average << endl;

    if (average >= 90 && average <= 100)
    {
        cout << "A";
    }
    else if (average >= 80 && average < 90)
    {
        cout << "B";
    }
    else if (average >= 70 && average < 80)
    {
        cout << "C";
    }
    else if (average >= 60 && average < 70)
    {
        cout << "D";
    }
    else if (average >= 50 && average < 60)
    {
        cout << "D-";
    }
    else
    {
        cout << "F";
    }
}