#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    double budget, clothingPrice;
    int actors;

    cin >> budget >> actors >> clothingPrice;

    double decorPrice = budget * 0.10;
    double totalClothingPrice = actors * clothingPrice;

    if (actors > 150) {
        totalClothingPrice -= totalClothingPrice * 0.10;
    }

    double totalFilmPrice = decorPrice + totalClothingPrice;

    cout << fixed << setprecision(2);

    if (totalFilmPrice <= budget) {
        cout << "Action!" << endl;
        cout << "Wingard starts filming with " << budget - totalFilmPrice << " leva left." << endl;
    }
    else {
        cout << "Not enough money!" << endl;
        cout << "Wingard needs " << totalFilmPrice - budget << " leva more." << endl;
    }

    return 0;
}
