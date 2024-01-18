function food (data) {
    let dog = data[0] * 2.5
    let cat = data[1] * 4
    let res = dog + cat
    console.log(`${res} lv.`)
}
food([5, 4])