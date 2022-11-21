function addAndSubtract(first,second,third){
    let added = add(first,second)
    let subtracted = subtract(added,third)
function add (first,second){
  let sum = first + second;
  return(sum)
}
function subtract(added,third){
  let sum = added - third;
  return(sum)
}
return(subtracted)
}

console.log(addAndSubtract(23, 6, 10));
console.log(addAndSubtract(1, 17, 30));
console.log(addAndSubtract(42, 58, 100));