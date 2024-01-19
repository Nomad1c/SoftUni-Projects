function calculateOrderPrice(data) {
    const chickenMenuPrice = 10.35;
    const fishMenuPrice = 12.40;
    const vegetarianMenuPrice = 8.15;

    const chickenMenusTotal = data[0] * chickenMenuPrice;
    const fishMenusTotal = data[1] * fishMenuPrice;
    const vegetarianMenusTotal = data[2] * vegetarianMenuPrice;

    const totalMenuPrice = chickenMenusTotal + fishMenusTotal + vegetarianMenusTotal;

    const dessertPrice = 0.2 * totalMenuPrice;
    const deliveryCost = 2.50;

    const totalOrderPrice = totalMenuPrice + dessertPrice + deliveryCost;

    const formattedTotalOrderPrice = totalOrderPrice

    console.log(formattedTotalOrderPrice);
}

calculateOrderPrice([2, 4, 3]);
calculateOrderPrice([9, 2, 6]);
