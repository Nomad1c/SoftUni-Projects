#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    double excursionPrice;
    int puzzles, dolls, teddyBears, minions, trucks;

    cin >> excursionPrice >> puzzles >> dolls >> teddyBears >> minions >> trucks;

    double totalToysPrice = puzzles * 2.60 + dolls * 3 + teddyBears * 4.10 + minions * 8.20 + trucks * 2;
    int totalToysCount = puzzles + dolls + teddyBears + minions + trucks;

    if (totalToysCount >= 50) {
        totalToysPrice -= totalToysPrice * 0.25; // apply discount
    }

    double rent = totalToysPrice * 0.10;
    double profit = totalToysPrice - rent;
    double remainingMoney = profit - excursionPrice;

    cout << fixed << setprecision(2);

    if (remainingMoney >= 0) {
        cout << "Yes! " << remainingMoney << " lv left." << endl;
    }
    else {
        cout << "Not enough money! " << abs(remainingMoney) << " lv needed." << endl;
    }

    return 0;
}
