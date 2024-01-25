#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int main() {
    string fruit, day;
    double quantity, price;

    cin >> fruit >> day >> quantity;

    if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday") {
        if (fruit == "banana") price = 2.50;
        else if (fruit == "apple") price = 1.20;
        else if (fruit == "orange") price = 0.85;
        else if (fruit == "grapefruit") price = 1.45;
        else if (fruit == "kiwi") price = 2.70;
        else if (fruit == "pineapple") price = 5.50;
        else if (fruit == "grapes") price = 3.85;
        else {
            cout << "error" << endl;
            return 0;
        }
    }
    else if (day == "Saturday" || day == "Sunday") {
        if (fruit == "banana") price = 2.70;
        else if (fruit == "apple") price = 1.25;
        else if (fruit == "orange") price = 0.90;
        else if (fruit == "grapefruit") price = 1.60;
        else if (fruit == "kiwi") price = 3.00;
        else if (fruit == "pineapple") price = 5.60;
        else if (fruit == "grapes") price = 4.20;
        else {
            cout << "error" << endl;
            return 0;
        }
    }
    else {
        cout << "error" << endl;
        return 0;
    }

    double total = quantity * price;
    cout << fixed << setprecision(2) << total << endl;

    return 0;
}
