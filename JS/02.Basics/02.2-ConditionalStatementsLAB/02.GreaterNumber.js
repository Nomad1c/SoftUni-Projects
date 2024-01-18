function findGreaterNumber(firstNumber, secondNumber) {
    let num1 = Number(firstNumber);
    let num2 = Number(secondNumber);

    if (num1 > num2) {
        console.log(num1);
    } else {
        console.log(num2);
    }
}

findGreaterNumber("5", "3");
findGreaterNumber("3", "5");
findGreaterNumber("10", "10");
findGreaterNumber("-5", "5");
