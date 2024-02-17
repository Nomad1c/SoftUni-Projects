#include <iostream>
#include <string>

using namespace std;

int main() {
    string favoriteBook;
    getline(cin, favoriteBook);

    string currentBook;
    int checkedBooks = 0;

    while (true) {
        getline(cin, currentBook);

        if (currentBook == "No More Books") {
            cout << "The book you search is not here!" << endl;
            cout << "You checked " << checkedBooks << " books." << endl;
            break;
        }

        checkedBooks++;

        if (currentBook == favoriteBook) {
            cout << "You checked " << checkedBooks - 1 << " books and found it." << endl;
            break;
        }
    }

    return 0;
}
