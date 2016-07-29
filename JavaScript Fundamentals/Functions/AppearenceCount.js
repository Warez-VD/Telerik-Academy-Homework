"use strict";

function solve(args) {
    var splitedInput = args[0].split('\n'),
    N = +splitedInput[0],
    numbers = splitedInput[1].split(' '),
    searchedNum = +splitedInput[2],
    count = 0,
    i;

    for(i = 0; i < numbers.length; i += 1) {
        numbers[i] = +numbers[i];
    }

    for(i = 0; i < N; i += 1) {
        if (searchedNum === numbers[i]) {
            count += 1;
        }
    }

    console.log(count);
}
