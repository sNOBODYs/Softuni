function softUniBarIncome(input) {

    let patternName = /%[A-Z][a-z]+%/g;

    let patternProduct = /<\w+>/g;

    let patternCount = /\|[0-9]+\|/g;

    let patternPrice = /[\d\.]+\$/g;

    let index = 0;

    let currEl = input[index];

    let sum = 0;

    while (currEl !== 'end of shift') {

        let name = currEl.match(patternName);
        currEl = currEl.replace(patternName, '');
        let product = currEl.match(patternProduct);
        currEl = currEl.replace(patternProduct, '');
        let count = currEl.match(patternCount, '');
        currEl = currEl.replace(patternCount, '');
        let price = currEl.match(patternPrice);

        if (name !== null && product !== null && count !== null && price !== null) {

            let splitName = name.shift().replace('%', '');
            splitName = splitName.replace('%', '');
            let client = splitName
            let splitProduct = product.shift().replace('<', '');
            splitProduct = splitProduct.replace('>', '');
            let currCount = count.shift().replace('|', '');
            currCount = currCount.replace('|', '');
            let currPrice = price.shift().replace('$', '');
            let result = Number(currCount) * Number(currPrice);
            sum += result;
            console.log(`${client}: ${splitProduct} - ${result.toFixed(2)}`);

        }

        index++;
        currEl = input[index];
    }

    if (sum > 0) {

        console.log(`Total income: ${sum.toFixed(2)}`);

    } else {

    }
}

softUniBarIncome(["%George%<Croissant>|2|10.3$",
"%Peter%<Gum>|1|1.3$",
"%Maria%<Cola>|1|2.4$",
"end of shift"])