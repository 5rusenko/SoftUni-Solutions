function solve(start, end) {
    'use strict';
    
    let message = '';
    let sum = 0;

    for (let i = start; i <= end; i += 1) {
        sum += i;
        message += `${i} `;
    }

    console.log(message.trimEnd()); 
    console.log(`Sum: ${sum}`);
}


solve(5, 10);
