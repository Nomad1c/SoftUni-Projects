#include <iostream>
#include <limits>

using namespace std;

int main() {
    int currentNumber;
    int maxNumber = numeric_limits<int>::min();

    while (true) {
        cin >> currentNumber;

        if (cin.eof() || currentNumber == 0) {
            break;
        }

        if (currentNumber > maxNumber) {
            maxNumber = currentNumber;
        }
    }

    cout << maxNumber << endl;

    return 0;
}
