function mult(a) {
    
    let sum = 0;
    
    for (let i = 1; i <= 10; i++) {
        sum = a * i
        console.log(`${a} X ${i} = ${sum}`)
    }
}

mult(6)