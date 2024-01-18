function add15Minutes(hours, minutes) {
    hours = Number(hours);
    minutes = Number(minutes);

    let totalMinutes = hours * 60 + minutes + 15;

    let newHours = Math.floor(totalMinutes / 60) % 24;
    let newMinutes = totalMinutes % 60;

    return `${newHours}:${newMinutes.toString().padStart(2, '0')}`;
}

console.log(add15Minutes(1, 46));
console.log(add15Minutes(0, 1));
console.log(add15Minutes(23, 59));
console.log(add15Minutes(11, 8));
console.log(add15Minutes(12, 49));
