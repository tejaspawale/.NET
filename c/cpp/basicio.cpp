#include <iostream>

using namespace std;

int main(){

    char buff[512];
    cout << "what is your name:";

    cin.getline(buff, 64, '\n');
	cout << "Your name is:" << buff << endl;

    int age;

    cout <<"Enter age :";

    cin >> age;

    cout << "My Name is :" << buff 
         << " My age is " << age <<endl;




}
