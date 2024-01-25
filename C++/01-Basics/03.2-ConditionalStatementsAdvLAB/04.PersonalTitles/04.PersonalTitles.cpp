#include <iostream>

using namespace std;

int main() {
    double age;
    char gender;

    cin >> age >> gender;

    if (gender == 'm') {
        if (age >= 16) {
            cout << "Mr." << endl;
        }
        else {
            cout << "Master" << endl;
        }
    }
    else if (gender == 'f') {
        if (age >= 16) {
            cout << "Ms." << endl;
        }
        else {
            cout << "Miss" << endl;
        }
    }

    return 0;
}
