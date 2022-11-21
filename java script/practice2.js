let array = [true, true, false, true];

solve(array);
function solve(input) {
    let count = 0;
    for(let i = 0; i < input.lenght; i++) {
        if(input[i] == true){
            count++;
        }
    }
    console.log(count);
}