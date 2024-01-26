#include <iostream>
#include <string>

using namespace std;

int main() {
    int degrees;
    string timeOfDay;
    cin >> degrees >> timeOfDay;

    string outfit, shoes;

    if (degrees >= 10 && degrees <= 18) {
        if (timeOfDay == "Morning") {
            outfit = "Sweatshirt";
            shoes = "Sneakers";
        }
        else if (timeOfDay == "Afternoon") {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
        else if (timeOfDay == "Evening") {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
    }
    else if (degrees > 18 && degrees <= 24) {
        if (timeOfDay == "Morning") {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
        else if (timeOfDay == "Afternoon") {
            outfit = "T-Shirt";
            shoes = "Sandals";
        }
        else if (timeOfDay == "Evening") {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
    }
    else if (degrees >= 25) {
        if (timeOfDay == "Morning" || timeOfDay == "Afternoon") {
            outfit = "T-Shirt";
            shoes = "Sandals";
        }
        else if (timeOfDay == "Evening") {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
    }

    cout << "It's " << degrees << " degrees, get your " << outfit << " and " << shoes << "." << endl;

    return 0;
}
