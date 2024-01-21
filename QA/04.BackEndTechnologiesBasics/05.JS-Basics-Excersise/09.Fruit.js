function calculateCost(fruit, weight, pricePerKilogram) {

    let money = (weight / 1000) * pricePerKilogram;

    console.log(`I need $${money.toFixed(2)} to buy ${(weight / 1000).toFixed(2)} kilograms ${fruit}.`);
}

calculateCost('orange', 2500, 1.80);
calculateCost('apple', 1563, 2.35);
