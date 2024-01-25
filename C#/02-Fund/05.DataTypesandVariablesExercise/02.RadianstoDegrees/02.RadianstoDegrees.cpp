#include <iostream>
#include <cmath>

using namespace std;

int main() {
    const double pi = 3.14;
    double rad, deg;

    cin >> rad;

    deg = rad * 180 / pi;
    deg = round(deg);

    cout << deg << endl;

    return 0;
}
