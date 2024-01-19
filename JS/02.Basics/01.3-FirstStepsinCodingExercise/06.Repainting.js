function calculateExpenses(data) {
    const nylonPricePerSqM = 1.50;
    const paintPricePerLitre = 14.50;
    const thinnerPricePerLitre = 5.00;
    const bagsPrice = 0.40;

    const additionalNylon = 2;
    const additionalPaint = data[1] * 0.10;

    const nylonExpense = (data[0] + additionalNylon) * nylonPricePerSqM;
    const paintExpense = (data[1] + additionalPaint) * paintPricePerLitre;
    const thinnerExpense = data[2] * thinnerPricePerLitre;
    const bagsExpense = bagsPrice;

    const totalMaterialExpense = nylonExpense + paintExpense + thinnerExpense + bagsExpense;

    const laborExpense = (totalMaterialExpense * 0.30) * data[3];

    const totalExpense = totalMaterialExpense + laborExpense;

    const formattedTotalExpense = totalExpense.toFixed(2);

    console.log(formattedTotalExpense);
}

calculateExpenses([10, 11, 4, 8]);
calculateExpenses([5, 10, 10, 1]);