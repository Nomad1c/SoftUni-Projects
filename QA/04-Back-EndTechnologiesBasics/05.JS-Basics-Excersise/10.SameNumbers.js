function sameNumbersCheckAndSum(number) {
    let numberString = number.toString();

    let sum = 0;
    let allDigitsSame = true;

    for (let i = 0; i < numberString.length; i++) {
        let digit = parseInt(numberString[i]);
        sum += digit;

        if (digit !== parseInt(numberString[0])) {
            allDigitsSame = false;
        }
    }

    console.log(allDigitsSame);
    console.log(sum);
}

sameNumbersCheckAndSum(2222222);
sameNumbersCheckAndSum(1234);
