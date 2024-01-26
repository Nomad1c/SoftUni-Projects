#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

int main() {
    double budget;
    string season;
    cin >> budget >> season;

    string destination;
    string vacationType;
    double expenses;

    if (budget <= 100) {
        destination = "Bulgaria";
        if (season == "summer") {
            vacationType = "Camp";
            expenses = 0.30 * budget;
        }
        else if (season == "winter") {
            vacationType = "Hotel";
            expenses = 0.70 * budget;
        }
    }
    else if (budget <= 1000) {
        destination = "Balkans";
        if (season == "summer") {
            vacationType = "Camp";
            expenses = 0.40 * budget;
        }
        else if (season == "winter") {
            vacationType = "Hotel";
            expenses = 0.80 * budget;
        }
    }
    else {
        destination = "Europe";
        vacationType = "Hotel";
        expenses = 0.90 * budget;
    }

    cout << "Somewhere in " << destination << endl;
    cout << vacationType << " - " << fixed << setprecision(2) << expenses << endl;

    return 0;
}
