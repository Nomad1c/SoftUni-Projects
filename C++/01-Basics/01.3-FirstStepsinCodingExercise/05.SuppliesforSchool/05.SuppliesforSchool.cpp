#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    int numPacksPens, numPacksMarkers, litersCleaner, discountPercent;

    cin >> numPacksPens >> numPacksMarkers >> litersCleaner >> discountPercent;

    double pricePens = numPacksPens * 5.80;
    double priceMarkers = numPacksMarkers * 7.20;
    double priceCleaner = litersCleaner * 1.20;
    double totalPrice = pricePens + priceMarkers + priceCleaner;

    double discount = discountPercent / 100.0;
    double discountedPrice = totalPrice - (totalPrice * discount);

    cout << discountedPrice << endl;

    return 0;
}