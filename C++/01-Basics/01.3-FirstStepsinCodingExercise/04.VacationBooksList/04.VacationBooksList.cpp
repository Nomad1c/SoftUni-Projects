#include <iostream>

using namespace std;

int main() {
    int pagesPerBook, pagesPerHour, daysToRead;

    cin >> pagesPerBook >> pagesPerHour >> daysToRead;

    int totalHours = (pagesPerBook + pagesPerHour - 1) / pagesPerHour;
    int hoursPerDay = totalHours / daysToRead;

    cout << hoursPerDay << endl;

    return 0;
}
