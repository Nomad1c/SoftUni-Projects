function shoppingBudget(budget, videoCardsCount, processorsCount, ramCount) {
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

shoppingBudget("900", "2", "1", "3"); // You have 198.75 leva left!
shoppingBudget("920.45", "3", "1", "1"); // Not enough money! You need 3.92 leva more!
