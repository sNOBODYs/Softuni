////////// Ex 1
function sumDigits(num)
{
    let sum = 0;
    let string = num + '';
    for(let i = 0; i < string.length;i++)
    {
        sum = sum + Number(string.charAt(i));
    };
    console.log(sum);
}
sumDigits(245678);

/////////////Ex 2
function charsToString (char1,char2,char3)
{
    let string = char1 + char2 + char3;
    console.log(string);
}
charsToString('a','b','c')

/////////////Ex 3
function townInfo(town,population,area)
{
    let string = 'Town ' + town + ' has population of ' + population + ' and area ' + area + ' square km.';
    console.log(string);
}
townInfo('Sofia',1286383,492)

/////////////Ex 4
function convertMetersToKilometers(meters)
{
    let kilometers = meters / 1000;
    console.log(kilometers.toFixed(2));
}
convertMetersToKilometers(1852)

/////////////Ex 5
function poundsToDollars(pounds)
{
    let dolars = pounds * 1.31;
    console.log(dolars.toFixed(3))
}
poundsToDollars(80)
/////////////Ex 6
function reversedChars(a,b,c)
{
    let string = c +' '+ b +' '+ a;
    console.log(string);
}
reversedChars('A','B','C')
/////////////Ex 7
function lowerOrUpper(char)
{
if(char === char.toUpperCase()){
    console.log('upper-case')
}
if(char === char.toLowerCase())
{
    console.log('lower-case')
}
}
lowerOrUpper('L')
/////////////Ex 8
function calculator(number,operator,secondNumber)
{
    switch(operator) {
        case'+':
        let sum = number + secondNumber;
        console.log(sum.toFixed(2));
        break;
        case '-':
            let sum2 = number - secondNumber;
            console.log(sum2.toFixed(2))
            break;
        case '*':
            let sum3 = number * secondNumber;
            console.log(sum3.toFixed(2));
            break;
        case '/':
            let sum4 = number / secondNumber;
            console.log(sum4.tofixed(2));
            break;
        case '%':
            let sum5 = (number / secondNumber)*100;
            console.log(sum5.tofixed(2));
            break;
    }
    
}
calculator(5,'+',10)