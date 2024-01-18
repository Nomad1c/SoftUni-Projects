function suplies (pens, markers, litre, percent) {
    let sum = pens * 5.8 + markers * 7.2 + litre * 1.2
    let discount = sum * percent / 100
    let total = sum - discount

    console.log(total)
}
suplies(2, 3, 4, 25)
suplies(4, 2, 5, 13)