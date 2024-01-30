function censorWord(text, word) {
    const regex = new RegExp(word, 'gi');
    const censoredText = text.replace(regex, match => '*'.repeat(match.length));
    console.log(censoredText);
}

censorWord('A small sentence with some words', 'small');
censorWord('Find the hidden word', 'hidden');
