function calculateBasketballExpenses(data) {
    const basketballShoesPrice = data - (0.4 * data);
    const basketballOutfitPrice = basketballShoesPrice - (0.2 * basketballShoesPrice);
    const basketballBallPrice = 0.25 * basketballOutfitPrice;
    const basketballAccessoriesPrice = 0.2 * basketballBallPrice;

    const totalExpenses = data + basketballShoesPrice + basketballOutfitPrice +
        basketballBallPrice + basketballAccessoriesPrice;

    console.log(totalExpenses);
}

calculateBasketballExpenses(365);
calculateBasketballExpenses(550);
