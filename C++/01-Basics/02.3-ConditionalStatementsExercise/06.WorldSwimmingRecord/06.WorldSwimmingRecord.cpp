#include <iostream>
#include <cmath>
#include <iomanip>

using namespace std;

int main() {
    double recordSeconds, distance, timePerMeter;

    cin >> recordSeconds >> distance >> timePerMeter;

    double resistanceTime = floor(distance / 15) * 12.5;

    double ivanTime = distance * timePerMeter + resistanceTime;

    cout << fixed << setprecision(2);

    if (ivanTime < recordSeconds) {
        cout << "Yes, he succeeded! The new world record is " << ivanTime << " seconds." << endl;
    }
    else {
        cout << "No, he failed! He was " << ivanTime - recordSeconds << " seconds slower." << endl;
    }

    return 0;
}
