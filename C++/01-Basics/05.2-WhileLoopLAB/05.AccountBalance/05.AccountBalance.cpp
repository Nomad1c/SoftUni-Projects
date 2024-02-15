#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    double balance = 0.0;
    double amount;

    while (true) {
        cin >> amount;

        if (amount < 0) {
            cout << "Invalid operation!" << endl;
            break;
        }

        if (amount == 0) {
            break;
        }

        cout << "Increase: " << fixed << setprecision(2) << amount << endl;
        balance += amount;
    }

    cout << "Total: " << fixed << setprecision(2) << balance << endl;

    return 0;
}
