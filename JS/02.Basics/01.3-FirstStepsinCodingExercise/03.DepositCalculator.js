function calculateDeposit(data) {
    const depositedAmount = parseFloat(data[0]);
    const depositTerm = parseInt(data[1]);
    const annualInterestRate = parseFloat(data[2]);

    const monthlyInterest = (depositedAmount * annualInterestRate) / (12 * 100);
    const totalAmount = depositedAmount + depositTerm * monthlyInterest;

    console.log(totalAmount.toFixed(2));
}

calculateDeposit(["200", "3", "5.7"]);
calculateDeposit(["2350", "6", "7"]);
