function commonElements(a,b){
let result = [];
while( a.length > 0 && b.length > 0 )
{  
   if      (a[0] < b[0] ){ a.shift(); }
   else if (a[0] > b[0] ){ b.shift(); }
   else /* they're equal */
   {
     result.push(a.shift());
     b.shift();
   }
}

for(let items in result){
    console.log(items);
}
}

commonElements(['Hey', 'hello', 2, 4, 'Peter', 'e'],
['Petar', 10, 'hey', 4, 'hello', '2'])
