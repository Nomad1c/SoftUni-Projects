#include <iostream>

using namespace std;

int main() {
    int targetSum, currentSum = 0, num;
    cin >> targetSum;

    while (currentSum < targetSum) {
        cin >> num;
        currentSum += num;
    }

    cout << currentSum << endl;

    return 0;
}
