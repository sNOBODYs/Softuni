function something(input) {

    let words = input.split(' ')
       let  newArray = [];

    for (let a = 0; a < words.length; a++) {
        if (words[a].length > 3) {
            let word = words[a].split(''),
                spliceArr1 = word.slice(0, words[a].length / 2).reverse(),
                spliceArr2 = word.slice(words[a].length / 2, words[a].length).reverse(),result;
            if (word.length % 2) {
                def = spliceArr2[spliceArr2.length - 1];
                result = spliceArr1.join('') + def + spliceArr2.join('');
                result = result.substring(0, result.length - 1);
            } else {
                result = spliceArr1.join('') + spliceArr2.join('');
            }
            newArray.push(result);
        } else {
            newArray.push(words[a]);
        }
    }

    console.log(`${newArray.join(' ')}`);
}

something("taxis");
something("man i need a taxi up to ubud");