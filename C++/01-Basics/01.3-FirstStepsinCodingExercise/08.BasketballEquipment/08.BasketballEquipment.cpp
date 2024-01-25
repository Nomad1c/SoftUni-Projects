#include <iostream>

using namespace std;

int main() {
    int annualFee;

    cin >> annualFee;

    double basketballShoes = annualFee - 0.4 * annualFee;
    double basketballOutfit = basketballShoes - 0.2 * basketballShoes;
    double basketballBall = 0.25 * basketballOutfit;
    double basketballAccessories = 0.2 * basketballBall;

    double totalCost = annualFee + basketballShoes + basketballOutfit + basketballBall + basketballAccessories;

    cout << fixed << totalCost << endl;

    return 0;
}
