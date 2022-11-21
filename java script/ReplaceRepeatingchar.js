function replaceRepeatingChars(word) {
    word = word.split('');
    for (let i = 0; i < word.length; i++) {
        let currLetter = word[i];
        let nextLetter = word[i + 1];
        if (currLetter == nextLetter) {
            word.splice(i, 1);
            i--;
        }
    }
    console.log(word.join(''));
}