#include <iostream>
#include <climits>

using namespace std;

int main() {
    int n;
    cin >> n;

    int sum = 0;
    int maxElement = INT_MIN;

    for (int i = 0; i < n; ++i) {
        int num;
        cin >> num;

        sum += num;

        if (num > maxElement) {
            maxElement = num;
        }
    }

    for (int i = 0; i < n; ++i) {
        int currentNum = sum - maxElement;

        if (currentNum == maxElement) {
            cout << "Yes" << endl;
            cout << "Sum = " << currentNum << endl;
            return 0;
        }
    }

    int diff = abs(maxElement - (sum - maxElement));
    cout << "No" << endl;
    cout << "Diff = " << diff << endl;

    return 0;
}