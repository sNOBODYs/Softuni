function Solve(arrayNum) {

    let totalSum = 0;
    
for(let i = 0; i < arrayNum.length; i++){
    totalSum += arrayNum[i];
}

console.log(totalSum);

let inverse = 0.0;

for(let i = 0; i < arrayNum.length; i++){
    inverse += 1.0 / arrayNum[i];
}

console.log(inverse);

let concatenates = "";

for(let i = 0; i < arrayNum.length; i++){
    concatenates += arrayNum[i];
}
console.log(concatenates);

}