function solve (operand1, operand2, operation) {
    'use strict';

    let result = 0;

    switch (operation) {
        case '+':
            result = operand1 + operand2;
            break;

        case '-':
            result = operand1 - operand2;
            break;
        case '*':
            result = operand1 * operand2;
            break;
        case '/':
            result = operand1 / operand2;
            break;
        case '%':
            result = operand1 % operand2;
            break;
        case '**':
            result = operand1 ** operand2;
            break;                  
    }
    console.log(result);
}

solve(1,2,"+")