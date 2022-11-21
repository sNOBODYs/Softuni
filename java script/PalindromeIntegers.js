function palindromeIntegers(arrInput) {
    let numbers = arrInput;

 for (let i = 0; i < numbers.length; i++) {
let currentNum = numbers[i].toString();
        
      currentNum = currentNum.split('').reverse().join('')
            if (currentNum == numbers[i]) {
                console.log('true')
            }else{
             console.log('false');
            }
    }
}

palindromeIntegers([123,323,421,121]);
palindromeIntegers([32,2,232,1010]);