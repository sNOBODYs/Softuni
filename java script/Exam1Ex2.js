function winner(deckSteve, deckJosh) {
    let cards={'2':2,'3':3,'4':4,'5':5,'6':6,'7':7,'8':8,'9':9,'T':10,'J':11,'Q':12,'K':13,'A':14}

    let stevePoints=0;
    let joshPoints=0;

    deckSteve=deckSteve.map(v=>cards[v])
    deckJosh=deckJosh.map(v=>cards[v])
    deckSteve.map((smt,smt2)=>smt>deckJosh[smt2]?stevePoints++:smt<deckJosh[smt2]?joshPoints++:null)

    if (stevePoints===joshPoints){
     console.log('Tie')
    }else if(stevePoints > joshPoints){
    console.log(`Steve wins ${stevePoints} to ${joshPoints}`);
    }else if(stevePoints < joshPoints){
        console.log(`Josh wins ${joshPoints} to ${stevePoints}`)
    }
  }

  winner(['A','7','8'], ['K','5','9'])