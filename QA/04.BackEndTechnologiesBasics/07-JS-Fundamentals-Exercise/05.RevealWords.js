function revealWords(words, template) {
    const wordsArray = words.split(', ');
    
    for (let word of wordsArray) {
        const maskedWord = '*'.repeat(word.length);
        template = template.replace(maskedWord, word);
    }

    console.log(template);
}

revealWords('great', 'softuni is ***** place for learning new programming languages');
revealWords('great, learning', 'softuni is ***** place for ******** new programming languages');
