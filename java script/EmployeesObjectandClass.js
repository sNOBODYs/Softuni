function employees(names) {

    for (let name of names) {
        let person = {
            fullName: name,
            number: name.length
        }
        console.log(`Name: ${person.fullName} -- Personal Number: ${person.number}`);
    }

}
employees([
    'Silas Butler',
    'Adnaan Buckley',
    'Juan Peterson',
    'Brendan Villarreal'
]
);    