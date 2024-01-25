#include <iostream>

using namespace std;

int main() {
    int hours, minutes;
    cin >> hours >> minutes;

    int totalMinutes = hours * 60 + minutes + 15;

    int newHours = totalMinutes / 60 % 24;
    int newMinutes = totalMinutes % 60;

    cout << newHours << ":";

    if (newMinutes < 10) {
        cout << "0";
    }

    cout << newMinutes << endl;

    return 0;
}
