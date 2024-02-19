#include <iostream>
#include <string>
#include <sstream>

using namespace std;

namespace HairSaloon {

    class Program {
    public:
        static void Main(const string& args) {
            // Set a reasonable default goal to avoid infinite loop if no args
            int goal = 100;

            // Extract goal from command-line arguments if provided
            if (!args.empty()) {
                try {
                    goal = stoi(args);
                }
                catch (const invalid_argument& e) {
                    cerr << "Invalid goal argument provided. Using default goal of 100." << endl;
                }
            }

            // Initialize variables
            string service = "";
            string type = "";
            int money = 0;

            // Main loop
            while (true) {
                // Clear previous inputs
                cin.clear();
                cin.ignore(numeric_limits<streamsize>::max(), '\n');

                // Prompt for service and type
                cout << "Enter service (haircut, color, or closed): ";
                getline(cin, service);

                // Exit if closed
                if (service == "closed") {
                    break;
                }

                cout << "Enter type (mens, ladies, kids, touch up, or full color): ";
                getline(cin, type);

                // Calculate earnings based on service and type
                int servicePrice = 0;
                if (service == "haircut") {
                    if (type == "mens") {
                        servicePrice = 15;
                    }
                    else if (type == "ladies") {
                        servicePrice = 20;
                    }
                    else if (type == "kids") {
                        servicePrice = 10;
                    }
                }
                else if (service == "color") {
                    if (type == "touch up") {
                        servicePrice = 20;
                    }
                    else if (type == "full color") {
                        servicePrice = 30;
                    }
                }
                else {
                    cout << "Invalid service or type. Please try again." << endl;
                    continue; // Skip to next iteration
                }

                // Update accumulated earnings
                money += servicePrice;

                // Display summary and check if goal reached
                cout << "Earned: " << servicePrice << "lv." << endl;
                int remaining = goal - money;
                if (remaining <= 0) {
                    cout << "Target reached!" << endl;
                    break;
                }
                else {
                    cout << remaining << "lv. more needed to reach target." << endl;
                }
            }

            // Display final earnings
            cout << "Total earned: " << money << "lv." << endl;
        }
    };
}

int main(int argc, const char* argv[]) {
    // Get command-line arguments
    string args;
    for (int i = 1; i < argc; i++) {
        if (i > 1) {
            args += " ";
        }
        args += argv[i];
    }

    // Call HairSaloon::Program::Main with any arguments
    HairSaloon::Program::Main(args);

    return 0;
}
