function sum(number) {
    let numberString = number.toString();

    let sum = 0;

    for (let i = 0; i < numberString.length; i++) {
        sum += parseInt(numberString[i]);
    }

    console.log(sum);
}

sum(245678)
sum(97561)
sum(543)

