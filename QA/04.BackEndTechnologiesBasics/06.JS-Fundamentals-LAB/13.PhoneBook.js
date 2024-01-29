function phoneBook(input) {
    const phoneBookMap = new Map();

    for (let entry of input) {
        const [name, number] = entry.split(' ');

        phoneBookMap.set(name, number);
    }

    for (let [name, number] of phoneBookMap) {
        console.log(`${name} -> ${number}`);
    }
}

const input1 = ['Tim 0834212554', 'Peter 0877547887', 'Bill 0896543112', 'Tim 0876566344'];
phoneBook(input1);

const input2 = ['George 0552554', 'Peter 087587', 'George 0453112', 'Bill 0845344'];
phoneBook(input2);
