function movies(arr) {
    
    let movies=[];

    for (let element of arr) {
        if (element.includes('addMovie')) {

            let name=element.split('addMovie ')[1];
            movies.push({name});
            
        }else if (element.includes('directedBy')) {

            let [name,director]=element.split(' directedBy ');
            let movie=movies.find(j => j.name===name);

            if (movie) {
                movie.director=director;
            }
            
        }else if (element.includes('onDate')) {
            let [name,date]=element.split(' onDate ');
            let movie=movies.find(v => v.name===name);

            if (movie) {
                movie.date=date;
            }
            
        }
        
    }

    movies.forEach(element=>{
        if (element.name && element.date && element.director) {
            console.log(JSON.stringify(element));
        }
    })
}