function shoppingBudget(data) {
    
    let budget = Number(data[0]);
    let videoCardsCount = Number(data[1]);
    let processorsCount = Number(data[2]);
    let ramCount = Number(data[3]);

    
    let totalVCPrice = videoCardsCount * 250
    let totalPrPrice = processorsCount * (totalVCPrice * 0.35)
    let totalRAMPrice = ramCount * (totalVCPrice * 0.1)

    let total = totalPrPrice + totalRAMPrice + totalVCPrice

    if (videoCardsCount > processorsCount) {
        total = total * 0.85
    }

    if (budget >= total) {
        let rest = budget - total
        rest = rest.toFixed(2)
        console.log(`You have ${rest} leva left!`)
    }
    else {
        let rest = total - budget
        rest = rest.toFixed(2)
        console.log(`Not enough money! You need ${rest} leva more!`)
    }
}

shoppingBudget((["900",
"2",
"1",
"3"])
);
shoppingBudget((["920.45",
"3",
"1",
"1"])
);
