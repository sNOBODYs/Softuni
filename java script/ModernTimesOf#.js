function modernTimes(text) {
    text = text.split(' ');

    for (let word of text) {

        if (word[0] == '#' && word.length > 1) {
            word = word.substring(1, word.length);
            if (isValidWord(word)) {
                console.log(word);
            }
        }
    }
    function isValidWord(word) {

        word = word.split('');
        let isValid = true;

        for (let letter of word) {

            if ((letter.charCodeAt(0) >= 65 && letter.charCodeAt(0) <= 90) ||
                (letter.charCodeAt(0) >= 97 && letter.charCodeAt(0) <= 122)) {
                continue;
            } else {
                isValid = false;
                break;
            }
        }
        return isValid;
    }
}
modernTimes('Nowadays everyone uses # to tag a #special word in #socialMedia')