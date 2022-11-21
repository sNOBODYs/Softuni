function addressBook(input){
    let addressbook = {};
    for(let line of input){
     let tokens = line.split(':');
     let name = tokens[0];
     let address = tokens[1];
     addressbook[name] = address;
     }
     let sorted = Object.entries(addressbook);
     sorted.sort((a,b) => a[0].localeCompare(b[0]));
     for(let key of sorted){
        console.log(`${key[0]} -> ${key[1]}`);
     }
}
addressBook(['Tim:Doe Crossing',

'Bill:Nelson Place',

'Peter:Carlyle Ave',

'Bill:Ornery Rd'])