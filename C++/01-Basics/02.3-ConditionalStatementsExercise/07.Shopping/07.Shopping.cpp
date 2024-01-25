#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    double budget, videoCards, processors, ram;
    cin >> budget >> videoCards >> processors >> ram;

    double videoCardsCost = videoCards * 250.0;
    double processorsCost = processors * (0.35 * videoCardsCost);
    double ramCost = ram * (0.10 * videoCardsCost);

    double totalCost = videoCardsCost + processorsCost + ramCost;

    if (videoCards > processors)
        totalCost *= 0.85;

    cout << fixed << setprecision(2);

    if (budget >= totalCost)
        cout << "You have " << budget - totalCost << " leva left!" << endl;
    else
        cout << "Not enough money! You need " << totalCost - budget << " leva more!" << endl;

    return 0;
}
