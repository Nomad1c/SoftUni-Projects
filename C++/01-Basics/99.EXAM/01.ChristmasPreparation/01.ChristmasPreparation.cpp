
#include <iostream>
#include <iomanip>

using namespace std;

int main() {
	int rollsOfPaper, rollsOfCloth;
	double litersOfGlue, discount;

	cin >> rollsOfPaper >> rollsOfCloth >> litersOfGlue >> discount;

	double priceOfPaper = rollsOfPaper * 5.80;
	double priceOfCloth = rollsOfCloth * 7.20;
	double priceOfGlue = litersOfGlue * 1.20;
	double totalCost = priceOfPaper + priceOfCloth + priceOfGlue;

	double discountAmount = totalCost * (discount / 100.0);

	double finalCost = totalCost - discountAmount;

	cout << fixed << setprecision(3) << finalCost << endl;

	return 0;
}