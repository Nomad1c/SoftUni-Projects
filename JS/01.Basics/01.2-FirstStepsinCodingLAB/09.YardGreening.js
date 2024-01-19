function greening (data) {
    price1 = data * 7.61
    discount = price1 * 0.18
    total = price1 - discount

    console.log(`The final price is: ${total} lv.`)
    console.log(`The discount is: ${discount} lv.`)
}
greening(550)