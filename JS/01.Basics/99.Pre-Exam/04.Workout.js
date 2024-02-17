function training(input) {
    let days = Number(input.shift());
    let initialKilometers = Number(input.shift());
    let totalKilometers = initialKilometers;

    for (let i = 0; i < days; i++) {
        let percentageIncrease = Number(input.shift());
        initialKilometers += (percentageIncrease / 100) * initialKilometers;
        totalKilometers += initialKilometers;
    }

    if (totalKilometers >= 1000) {
        console.log(`You've done a great job running ${Math.floor(totalKilometers - 1000 + 1)} more kilometers!`);
    } else {
        console.log(`Sorry Mrs. Ivanova, you need to run ${Math.ceil(1000 - totalKilometers)} more kilometers`);
    }
}

training(["5", "30", "10", "15", "20", "5", "12"]);
training(["4", "100", "30", "50", "60", "80"]);
