#include <iostream>
#include <cmath>
#include <iomanip>

using namespace std;

int main() {
    double pi = 3.14159265359;

    string figure;
    cin >> figure;

    cout << fixed << setprecision(3);

    if (figure == "square") {
        double side;
        cin >> side;
        cout << side * side << endl;
    }
    else if (figure == "rectangle") {
        double width, height;
        cin >> width >> height;
        cout << width * height << endl;
    }
    else if (figure == "circle") {
        double radius;
        cin >> radius;
        cout << pi * radius * radius << endl;
    }
    else if (figure == "triangle") {
        double side, height;
        cin >> side >> height;
        cout << (side * height) / 2 << endl;
    }

    return 0;
}
