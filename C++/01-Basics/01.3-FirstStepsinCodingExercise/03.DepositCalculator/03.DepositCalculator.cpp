#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    double depositedAmount, annualInterestRate;
    int depositPeriod;

    cin >> depositedAmount;
    cin >> depositPeriod;
    cin >> annualInterestRate;

    double monthlyInterestRate = annualInterestRate / 100 / 12;
    double accumulatedInterest = depositedAmount * monthlyInterestRate * depositPeriod;
    double totalAmount = depositedAmount + accumulatedInterest;

    cout << fixed << setprecision(2);
    cout << totalAmount << endl;

    return 0;
}
