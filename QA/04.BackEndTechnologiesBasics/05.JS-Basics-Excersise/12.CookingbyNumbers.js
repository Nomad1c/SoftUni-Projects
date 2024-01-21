function cookingByNumbers(startingNumber, op1, op2, op3, op4, op5) {
    let number = Number(startingNumber);

    const operations = [op1, op2, op3, op4, op5];

    for (let i = 0; i < operations.length; i++) {
        let operation = operations[i];

        switch (operation) {
            case 'chop':
                number /= 2;
                break;
            case 'dice':
                number = Math.sqrt(number);
                break;
            case 'spice':
                number += 1;
                break;
            case 'bake':
                number *= 3;
                break;
            case 'fillet':
                number -= number * 0.2;
                break;
        }

        console.log(number);
    }
}

cookingByNumbers('32', 'chop', 'chop', 'chop', 'chop', 'chop');
cookingByNumbers('9', 'dice', 'spice', 'chop', 'bake', 'fillet');
