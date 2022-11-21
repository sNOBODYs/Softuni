function isItSet(cards) {
    let sol = [];
    let keys = Object.keys(cards[0]);
    for (let i = 0; i < 4; i++) {
      let set = new Set();
      for (let j = 0; j < cards.length; j++) {
        set.add(cards[j][keys[i]]);
      }
      sol.push(set.size);
    }
    console.log( sol.includes(2) ? false : true);
  }

  isItSet([
    { color: "green", number: 1, shade: "empty", shape: "squiggle" },
    { color: "green", number: 2, shade: "empty", shape: "diamond" },
    { color: "green", number: 3, shade: "empty", shape: "oval" }
  ])

  isItSet([
    { color: "purple", number: 1, shade: "full", shape: "oval" },
    { color: "green", number: 1, shade: "full", shape: "oval" },
    { color: "red", number: 1, shade: "full", shape: "oval" }
  ])

  isItSet([
    { color: "purple", number: 3, shade: "full", shape: "oval" },
    { color: "green", number: 1, shade: "full", shape: "oval" },
    { color: "red", number: 3, shade: "full", shape: "oval" }
  ])