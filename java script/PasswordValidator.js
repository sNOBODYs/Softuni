function passwordValidator(input){
  let pass = input;
  let digitsCounter = 0;
  let isLengthValid = true;
  let twoDigits = false;
  let lettersAndDigitsOnly = true;

  if (pass.length < 6 || pass.length > 10 ) {
    isLengthValid = false;
    console.log("Password must be between 6 and 10 characters");
  }

  for (const index of pass) {
    let symbol = index.charCodeAt(0);

    let numsCondition = (
      symbol >= 48 && symbol <= 57 ) 
      
    let lettersCondition = (
      (symbol >= 65 && symbol <= 95) ||
      (symbol >= 97 && symbol <= 122) );

    if (numsCondition || lettersCondition) {

      if (numsCondition) {
        digitsCounter++;
        if (digitsCounter > 1)
          twoDigits = true
      }

    } else
      lettersAndDigitsOnly = false;
  }

  if (!lettersAndDigitsOnly) {
    console.log("Password must consist only of letters and digits");
  }

  if (!twoDigits) {
    console.log("Password must have at least 2 digits");
  }

  if (isLengthValid && twoDigits && lettersAndDigitsOnly) {
    console.log("Password is valid");
  }

}
passwordValidator('logIn')
passwordValidator('MyPass123')
passwordValidator('Pa$s$s')