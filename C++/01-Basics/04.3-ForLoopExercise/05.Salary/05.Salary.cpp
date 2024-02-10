#include <iostream>
#include <string>

using namespace std;

int main() {
    int numTabs;
    double salary;

    cin >> numTabs;
    cin >> salary;

    for (int i = 0; i < numTabs; ++i) {
        string website;
        cin >> website;

        if (website == "Facebook") {
            salary -= 150;
        }
        else if (website == "Instagram") {
            salary -= 100;
        }
        else if (website == "Reddit") {
            salary -= 50;
        }

        if (salary <= 0) {
            cout << "You have lost your salary." << endl;
            return 0;
        }
    }

    cout << salary << endl;

    return 0;
}
