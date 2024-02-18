#include <iostream>
#include <cmath>
#include <iomanip>
#include <limits>

using namespace std;

int main() {
    double allowancePerDay, profitPerDay, totalExpenses, giftPrice, total;

    cin >> allowancePerDay;
    cin >> profitPerDay;
    cin >> totalExpenses;
    cin >> giftPrice;

    total = 0;

    total = allowancePerDay * 5 + profitPerDay * 5 - totalExpenses;
    double difference = std::abs(total - giftPrice);

    if (total < giftPrice) {
        cout << "Insufficient money: " << std::fixed << std::setprecision(2) << difference
            << " BGN." << endl;
    }
    else {
        cout << "Profit: " << std::fixed << std::setprecision(2) << total
            << " BGN, the gift has been purchased." << endl;
    }

    return 0;
}
