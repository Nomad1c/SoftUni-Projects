function calculateBonusPoints(data) {
    let bonus = 0;
    let points = Number(data);

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

    console.log(`${bonus}`);
    console.log(`${points + bonus}`);
}

calculateBonusPoints((["20"]));
calculateBonusPoints(175);
calculateBonusPoints(2703);
calculateBonusPoints(15875);
