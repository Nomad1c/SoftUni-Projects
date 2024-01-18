function greening (a) {
    price1 = a * 7.61
    price1 = price1.toFixed(2)
    discount = price1 * 0.18
    discount = discount.toFixed(2)
    total = price1 - discount
    total - total.toFixed(2)
    console.log(`The final price is: ${total} lv.`)
    console.log(`The discount is: ${discount} lv.`)
}
greening(550)