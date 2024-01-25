#include <iostream>

using namespace std;

int main() {
    int racer1, racer2, racer3;
    cin >> racer1 >> racer2 >> racer3;

    int totalSeconds = racer1 + racer2 + racer3;
    int minutes = totalSeconds / 60;
    int seconds = totalSeconds % 60;

    cout << minutes << ":";

    if (seconds < 10) {
        cout << "0";
    }

    cout << seconds << endl;

    return 0;
}