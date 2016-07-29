'use strict';

function solve(lines) {
    let searched = lines[0];
    let text = lines[1];

    let regex = new RegExp(searched, 'gi');
    let result = text.match(regex);
    console.log(result.length);
}

