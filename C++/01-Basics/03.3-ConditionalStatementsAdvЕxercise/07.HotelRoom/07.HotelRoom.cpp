#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    string month;
    int nights;
    cin >> month >> nights;

    double studioPrice, apartmentPrice;

    if ((month == "May" || month == "October") && nights > 14) {
        studioPrice = 50 * 0.70;
    }
    else if ((month == "May" || month == "October") && nights <= 14 && nights > 7) {
        studioPrice = 50 * 0.95;
    }
    else if ((month == "May" || month == "October") && nights <= 7) {
        studioPrice = 50;
    }
    else if ((month == "June" || month == "September") && nights > 14) {
        studioPrice = 75.20 * 0.80;
    }
    else if ((month == "June" || month == "September") && nights <= 14) {
        studioPrice = 75.20;
    }
    else if (month == "July" || month == "August") {
        studioPrice = 76;
    }
    
    

    if (nights > 14) {
        if (month == "May" || month == "October") {
            apartmentPrice = 65 * 0.90;
        }
        else if (month == "June" || month == "September") {
            apartmentPrice = 68.70 * 0.90;
        }
        else if (month == "July" || month == "August") {
            apartmentPrice = 77 * 0.90;
        }
    }
    else {
        if (month == "May" || month == "October") {
            apartmentPrice = 65;
        }
        else if (month == "June" || month == "September") {
            apartmentPrice = 68.70;
        }
        else if (month == "July" || month == "August") {
            apartmentPrice = 77;
        }
    }

    double totalStudioPrice = studioPrice * nights;
    double totalApartmentPrice = apartmentPrice * nights;

    cout << "Apartment: " << fixed << setprecision(2) << totalApartmentPrice << " lv." << endl;
    cout << "Studio: " << fixed << setprecision(2) << totalStudioPrice << " lv." << endl;

    return 0;
}
