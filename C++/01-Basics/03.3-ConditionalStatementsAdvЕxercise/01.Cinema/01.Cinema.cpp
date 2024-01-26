#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int main() {
    const double PREMIERE_PRICE = 12.00;
    const double NORMAL_PRICE = 7.50;
    const double DISCOUNT_PRICE = 5.00;

    string projectionType;
    int rows, columns;
    cin >> projectionType >> rows >> columns;

    double totalIncome = 0.0;

    if (projectionType == "Premiere") {
        totalIncome = PREMIERE_PRICE * rows * columns;
    }
    else if (projectionType == "Normal") {
        totalIncome = NORMAL_PRICE * rows * columns;
    }
    else if (projectionType == "Discount") {
        totalIncome = DISCOUNT_PRICE * rows * columns;
    }

    cout << fixed << setprecision(2) << totalIncome << " leva" << endl;

    return 0;
}