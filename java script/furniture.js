function furniture (input){
let pattern = />>(?<type>[A-Za-z]+)<<(?<price>[\d\.]+)!(?<quantity>\d+)/g;
let output = [];
let sum = 0;

while ((result = pattern.exec(input)) !== null) {

    output.push(result.groups.type);
    let quantity = Number(result.groups.quantity);
    let price = Number(result.groups.price);
    let finalSum = quantity * price;
    sum += finalSum;
}
if (output.length > 0) {
    console.log('Bought furniture:');
    console.log(output.join('\n'));
    console.log(`Total money spend: ${sum.toFixed(2)}`);
} else {
    console.log('Bought furniture:');  
    console.log(`Total money spend: ${sum.toFixed(2)}`);
}
}

furniture([">>Sofa<<312.23!3",
">>TV<<300!5",
">Invalid<<!5",
"Purchase"])