function loadingBar(percentage){
    if (percentage === 100) {
        console.log("100% Complete!");
      } else {
    
        let num = percentage / 10;
    
        let complete = "%".repeat(num);
        let incomplete = ".".repeat(10 - num);
    
        console.log(`${percentage}% [${complete}${incomplete}]`);
        console.log("Still loading...");
      }
    }
    loadingBar(50);