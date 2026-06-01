#include <iostream>
#pragma once  
using namespace std;
class User{
    public:
            string name;
            int age;
           
    private:
            string password;

  
    protected:
            string address;


    public:
            void getDetails(){
                cout << "Full Name: "<< name<< endl;
                cout << "Age: "<< age << endl;
                cout << "Address: " <<address << endl;

            }

            void setAddress(string addr){
                address = addr;

            }

     User(){
            cout << "User default consturtuor is called "<<endl;
     }

     User(string n,int a,string addr){
        name = n;
        age = a;
        address = addr;
     }
};
