#include <iostream>
#include <string>

using namespace std;

int main() {
    string input;

    while (true) {
        cin >> input;

        if (input == "Stop") {
            break;
        }

        cout << input << endl;
    }

    return 0;
}
