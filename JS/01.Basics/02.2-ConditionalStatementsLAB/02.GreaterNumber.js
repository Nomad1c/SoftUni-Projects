function findGreaterNumber(data) {
    let num1 = Number(data[0]);
    let num2 = Number(data[1]);

    if (num1 > num2) {
        console.log(num1);
    } else {
        console.log(num2);
    }
}

findGreaterNumber(["5", "3"]);
findGreaterNumber(["3", "5"]);
findGreaterNumber(["10", "10"]);
findGreaterNumber(["-5", "5"]);
