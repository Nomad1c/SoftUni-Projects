#include <iostream>
#include <string>

using namespace std;

int main() {
    string day;
    cin >> day;

    int price;
    if (day == "Monday" || day == "Tuesday" || day == "Friday") {
        price = 12;
    }
    else if (day == "Wednesday" || day == "Thursday") {
        price = 14;
    }
    else {
        price = 16;
    }

    cout << price << endl;

    return 0;
}
