#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    double usd, bgn;
    const double exchangeRate = 1.79549;

    cin >> usd;

    bgn = usd * exchangeRate;

    cout << fixed << setprecision(2);
    cout << bgn << endl;

    return 0;
}
