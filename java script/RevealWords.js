function revealWords (words,phrase){
   words = words.split(', ')
   phrase = phrase.split(' ')

   for (let i = 0; i < phrase.length; i++) {
    let el = phrase[i];
    if (el.includes('*')) {
        let elCount = el.length;
        for (const word of words) {
            if (word.length  == elCount) {
                phrase[i] = word;
                break;
            }
        }
    }
   }
   console.log(phrase.join(' '))
}

revealWords('great',
'softuni is ***** place for learning new programming languages')
revealWords('great, learning',
'softuni is ***** place for ******** new programming languages')