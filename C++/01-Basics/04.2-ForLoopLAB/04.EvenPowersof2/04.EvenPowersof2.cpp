#include <iostream>
#include <cmath>

using namespace std;

int main() {
    int n;
    cin >> n;

    for (int i = 0; i <= n; i += 2) {
        int num = pow(2, i);
        cout << num << endl;
    }

    return 0;
}
