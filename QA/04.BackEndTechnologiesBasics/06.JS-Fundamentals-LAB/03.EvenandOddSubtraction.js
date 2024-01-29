function evenOddSubtraction(arr) {
    let evenSum = 0;
    let oddSum = 0;

    for (let number of arr) {
        if (number % 2 === 0) {
            evenSum += number;
        } else {
            oddSum += number;
        }
    }

    const result = evenSum - oddSum;
    console.log(result);
}

evenOddSubtraction([1, 2, 3, 4, 5, 6]);
evenOddSubtraction([3, 5, 7, 9]);
evenOddSubtraction([2, 4, 6, 8, 10]);
