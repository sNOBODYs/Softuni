function perfectNumber(number) {
  
    let divSum = 1;

    for (let i = 2; i < number; i++) {

        if (number % i == 0) {
            divSum += i;
        }
    }

    if (divSum == number) {
        console.log('We have a perfect number!')
    }else{
        console.log("It's not so perfect.")
    }
}

perfectNumber(6);
perfectNumber(28);
perfectNumber(1236498);