"use strict";

function solve(args) {
    var splitedArray = args[0].split('\n'),
        N = +splitedArray[0],
        numbers = splitedArray[1].split(' '),
        count = 0,
        i;

    for(i = 0; i < numbers.length; i += 1) {
        numbers[i] = +numbers[i];
    }

    for(i = 1; i < numbers.length - 1; i += 1) {
        if (numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1]) {
            count += 1;
        }
    }

    console.log(count);
}
