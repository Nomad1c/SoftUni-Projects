function suplies (data) {
    let sum = data[0] * 5.8 + data[1] * 7.2 + data[2] * 1.2
    let discount = sum * data[3] / 100
    let total = sum - discount

    console.log(total)
}
suplies([2, 3, 4, 25])
suplies([4, 2, 5, 13])