function checkEvenOdd(number) {
    let num = Number(number);

    if (num % 2 === 0) {
        console.log("even");
    } else {
        console.log("odd");
    }
}

checkEvenOdd("2");
checkEvenOdd("3");
checkEvenOdd("25");
checkEvenOdd("1024");
