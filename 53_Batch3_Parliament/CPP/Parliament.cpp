//Author:Swanit Rivankar
//RollNo:2452
//Title:Parliament of India
//Start Date:9 July 2024
//Modified Date:24 July 2024
//Description:This program is implementing the working of parliament of India. It contains various classes to add members to Rajya Sabha and Lok Sabha and also to add the President.

#include <iostream>
#include <string>
using namespace std;

struct Member {
    string name;
    string party;
};

class Loksabha {
    public:
    Member members[552];
    int c=0;

    void Enter_lok_members() {
        cout << "Enter the number of members you want to enter:" << endl;
        cin >> c;
        cout << "Enter the Members:" << endl;
        cin.ignore();
        for (int i = 0; i < c; i++) {
            cout << "Enter member " << i+1 << " name: ";
            getline(cin, members[i].name);
            cout << "Enter member " << i+1 << " party: ";
            getline(cin, members[i].party);
        }
    }

    void show_details() {
        cout << "Loksabha Details\n" << "Maximum members: 552\n" << "Term: 5 Years\n" << "Role: Represents the people of India" << endl << endl;
    }

    void show_member_details() {
    if (c==0) {
        cout << "No members to display." << endl;
    }
    else{
        cout<<"LokSabha Members:\n";
        for (int i = 0; i < c; i++) {
            cout << "Member " << ": " << members[i].name << ", Party: " << members[i].party << endl;
        }
    }}
};

class Rajyasabha {
    public:
    Member members[552];
    int c=0;

    void Enter_raj_members() {
        cout << "Enter the number of members you want to enter:" << endl;
        cin >> c;
        cout << "Enter the Members:" << endl;
        cin.ignore();
        for (int i = 0; i < c; i++) {
            cout << "Enter member " << i+1 << " name: ";
            getline(cin, members[i].name);
            cout << "Enter member " << i+1 << " party: ";
            getline(cin, members[i].party);
        }
    }

    void show_details() {
        cout << "Rajyasabha Details\n" << "Maximum members: 250\n" << "Term: 6 Years\n" << "Role: Represents the states and union territories" << endl << endl;
    }

    void show_member_details() {
    if (c==0) {
        cout << "No members to display." << endl;
    }
    else{
        cout<<"RajyaSabha Members:\n";
        for (int i = 0; i < c; i++) {
        cout << "Member " << ": " << members[i].name << ", Party: " << members[i].party << endl;
        }
    }}
};

class President {
    public:
    string pname;
    int year;

    void enter_pres_details() {
        cout << "Enter the name of the President:" << endl;
        cin >> pname;
        cout << "Enter the year:" << endl;
        cin >> year;
    }

    void show_details() {
        if(pname.empty()){
            cout<<"President Details not entered"<<endl;
        }
        else cout << "President Details\n" << "Name: " << pname << endl << "Year: " << year << endl;
        cout<< "Role: The president is a part of the parliament and plays a ceremonial role" << endl << endl;
    }
};

int main() {
    Loksabha l1;
    Rajyasabha r1;
    President p1;

    int s;
    bool b = true;
    while (b == true) {
        cout << "\nEnter Your Choice:\n"<< "1: To Enter Loksabha Members\n"<< "2: To Enter Rajyasabha Members\n"<< "3: To Enter President Details\n"<< "4: To display Loksabha Details\n"<< "5: To display Rajyasabha Details\n"<< "6: To display Loksabha Members\n"<< "7: To display Rajyasabha Members\n"<< "8: To Show President Details\n"<< "9: Exit\n";
        cin >> s;

        switch (s) {
        case 1:
            l1.Enter_lok_members();
            break;
        case 2:
            r1.Enter_raj_members();
            break;
        case 3:
            p1.enter_pres_details();
            break;
        case 4:
            l1.show_details();
            break;
        case 5:
            r1.show_details();
            break;
        case 6:
            l1.show_member_details();
            break;
        case 7:
            r1.show_member_details();
            break;
        case 8:
            p1.show_details();
            break;
        case 9:
            cout<<"End of code.";
            b = false;
            break;
        default:
            break;
        }
    }

    return 0;
}
