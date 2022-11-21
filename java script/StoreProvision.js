function storeProvision(stocks, orders) {
    let obj = {};

    let stocksBeforeOrders = restock(stocks, obj);

    let stocksAfterOrders = restock(orders, stocksBeforeOrders);

    for (let product of Object.keys(stocksAfterOrders)) {
        console.log(`${product} -> ${stocksAfterOrders[product]}`);
    }
    function restock(arr, obj) {

        for (let i = 0; i < arr.length; i += 2) {

            let product = arr[i];
            let quantity = Number(arr[i + 1]);

            if (!obj.hasOwnProperty(product)) {
                obj[product] = quantity;
            } else {
                obj[product] += quantity;
            }
        }
        return obj;
    }
}
storeProvision([
'Chips', '5', 'CocaCola', '9', 'Bananas',
'14', 'Pasta', '4', 'Juice', '2'
],
[
'Flour', '44', 'Oil', '12', 'Pasta', '7',
'Tomatoes', '70', 'Bananas', '30'
])