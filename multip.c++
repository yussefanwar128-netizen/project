#include <iostream>
using namespace std;
int main() {
    cout<<"\tThe first project (c++) \n";
    cout<<"\tMultiplication Table \n";
    double num;
    cout<<"enter the number : ";
    cin>>num;
    for(double x=0; x<=12; x++)
    {
        cout<<num<<"*"<<x<<"="<<num*x<<"\n";
    }
}