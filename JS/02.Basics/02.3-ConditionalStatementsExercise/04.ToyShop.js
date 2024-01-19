function toyShop(data) {
    
    let holidayPrice = Number(data[0])
    let puzzles = Number(data[1])
    let dolls = Number(data[2])
    let bears = Number(data[3])
    let minions = Number(data[4])
    let trucks = Number(data[5])

    
    let pricePuzzle = 2.6
    let priceDoll = 3
    let priceBear = 4.1
    let priceMinion = 8.2
    let priceTruck = 2

    if (puzzles + dolls + bears + minions + trucks >= 50) {
        let total = 0.9 * 0.75 * (puzzles * pricePuzzle + dolls * priceDoll + bears * priceBear + minions * priceMinion + trucks * priceTruck)
        
        if (total <= holidayPrice){
            let rest = Math.abs(total - holidayPrice)
            rest = rest.toFixed(2)
            console.log(`Not enough money! ${rest} lv needed.`)
        }

        else {
            let rest = Math.abs(total - holidayPrice)
            rest = rest.toFixed(2)
            console.log(`Yes! ${rest} lv left.`)
        }
    }

    else {
        let total = 0.9 * (puzzles * pricePuzzle + dolls * priceDoll + bears * priceBear + minions * priceMinion + trucks * priceTruck)

        if (total <= holidayPrice){
            let rest = Math.abs(total - holidayPrice)
            rest = rest.toFixed(2)
            console.log(`Not enough money! ${rest} lv needed.`)
        }

        else {
            let rest = Math.abs(total - holidayPrice)
            rest = rest.toFixed(2)
            console.log(`Yes! ${rest} lv left.`)
        }
    }
}

toyShop((["40.8",
"20",
"25",
"30",
"50",
"10"])
)
toyShop([320, 8, 2, 5, 5, 1])
