function oddAndEvenSum(number){
  let evenSum = 0;
  let oddSum = 0;
  while(number > 0){
      let index = number % 10;
      if(index % 2 === 0){
        evenSum += index;
      } else {
        oddSum += index;
      }
      number = number.toString().substring(0, number.toString().length - 1);
  }
  console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`)
}
oddAndEvenSum(1000435)