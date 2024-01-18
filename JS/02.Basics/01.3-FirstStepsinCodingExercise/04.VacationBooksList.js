function books (pages, pagesPerHour, days) {
    let totalTime = pages / pagesPerHour
    let HoursPerDay = totalTime / days
    console.log(HoursPerDay)
}
books(212, 20, 2)