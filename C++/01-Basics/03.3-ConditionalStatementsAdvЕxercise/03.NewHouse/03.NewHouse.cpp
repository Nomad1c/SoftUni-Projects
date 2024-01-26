#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

int main() {
    string flowerType;
    int flowerCount;
    int budget;
    cin >> flowerType >> flowerCount >> budget;

    double price = 0.0;

    if (flowerType == "Roses") {
        price = 5.00 * flowerCount;
        if (flowerCount > 80) {
            price *= 0.90;  // 10% discount
        }
    }
    else if (flowerType == "Dahlias") {
        price = 3.80 * flowerCount;
        if (flowerCount > 90) {
            price *= 0.85;  // 15% discount
        }
    }
    else if (flowerType == "Tulips") {
        price = 2.80 * flowerCount;
        if (flowerCount > 80) {
            price *= 0.85;  // 15% discount
        }
    }
    else if (flowerType == "Narcissus") {
        price = 3.00 * flowerCount;
        if (flowerCount < 120) {
            price *= 1.15;  // 15% more expensive
        }
    }
    else if (flowerType == "Gladiolus") {
        price = 2.50 * flowerCount;
        if (flowerCount < 80) {
            price *= 1.20;  // 20% more expensive
        }
    }

    double diff = abs(budget - price);

    if (budget >= price) {
        cout << fixed << setprecision(2) << "Hey, you have a great garden with " << flowerCount << " " << flowerType
            << " and " << diff << " leva left." << endl;
    }
    else {
        cout << fixed << setprecision(2) << "Not enough money, you need " << diff << " leva more." << endl;
    }

    return 0;
}
