#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    double totalAmount = 0;
    double currentAmount;

    while (true) {
        cin >> currentAmount;

        if (currentAmount < 0) {
            cout << "Invalid operation!" << endl;
            break;
        }

        cout << fixed << setprecision(2) << "Increase: " << currentAmount << endl;
        totalAmount += currentAmount;
    }

    cout << "Total: " << fixed << setprecision(2) << totalAmount << endl;

    return 0;
}
