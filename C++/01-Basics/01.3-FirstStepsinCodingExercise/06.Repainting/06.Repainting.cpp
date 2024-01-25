#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    int nylonQuantity, paintQuantity, thinnerQuantity, hoursOfWork;

    cin >> nylonQuantity >> paintQuantity >> thinnerQuantity >> hoursOfWork;

    double nylonCost = (nylonQuantity + 2) * 1.50;
    double paintCost = (paintQuantity + paintQuantity * 0.10) * 14.50;
    double thinnerCost = thinnerQuantity * 5.00;
    double bagsCost = 0.40;

    double totalMaterialCost = nylonCost + paintCost + thinnerCost + bagsCost;
    double laborCost = (totalMaterialCost * 0.30) * hoursOfWork;
    double totalCost = totalMaterialCost + laborCost;

    cout << fixed << setprecision(2) << totalCost << endl;

    return 0;
}
