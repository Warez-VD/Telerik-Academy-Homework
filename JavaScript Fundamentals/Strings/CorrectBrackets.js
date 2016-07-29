'use strict';

function solve(lines) {

    let expression = lines[0];
    let countBracket = 0;
    let length = expression.length;
    for(let i = 0; i < length; i += 1) {
        if (expression[i] === '(') {
            countBracket += 1;
        } else if (expression[i] === ')') {
            countBracket -= 1;
        }
    }
    
    if (countBracket === 0) {
        console.log('Correct');
    } else {
        console.log('Incorrect');
    }
}
