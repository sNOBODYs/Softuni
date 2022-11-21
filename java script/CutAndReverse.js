function cutAndReverse(words) {
    let firstHalf = words.slice(0, words.length / 2);
    let secondHalf = words.slice(words.length / 2);
    firstHalf = firstHalf.split('').reverse().join('');
    secondHalf = secondHalf.split('').reverse().join('');
    console.log(firstHalf);
    console.log(secondHalf);
}
cutAndReverse('tluciffiDsIsihTgnizamAoSsIsihT');