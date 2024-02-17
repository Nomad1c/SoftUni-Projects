function calculateProfit(input) {
    let partyCost = parseFloat(input[0]);
    let loveMessages = parseInt(input[1]);
    let waxRoses = parseInt(input[2]);
    let keychains = parseInt(input[3]);
    let caricatures = parseInt(input[4]);
    let luckySurprises = parseInt(input[5]);

    let loveMessagePrice = 0.60;
    let waxRosePrice = 7.20;
    let keychainPrice = 3.60;
    let caricaturePrice = 18.20;
    let luckySurprisePrice = 22.00;

    let totalEarnings = (loveMessages * loveMessagePrice) + (waxRoses * waxRosePrice) +
                        (keychains * keychainPrice) + (caricatures * caricaturePrice) +
                        (luckySurprises * luckySurprisePrice);

    let totalItems = loveMessages + waxRoses + keychains + caricatures + luckySurprises;
    let discount = totalItems >= 25 ? 0.35 * totalEarnings : 0;

    let finalPrice = totalEarnings - discount;

    let hostingExpenses = 0.10 * finalPrice;

    let profit = finalPrice - hostingExpenses;

    if (profit >= partyCost) {
        let remainingMoney = (profit - partyCost).toFixed(2);
        console.log(`Yes! ${remainingMoney} lv left.`);
    } else {
        let neededMoney = (partyCost - profit).toFixed(2);
        console.log(`Not enough money! ${neededMoney} lv needed.`);
    }
}

calculateProfit(["40.8", "20", "25", "30", "50", "10"]);
calculateProfit(["320", "8", "2", "5", "5", "1"]);
