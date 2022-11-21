function inventory(info) {
    class Hero{
        constructor(name,level,items){
            this.name=name;
            this.level=level;
            this.items=items;
        }
    }

    let line;
    let item;
    let heroes=[];
    for (let element of info) {
        line=element.split(' / ');
        item=line[2].split(', ');
        item.sort((a,b)=>a.localeCompare(b));

        let hero=new Hero(line[0],Number(line[1]),item);
        heroes.push(hero);
    }

    heroes.sort((firstH, secondH) => firstH.level - secondH.level);

    for (let hero of heroes) {
        console.log(`Hero: ${hero.name}`);
        console.log(`level => ${hero.level}`);
        console.log(`items => ${hero.items.join(', ')}`);
        
    }
    
}
inventory([
    'Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara'
]);