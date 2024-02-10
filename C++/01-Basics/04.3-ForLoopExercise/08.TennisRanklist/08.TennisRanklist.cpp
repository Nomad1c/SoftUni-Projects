#include <iostream>
#include <iomanip>
#include <cmath>

using namespace std;

int main() {
    double average = 0;
    int winningGamesCounter = 0;
    int numberofTournaments = 0;
    int initialPoints = 0;
    int numberofGamesCounter = 0;
    double winGamesPercentage = 0;

    cin >> numberofTournaments;
    cin >> initialPoints;

    int totalPoints = initialPoints;

    for (int i = 1; i <= numberofTournaments; ++i) {
        string tournamentResult;
        numberofGamesCounter ++;
        cin >> tournamentResult;

        if (tournamentResult == "W") {
            totalPoints += 2000;
            winningGamesCounter ++;
        }
        else if (tournamentResult == "F") {
            totalPoints += 1200;
        }
        else if (tournamentResult == "SF") {
            totalPoints += 720;
        }
    }
    average = (totalPoints - initialPoints) / numberofGamesCounter;
    winGamesPercentage = 100.0 * winningGamesCounter / numberofGamesCounter;

    cout << "Final points: " << totalPoints << endl;
    cout << "Average points: " << average << endl;
    cout << fixed << setprecision(2) << winGamesPercentage << "%" << endl;

    return 0;
}
