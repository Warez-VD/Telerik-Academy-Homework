"use strict";

function solve(args) {
    var N = +args[0],
    i,
    biggestPrimeNum;

    for(i = N; i >= 2; i -= 1) {
        var prime = true;
        for(var divider = 2; divider <= Math.sqrt(i); divider += 1) {
            if (i % divider === 0) {
                prime = false;
                break;
            }
        }
        if (prime) {
            biggestPrimeNum = i;
            break;
        }
    }
    console.log(biggestPrimeNum);
}
