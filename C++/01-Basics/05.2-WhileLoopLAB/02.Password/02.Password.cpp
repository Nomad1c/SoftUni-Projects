#include <iostream>
#include <string>

using namespace std;

int main() {
    string username, password, inputPassword;

    cin >> username;
    cin >> password;

    while (inputPassword != password) {
        cin >> inputPassword;
    }

    cout << "Welcome " << username << "!" << endl;

    return 0;
}
