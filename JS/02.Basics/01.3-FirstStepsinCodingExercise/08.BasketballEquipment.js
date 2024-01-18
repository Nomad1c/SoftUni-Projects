function calculateBasketballExpenses(yearlyTrainingFee) {
    const basketballShoesPrice = yearlyTrainingFee - (0.4 * yearlyTrainingFee);
    const basketballOutfitPrice = basketballShoesPrice - (0.2 * basketballShoesPrice);
    const basketballBallPrice = 0.25 * basketballOutfitPrice;
    const basketballAccessoriesPrice = 0.2 * basketballBallPrice;

    const totalExpenses = yearlyTrainingFee + basketballShoesPrice + basketballOutfitPrice +
        basketballBallPrice + basketballAccessoriesPrice;

    console.log(totalExpenses.toFixed(2));
}

calculateBasketballExpenses(365);
calculateBasketballExpenses(550);
