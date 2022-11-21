function meetings(input){
    let meetings = {};
    for(let line of input){
      let tokens = line.split(' ');
      let dayOfWeek = tokens[0];
      let name = tokens[1];
      if(meetings.hasOwnProperty(dayOfWeek)){
        console.log(`Conflict on ${dayOfWeek}!`);
      }else{
       meetings[dayOfWeek] = name;
       console.log(`Scheduled for ${dayOfWeek}`);
      }
    }
    for(let key in meetings){
        console.log(`${key} -> ${meetings[key]}`)
    }
}

meetings(['Monday Peter',

'Wednesday Bill',

'Monday Tim',

'Friday Tim'])