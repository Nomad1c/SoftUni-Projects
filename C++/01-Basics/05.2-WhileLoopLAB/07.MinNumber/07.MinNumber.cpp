#include <iostream>
#include <limits>

using namespace std;

int main() {
    int currentNumber;
    int minNumber = numeric_limits<int>::max();

    while (true) {
        cin >> currentNumber;

        if (cin.eof() || currentNumber == 0) {
            break;
        }

        if (currentNumber < minNumber) {
            minNumber = currentNumber;
        }
    }

    cout << minNumber << endl;

    return 0;
}
