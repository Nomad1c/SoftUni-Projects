function deposits(amount, time, percent) {
    let monthlyInterest = (amount * percent) / (12 * 100);
    let sum = amount + time * monthlyInterest;
    sum = sum.toFixed(2);
    console.log(`${sum}`);
}

deposits(2350, 6, 7);