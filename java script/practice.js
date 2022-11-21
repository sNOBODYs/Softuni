function solve (arr) {
    return arr.filter((x, i) => x % 2 == 0 && i % 2 == 0);
}