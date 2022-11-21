function stringSubstring(word, phrase){
    phrase = phrase.split(' ')
    for (const element of phrase) {
        if (element.toLowerCase() === word.toLowerCase()) {
            console.log(word)
            break;
        }else{
            console.log(`${word} not found!`)
            break;
        }
    }
}
stringSubstring('javascript',
'JavaScript is the best programming language')