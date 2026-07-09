#include <iostream>
#include "User.h"
#include "Student.h"
using namespace std;

int main() {

    // User tapUser;
    // tapUser.name = "Ravi Kumar";
    // tapUser.age  = 35;
    // tapUser.setAddress("Walvekar Nagar, Pune");   
    // tapUser.getDetails();                          

    // cout << "\n--- Student ---\n";

    // Student s;
    // s.name    = "Tejas";
    // s.age     = 28;
    // s.subject = "C++";
    // s.roadmap = "Full Stack .NET";
    // s.setAddress("Ghatkopar, Mumbai"); 

    // s.studnetDetails();
    // s.loginUser("Tejas");
    // s.loginUser("Rahul");

    User* Tapuser = new User( "Tejas",28,"Ghatkopar, Mumbai");
    Tapuser ->getDetails();
    User* Tapuser2 = new User();


    Student* s = new Student( "Tejas",28,"Ghatkopar, Mumbai","C++","Full Stack .NET");
    s->studnetDetails();
    cout <<"address which i give when object is create" << endl;
    s->loginUser("Tejas");
    s->setAddress( "Walvekar Nagar, Pune");
    cout <<"address which i change using setAddress " << endl;
    s->studnetDetails();


}