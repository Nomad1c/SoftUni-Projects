#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    int numGroups;
    int groupSize;
    int totalPeople = 0;
    int musalaCount = 0;
    int monblanCount = 0;
    int kilimanjaroCount = 0;
    int k2Count = 0;
    int everestCount = 0;

    cin >> numGroups;

    for (int i = 0; i < numGroups; ++i) {
        cin >> groupSize;
        totalPeople += groupSize;

        if (groupSize <= 5) {
            musalaCount += groupSize;
        }
        else if (groupSize <= 12) {
            monblanCount += groupSize;
        }
        else if (groupSize <= 25) {
            kilimanjaroCount += groupSize;
        }
        else if (groupSize <= 40) {
            k2Count += groupSize;
        }
        else {
            everestCount += groupSize;
        }
    }

    cout << fixed << setprecision(2) << (static_cast<double>(musalaCount) / totalPeople) * 100 << "%" << endl;
    cout << fixed << setprecision(2) << (static_cast<double>(monblanCount) / totalPeople) * 100 << "%" << endl;
    cout << fixed << setprecision(2) << (static_cast<double>(kilimanjaroCount) / totalPeople) * 100 << "%" << endl;
    cout << fixed << setprecision(2) << (static_cast<double>(k2Count) / totalPeople) * 100 << "%" << endl;
    cout << fixed << setprecision(2) << (static_cast<double>(everestCount) / totalPeople) * 100 << "%" << endl;

    return 0;
}
