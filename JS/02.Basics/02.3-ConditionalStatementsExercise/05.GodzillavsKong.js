function filmBudget(budget, numberOfActors, clothingPricePerActor) {
    budget = parseFloat(budget);
    numberOfActors = parseInt(numberOfActors);
    clothingPricePerActor = parseFloat(clothingPricePerActor);

    let decorCost = 0.1 * budget;
    let clothingCost = numberOfActors * clothingPricePerActor;

    if (numberOfActors > 150) {
        clothingCost *= 0.9;
    }

    let totalCost = decorCost + clothingCost;

    if (totalCost > budget) {
        let neededMoney = totalCost - budget;
        console.log("Not enough money!");
        console.log(`Wingard needs ${neededMoney.toFixed(2)} leva more.`);
    } else {
        let remainingMoney = budget - totalCost;
        console.log("Action!");
        console.log(`Wingard starts filming with ${remainingMoney.toFixed(2)} leva left.`);
    }
}

filmBudget("20000", "120", "55.5");
filmBudget("15437.62", "186", "57.99");
