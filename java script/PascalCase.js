function pascalCaseSplitter(text) {
    let textLower = text.toLowerCase();
    let result = text[0];

    for (let i = 1; i < text.length; i++) {

        if (text[i] == textLower[i]) {
            result += text[i];
        } else {
            result += ', ' + text[i];
        }
    }
    console.log(result);
}
pascalCaseSplitter('SplitMeIfYouCanHaHaYouCantOrYouCan')