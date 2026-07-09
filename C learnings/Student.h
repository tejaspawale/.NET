#include <iostream>
#include "User.h"
#include <string.h>
#pragma once  
using namespace std;

class Student: public User{

    public:
             string subject;
             string roadmap;
             int login = 1;

    Student(string n,int a,string addr,string sub,string road):User(n,a,addr){
        subject = sub;
        roadmap = road;
        login = 1;

    }


    void studnetDetails(){
        if(age>12){
            cout << "User is eligable in tap ";
            cout << "Full Name: "<< name<< endl;
            cout << "Age: "<< age << endl;
            cout << "Address: " << address << endl;
            cout << "Subject: " << subject << endl;
            cout << "roadmap: " << roadmap << endl;
            cout << "login: "   << login << endl;
        }else{
            cout<< "User is not eligabe in this tap program";
        }
    }


    void loginUser(string enteredName){
                    if(enteredName == "Tejas" && name =="Tejas"){
                        login = login + 1;
                        cout << "Login successful! Tejas has logged in " << login << " time(s)." << endl;
                    }else{
                        cout << "Login request ignored or invalid user name." << endl;
                    }
                }
};