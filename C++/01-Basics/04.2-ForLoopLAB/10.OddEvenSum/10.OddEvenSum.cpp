#include <iostream>
#include <cmath>

using namespace std;

int main() {
    int n;
    cin >> n;

    int evenSum = 0;
    int oddSum = 0;

    for (int i = 1; i <= n; ++i) {
        int number;
        cin >> number;

        if (i % 2 == 0) {
            evenSum += number;
        }
        else {
            oddSum += number;
        }
    }

    if (evenSum == oddSum) {
        cout << "Yes" << endl;
        cout << "Sum = " << evenSum << endl;
    }
    else {
        int diff = abs(evenSum - oddSum);
        cout << "No" << endl;
        cout << "Diff = " << diff << endl;
    }

    return 0;
}
