#include <iostream>

using namespace std;

int main() {
    int length, width, height;
    double percent;

    cin >> length >> width >> height >> percent;

    int volume = length * width * height;
    double liters = volume * 0.001;
    double filledLiters = liters * (1 - percent / 100);

    cout << fixed << filledLiters << endl;

    return 0;
}
