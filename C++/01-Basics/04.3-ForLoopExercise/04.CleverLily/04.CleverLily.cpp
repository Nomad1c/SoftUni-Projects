#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    int age;
    double washingMachinePrice, toyPrice;

    cin >> age;
    cin >> washingMachinePrice;
    cin >> toyPrice;

    double savedMoney = 0.0;

    for (int i = 1; i <= age; ++i) {
        if (i % 2 == 1) {
            savedMoney += toyPrice;
        }
        else {
            savedMoney += (((i / 2.0) * 10.00) - 1.0);
        }
    }

    if (savedMoney >= washingMachinePrice) {
        double remainingMoney = savedMoney - washingMachinePrice;
        printf("Yes! %.2f\n", remainingMoney);
    }
    else {
        double neededMoney = washingMachinePrice - savedMoney;
        printf("No! %.2f\n", neededMoney);
    }

    return 0;
}
