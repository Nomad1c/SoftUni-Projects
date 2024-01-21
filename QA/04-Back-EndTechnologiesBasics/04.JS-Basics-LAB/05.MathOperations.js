function calculator(a, b, op){
    if (op == '+'){
        console.log(a + b)
    }
    else if (op == '-'){
        console.log(a - b)
    }
    else if (op == '*'){
        console.log(a * b)
    }
    else if (op == '/'){
        console.log(a / b)
    }
    else if (op == '%'){
        console.log(a % b)
    }
    else if (op == '**'){
        console.log(a ** b)
    }
}

calculator(10, 2, '+')