function calculateOrderPrice(chickenMenus, fishMenus, vegetarianMenus) {
    const chickenMenuPrice = 10.35;
    const fishMenuPrice = 12.40;
    const vegetarianMenuPrice = 8.15;

    const chickenMenusTotal = chickenMenus * chickenMenuPrice;
    const fishMenusTotal = fishMenus * fishMenuPrice;
    const vegetarianMenusTotal = vegetarianMenus * vegetarianMenuPrice;

    const totalMenuPrice = chickenMenusTotal + fishMenusTotal + vegetarianMenusTotal;

    const dessertPrice = 0.2 * totalMenuPrice;
    const deliveryCost = 2.50;

    const totalOrderPrice = totalMenuPrice + dessertPrice + deliveryCost;

    const formattedTotalOrderPrice = totalOrderPrice.toFixed(2);

    console.log(formattedTotalOrderPrice);
}

calculateOrderPrice(2, 4, 3);
calculateOrderPrice(9, 2, 6);
