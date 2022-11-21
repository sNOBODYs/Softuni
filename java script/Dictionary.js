function makeADictionary(array) {

    let dictionaryAsArr = [];

    for (let str of array) {
        let obj = JSON.parse(str);
        let key = Object.keys(obj).join('');
        let existingTerm = dictionaryAsArr.find(o => o.Term === key);

        if (existingTerm) {
            existingTerm.Defiinition = obj[key];
            continue;
        }
        let newObj = {};
        newObj.Term = key;
        newObj.Defiinition = obj[key];
        dictionaryAsArr.push(newObj);
    }
    dictionaryAsArr.sort((a, b) => a.Term.localeCompare(b.Term));
    for (let term of dictionaryAsArr) {
        console.log(`Term: ${term.Term} => Definition: ${term.Defiinition}`);
    }

}
makeADictionary([
    '{"Coffee":"A hot drink made from the roasted and ground seeds (coffee beans) of a tropical shrub."}',
    '{"Bus":"A large motor vehicle carrying passengers by road, typically one serving the public on a fixed route and for a fare."}',
    '{"Boiler":"A fuel-burning apparatus or container for heating water."}',
    '{"Tape":"A narrow strip of material, typically used to hold or fasten something."}',
    '{"Microphone":"An instrument for converting sound waves into electrical energy variations which may then be amplified, transmitted, or recorded."}']);
