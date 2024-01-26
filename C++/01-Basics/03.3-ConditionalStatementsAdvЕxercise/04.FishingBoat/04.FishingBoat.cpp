#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

int main() {
    int budget;
    string season;
    int fishermen;
    cin >> budget >> season >> fishermen;

    double shipRent = 0.0;

    if (season == "Spring") {
        shipRent = 3000.0;
    }
    else if (season == "Summer" || season == "Autumn") {
        shipRent = 4200.0;
    }
    else if (season == "Winter") {
        shipRent = 2600.0;
    }

    if (fishermen <= 6) {
        shipRent *= 0.90;
    }
    else if (fishermen <= 11) {
        shipRent *= 0.85;
    }
    else {
        shipRent *= 0.75;
    }

    if (fishermen % 2 == 0 && season != "Autumn") {
        shipRent *= 0.95;
    }

    double diff = abs(budget - shipRent);

    if (budget >= shipRent) {
        cout << fixed << setprecision(2) << "Yes! You have " << diff << " leva left." << endl;
    }
    else {
        cout << fixed << setprecision(2) << "Not enough money! You need " << diff << " leva." << endl;
    }

    return 0;
}
