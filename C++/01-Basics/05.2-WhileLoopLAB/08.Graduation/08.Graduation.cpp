#include <iostream>
#include <iomanip>
using namespace std;

int main() {
    string studentName;
    cin >> studentName;

    int currentGrade;
    double totalGrades = 0.0;
    int currentClass = 1;

    while (currentClass <= 12) {
        cin >> currentGrade;

        if (currentGrade < 4) {
            cout << studentName << " has been excluded at " << currentClass << " grade" << endl;
            return 0;
        }

        totalGrades += currentGrade;

        if (currentClass == 12) {
            double averageGrade = totalGrades / 12;
            cout << studentName << "Gosho graduated. Average grade: " << fixed << setprecision(2) << averageGrade << endl;
            return 0;
        }

        currentClass++;
    }

    return 0;
}
