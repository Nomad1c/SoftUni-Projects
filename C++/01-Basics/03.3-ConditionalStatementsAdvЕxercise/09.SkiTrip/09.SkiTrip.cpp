#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int main() {
    int days;
    string roomType, feedback;
    cin >> days;
    cin.ignore();
    getline(cin, roomType);
    getline(cin, feedback);

    double roomForOnePersonPrice = 18.00;
    double apartmentPrice = 25.00;
    double presidentApartmentPrice = 35.00;

    int nights = days - 1;
    double finalPrice = 0.0;

    if (roomType == "room for one person") {
        finalPrice = nights * roomForOnePersonPrice;
    }
    else if (roomType == "apartment") {
        finalPrice = nights * apartmentPrice;
        if (nights < 10) {
            finalPrice *= 0.70;
        }
        else if (nights <= 15) {
            finalPrice *= 0.65;
        }
        else {
            finalPrice *= 0.50;
        }
    }
    else if (roomType == "president apartment") {
        finalPrice = nights * presidentApartmentPrice;
        if (nights < 10) {
            finalPrice *= 0.90;
        }
        else if (nights <= 15) {
            finalPrice *= 0.85;
        }
        else {
            finalPrice *= 0.80;
        }
    }

    if (feedback == "positive") {
        finalPrice *= 1.25;
    }
    else if (feedback == "negative") {
        finalPrice *= 0.90;
    }

    cout << fixed << setprecision(2) << finalPrice << endl;

    return 0;
}
