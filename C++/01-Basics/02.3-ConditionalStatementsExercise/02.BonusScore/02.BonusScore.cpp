#include <iostream>

using namespace std;

int main() {
    int initialPoints;
    cin >> initialPoints;

    double bonusPoints = 0.0;

    if (initialPoints <= 100) {
        bonusPoints = 5;
    }
    else if (initialPoints > 100 && initialPoints <= 1000) {
        bonusPoints = initialPoints * 0.2;
    }
    else if (initialPoints > 1000) {
        bonusPoints = initialPoints * 0.1;
    }

    if (initialPoints % 2 == 0) {
        bonusPoints += 1;
    }
    else if (initialPoints % 10 == 5) {
        bonusPoints += 2;
    }

    double totalPoints = initialPoints + bonusPoints;

    cout << bonusPoints << endl;
    cout << totalPoints << endl;

    return 0;
}
