function calculateMoney(input) {

    let dancersCount = parseInt(input[0]);
    let points = parseFloat(input[1]);
    let season = input[2];
    let location = input[3];
    let winnings = dancersCount * points;

    if (location === "Abroad") {
        winnings += 0.5 * winnings;
    }

    let expensesPercentage = 0;
    if (season === "summer" && location === "Bulgaria") {
        expensesPercentage = 0.05;
    } else if (season === "winter" && location === "Bulgaria") {
        expensesPercentage = 0.08;
    } else if (season === "summer" && location === "Abroad") {
        expensesPercentage = 0.10;
    } else if (season === "winter" && location === "Abroad") {
        expensesPercentage = 0.15;
    }

    let expenses = expensesPercentage * winnings;
    let remainingMoney = winnings - expenses;

    let charity = 0.75 * remainingMoney;
    let moneyPerDancer = (remainingMoney - charity) / dancersCount;

    charity = charity.toFixed(2);
    moneyPerDancer = moneyPerDancer.toFixed(2);

    console.log(`Charity - ${charity}`);
    console.log(`Money per dancer - ${moneyPerDancer}`);
}

calculateMoney(["1", "89.5", "summer", "Abroad"]);
calculateMoney(["25", "98", "winter", "Bulgaria"]);
