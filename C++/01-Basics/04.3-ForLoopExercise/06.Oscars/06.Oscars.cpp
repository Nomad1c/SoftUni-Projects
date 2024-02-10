#include <iostream>
#include <iomanip>
#include <string>

using namespace std;

int main() {
    string actorName;
    double academyPoints;
    int numReviewers;

    getline(cin, actorName);
    cin >> academyPoints;
    cin >> numReviewers;

    double totalPoints = academyPoints;

    for (int i = 0; i < numReviewers; ++i) {
        cin.ignore();
        string reviewerName;
        double reviewerPoints;

        getline(cin, reviewerName);
        cin >> reviewerPoints;

        totalPoints += (reviewerName.length() * reviewerPoints) / 2;

        if (totalPoints > 1250.5) {
            cout << "Congratulations, " << actorName << " got a nominee for leading role with "
                << fixed << setprecision(1) << totalPoints << "!" << endl;
            return 0;
        }
    }

    double neededPoints = 1250.5 - totalPoints;
    cout << "Sorry, " << actorName << " you need " << fixed << setprecision(1) << neededPoints << " more!" << endl;

    return 0;
}
