function solve (input) {
    let players = {};
 
    for (line of input) {
        let player = line.split(': ')[0];
 
        if (players[player] === undefined) {
             
             players[player] = [];
             for (el of line.split(': ')[1].split(', ')) {
                if (!players[player].includes(el)) {
                    players[player].push(el);
                }
             }
 
        } else {
           
            for (el of line.split(': ')[1].split(', ')) {
                if (!players[player].includes(el)) {
                    players[player].push(el);
                }
            }
        }
 
    }
 
    function calcPlayersPower(pl) {
        let points = 0;
        pl.forEach(card => {
            points += calcCard(card);
        });
        return points;
    }
 
    function calcCard(somecard) {
        let card = somecard.split('');
        let power = 0;
        let powerType = {
            P: {
                J: 11,
                Q: 12,
                K: 13,
                A: 14,
            },
 
            T: {
                S: 4,
                H: 3,
                D: 2,
                C: 1,
            }
        };
 
        if (card.length > 2) {
            let boq = card.pop();
            let twoToTuz = Number(card.join(''));
            power += twoToTuz * powerType.T[boq];
 
        } else if (Number(card[0]) === Number(card[0])) {
            let boq = card.pop();
            let twoToTuz = Number(card);
            power += twoToTuz * powerType.T[boq];
 
        } else {
            let boq = card.pop();
            let twoToTuz = card;
            power += powerType.P[twoToTuz] * powerType.T[boq];
        }
 
        return power;
    }
 
    for (player in players) {
        console.log(`${player}: ${calcPlayersPower(players[player])}`);
    }
}