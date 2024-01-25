#include <iostream>
#include <cmath>
#include <string>

using namespace std;

int main() {
    string seriesName;
    getline(cin, seriesName);

    int episodeDuration, breakDuration;
    cin >> episodeDuration >> breakDuration;

    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    double lunchTime = breakDuration * 1.0 / 8;
    double restTime = breakDuration * 1.0 / 4;
    double remainingTime = breakDuration - lunchTime - restTime;

    if (remainingTime >= episodeDuration) {
        cout << "You have enough time to watch " << seriesName
            << " and left with " << static_cast<int>(round(remainingTime - episodeDuration))
            << " minutes free time." << endl;
    }
    else {
        cout << "You don't have enough time to watch " << seriesName
            << ", you need " << static_cast<int>(round(episodeDuration - remainingTime))
            << " more minutes." << endl;
    }

    return 0;
}
