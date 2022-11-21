function factorialDivision(first, second) {
    let factorial = (numberInput) => {
        let number = numberInput;
        let result = 1;

        for (let i = 1; i <= number; i++) {
            result *= i;
        }

        return result;
    }

    let division = (factorial(first) / factorial(second)).toFixed(2);

    console.log(division);
}
factorialDivision(5, 2)