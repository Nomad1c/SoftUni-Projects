#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    int chickenMenus, fishMenus, vegetarianMenus;

    cin >> chickenMenus >> fishMenus >> vegetarianMenus;

    double chickenMenuPrice = chickenMenus * 10.35;
    double fishMenuPrice = fishMenus * 12.40;
    double vegetarianMenuPrice = vegetarianMenus * 8.15;

    double totalMenuPrice = chickenMenuPrice + fishMenuPrice + vegetarianMenuPrice;
    double dessertPrice = 0.20 * totalMenuPrice;
    double deliveryPrice = 2.50;

    double totalPrice = totalMenuPrice + dessertPrice + deliveryPrice;

    cout << totalPrice << endl;

    return 0;
}