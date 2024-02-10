#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    int n;
    cin >> n;

    int countP1 = 0, countP2 = 0, countP3 = 0, countP4 = 0, countP5 = 0;

    for (int i = 0; i < n; ++i) {
        int num;
        cin >> num;

        if (num < 200) {
            countP1++;
        }
        else if (num >= 200 && num <= 399) {
            countP2++;
        }
        else if (num >= 400 && num <= 599) {
            countP3++;
        }
        else if (num >= 600 && num <= 799) {
            countP4++;
        }
        else {
            countP5++;
        }
    }

    double percentP1 = static_cast<double>(countP1) / n * 100;
    double percentP2 = static_cast<double>(countP2) / n * 100;
    double percentP3 = static_cast<double>(countP3) / n * 100;
    double percentP4 = static_cast<double>(countP4) / n * 100;
    double percentP5 = static_cast<double>(countP5) / n * 100;

    cout << fixed << setprecision(2) << percentP1 << "%" << endl;
    cout << fixed << setprecision(2) << percentP2 << "%" << endl;
    cout << fixed << setprecision(2) << percentP3 << "%" << endl;
    cout << fixed << setprecision(2) << percentP4 << "%" << endl;
    cout << fixed << setprecision(2) << percentP5 << "%" << endl;

    return 0;
}
