#include <iostream>
#include <iomanip>
#include <map>

using namespace std;

int main() {
    map<string, map<string, double>> prices = {
        {"Sofia", {{"coffee", 0.50}, {"water", 0.80}, {"beer", 1.20}, {"sweets", 1.45}, {"peanuts", 1.60}}},
        {"Plovdiv", {{"coffee", 0.40}, {"water", 0.70}, {"beer", 1.15}, {"sweets", 1.30}, {"peanuts", 1.50}}},
        {"Varna", {{"coffee", 0.45}, {"water", 0.70}, {"beer", 1.10}, {"sweets", 1.35}, {"peanuts", 1.55}}}
    };

    string product, city;
    double quantity;

    cin >> product >> city >> quantity;

    if (prices.find(city) == prices.end() || prices[city].find(product) == prices[city].end()) {
        cout << "Invalid product or city!" << endl;
        return 1;
    }

    double totalPrice = prices[city][product] * quantity;

    cout << totalPrice << endl;

    return 0;
}
