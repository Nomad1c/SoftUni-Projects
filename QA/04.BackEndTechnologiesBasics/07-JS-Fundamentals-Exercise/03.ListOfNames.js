function printSortedNames(names) {
    const sortedNames = names.sort();
    
    for (let i = 0; i < sortedNames.length; i++) {
        console.log(`${i + 1}.${sortedNames[i]}`);
    }
}

printSortedNames(["John", "Bob", "Christina", "Ema"]);
