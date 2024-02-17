function calculateCalories(inputArray) {
    const [fatPercentage, proteinPercentage, carbohydratePercentage, totalCalories, waterPercentage] = inputArray;

    const fatGrams = (fatPercentage / 100) * totalCalories / 9;
    const proteinGrams = (proteinPercentage / 100) * totalCalories / 4;
    const carbohydrateGrams = (carbohydratePercentage / 100) * totalCalories / 4;

    const totalWeight = fatGrams + proteinGrams + carbohydrateGrams;

    const waterCalories = (waterPercentage / 100) * totalCalories;
    const caloriesPerGram = totalCalories / totalWeight;
    const caloriesPerGramWithoutWater = caloriesPerGram - (waterCalories / totalWeight);

    console.log(caloriesPerGramWithoutWater.toFixed(4));
}

const inputArray1 = [60, 25, 15, 2500, 60];
const inputArray2 = [40, 40, 20, 3000, 40];
const inputArray3 = [20, 60, 20, 1800, 50];

calculateCalories(inputArray1);
calculateCalories(inputArray2);
calculateCalories(inputArray3);
