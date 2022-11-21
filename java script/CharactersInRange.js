function charactersInRange(firstChar,secondChar){
    let first = firstChar.charCodeAt(0);
    let second = secondChar.charCodeAt(0);
    let result = '';
    for (let i = first+1; i < second; i++)
    {
        result += String.fromCharCode(i)+ ' ';
    }
    console.log(result)
}

charactersInRange('a', 'd')
charactersInRange('#', ':')
