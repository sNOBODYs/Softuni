function arrayRotation(arr,number){
while(number != 0)
{
    let shifted = arr.shift()
    arr.push(shifted);
    number = number - 1;
}
for(let items in arr)
{
    comsole.log(items);
}
}

arrayRotation([51, 47, 32, 61, 21], 2)