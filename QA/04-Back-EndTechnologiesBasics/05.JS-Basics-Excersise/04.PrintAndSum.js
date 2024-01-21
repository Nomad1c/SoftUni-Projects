function nums(a, b) {
    let sum = 0;
    let result = [];

    for (let i = a; i <= b; i++) {
        result.push(i);
        sum += i;
    }

    console.log(result.join(' '));
    console.log(`Sum: ${sum}`)
}

nums(5, 10);
