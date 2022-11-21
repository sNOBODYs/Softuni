function towns(townsInfo) {
    for (let town of townsInfo) {
        let [townName, latitude, longitude] = town.split(' | ');
        let townAsObj = {
            town: townName,
            latitude: Number(latitude).toFixed(2),
            longitude: Number(longitude).toFixed(2)
        }
        console.log(townAsObj);

    }
}
towns(['Sofia | 42.696552 | 23.32601',
    'Beijing | 39.913818 | 116.363625']
);