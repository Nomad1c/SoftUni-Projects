#include <iostream>

using namespace std;

int main() {
    int number;
    cin >> number;

    if (number != 0 && number >= -100 && number <= 100) {
        cout << "Yes" << endl;
    }
    else {
        cout << "No" << endl;
    }

    return 0;
}
