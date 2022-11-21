function employees (array){
  array.forEach(element => {
    console.log(`Name: ${element} -- Personal Number: ${element.length}`);
  });
}


employees([
    'Silas Butler',
    'Adnaan Buckley',
    'Juan Peterson',
    'Brendan Villarreal'
    ])