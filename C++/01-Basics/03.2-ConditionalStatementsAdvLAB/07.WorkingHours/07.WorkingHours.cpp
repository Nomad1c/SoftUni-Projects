#include <iostream>
#include <string>

using namespace std;

int main() {
    int hour;
    string day;
    cin >> hour >> day;

    bool isOpen = (hour >= 10 && hour <= 18) && (day != "Sunday");

    if (isOpen) {
        cout << "open" << endl;
    }
    else {
        cout << "closed" << endl;
    }

    return 0;
}
