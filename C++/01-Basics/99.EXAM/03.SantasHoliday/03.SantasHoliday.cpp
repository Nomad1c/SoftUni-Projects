#include <iostream>
#include <string>
#include <iomanip>
#include <limits>  // Include the header for numeric_limits
#include <algorithm>  // Include the header for max

using namespace std;

int main()
{
    int days;
    string room;
    string review;
    double total = 0.0;

    cin >> days;
    if (days > 1)
    {
        days--;
    }

    cin.ignore(numeric_limits<streamsize>::max(), '\n'); // Clear buffer
    getline(cin, room);

    if (room == "room for one person")
    {
        total = days * 18.0;
    }
    else if (room == "apartment")
    {
        if (days < 10)
        {
            total = (days * 25.0) * 0.7;
        }
        else if (days >= 10 && days <= 15)
        {
            total = (days * 25.0) * 0.65;
        }
        else if (days > 15)
        {
            total = (days * 25.0) * 0.5;
        }
    }
    else if (room == "president apartment")
    {
        if (days < 10)
        {
            total = (days * 35.0) * 0.9;
        }
        else if (days >= 10 && days <= 15)
        {
            total = (days * 35.0) * 0.85;
        }
        else if (days > 15)
        {
            total = (days * 35.0) * 0.8;
        }
    }

    cin >> review;

    if (review == "positive")
    {
        total *= 1.25;
    }
    else if (review == "negative")
    {
        total *= 0.9;
    }

    cout << fixed << setprecision(2) << total << endl;

    return 0;
}
