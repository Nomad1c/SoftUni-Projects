function countOccurrences(text, word) {
    const regex = new RegExp(`\\b${word}\\b`, 'gi');
    const matches = text.match(regex) || [];
    const count = matches.length;
    console.log(count);
}

countOccurrences('This is a word and it also is a sentence', 'is');
countOccurrences('softuni is great place for learning new programming languages', 'softuni');
