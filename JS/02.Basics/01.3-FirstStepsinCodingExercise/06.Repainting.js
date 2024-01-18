function calculateExpenses(nylonQuantity, paintQuantity, thinnerQuantity, hours) {
    // Prices per unit
    const nylonPricePerSqM = 1.50;
    const paintPricePerLitre = 14.50;
    const thinnerPricePerLitre = 5.00;
    const bagsPrice = 0.40;

    // Additional quantities
    const additionalNylon = 2;
    const additionalPaint = paintQuantity * 0.10;

    // Calculate material expenses
    const nylonExpense = (nylonQuantity + additionalNylon) * nylonPricePerSqM;
    const paintExpense = (paintQuantity + additionalPaint) * paintPricePerLitre;
    const thinnerExpense = thinnerQuantity * thinnerPricePerLitre;
    const bagsExpense = bagsPrice;

    const totalMaterialExpense = nylonExpense + paintExpense + thinnerExpense + bagsExpense;

    // Calculate labor expenses
    const laborExpense = (totalMaterialExpense * 0.30) * hours;

    // Calculate total expenses
    const totalExpense = totalMaterialExpense + laborExpense;

    // Format the result to have two decimal places
    const formattedTotalExpense = totalExpense.toFixed(2);

    console.log(formattedTotalExpense);
}

// Example usage:
calculateExpenses(10, 11, 4, 8);
calculateExpenses(5, 10, 10, 1);