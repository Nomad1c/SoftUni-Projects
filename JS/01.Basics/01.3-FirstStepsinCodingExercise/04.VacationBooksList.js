function books (data) {
    let totalTime = data[0] / data[1]
    let HoursPerDay = totalTime / data[2]
    console.log(HoursPerDay)
}
books([212, 20, 2])