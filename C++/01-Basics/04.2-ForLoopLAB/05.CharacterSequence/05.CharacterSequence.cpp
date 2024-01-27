#include <iostream>
#include <string>

using namespace std;

int main() {
    string text;
    getline(cin, text);

    for (char ch : text) {
        cout << ch << endl;
    }

    return 0;
}
