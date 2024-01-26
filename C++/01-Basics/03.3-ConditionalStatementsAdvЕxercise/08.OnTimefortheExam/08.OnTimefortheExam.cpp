#include <iostream>
#include <iomanip>

using namespace std;

int main() {
    int examHour, examMinute, arrivalHour, arrivalMinute;
    cin >> examHour >> examMinute >> arrivalHour >> arrivalMinute;

    int examTimeInMinutes = examHour * 60 + examMinute;
    int arrivalTimeInMinutes = arrivalHour * 60 + arrivalMinute;

    if (arrivalTimeInMinutes > examTimeInMinutes) {
        cout << "Late" << endl;
        int delay = arrivalTimeInMinutes - examTimeInMinutes;
        if (delay >= 60) {
            int hours = delay / 60;
            int minutes = delay % 60;
            cout << hours << ":" << setw(2) << setfill('0') << minutes << " hours after the start" << endl;
        }
        else {
            cout << delay << " minutes after the start" << endl;
        }
    }
    else if (arrivalTimeInMinutes >= examTimeInMinutes - 30) {
        cout << "On time" << endl;
        if (arrivalTimeInMinutes != examTimeInMinutes) {
            int minutesBeforeStart = examTimeInMinutes - arrivalTimeInMinutes;
            cout << minutesBeforeStart << " minutes before the start" << endl;
        }
    }
    else {
        cout << "Early" << endl;
        int early = examTimeInMinutes - arrivalTimeInMinutes;
        if (early >= 60) {
            int hours = early / 60;
            int minutes = early % 60;
            cout << hours << ":" << setw(2) << setfill('0') << minutes << " hours before the start" << endl;
        }
        else {
            cout << early << " minutes before the start" << endl;
        }
    }

    return 0;
}
