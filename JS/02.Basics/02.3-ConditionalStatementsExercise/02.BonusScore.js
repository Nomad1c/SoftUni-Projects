function calculateBonusPoints(points) {
    let bonus = 0;

    if (points <= 100) {
        bonus += 5;
    } else if (points > 1000) {
        bonus += points * 0.1;
    } else {
        bonus += points * 0.2;
    }

    if (points % 2 === 0) {
        bonus += 1;
    }

    if (points % 10 === 5) {
        bonus += 2;
    }

    return `${bonus}\n${points + bonus}`;
}

console.log(calculateBonusPoints(20));
console.log(calculateBonusPoints(175));
console.log(calculateBonusPoints(2703));
console.log(calculateBonusPoints(15875));
