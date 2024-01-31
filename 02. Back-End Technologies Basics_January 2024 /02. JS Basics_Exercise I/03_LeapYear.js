function solve(year) {
    'use strict';

    if (year % 4 === 0) {
        
        if (year % 100 !== 0 || (year % 100 === 0 && year % 400 === 0)) {
            console.log("yes");
        } else {
            console.log("no");
        }
    } else {
        console.log("no");
    }
}


solve(1900); 
