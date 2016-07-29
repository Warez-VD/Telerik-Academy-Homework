"use strict";

function solve(args) {
    var seq = args[0].split('\n'),
        N = +seq[0],
        arr = [],
        countSeq = 1,
        maxSeq = 1,
        i;

    for(i = 0; i < N; i += 1) {
        arr[i] = +seq[i + 1];
    }

    for(i = 0; i < N - 1; i += 1) {
        if (arr[i] < arr[i + 1]) {
            countSeq += 1;
        }
        else{
            countSeq = 1;
        }

        if (countSeq > maxSeq) {
            maxSeq = countSeq;
        }
    }

    console.log(maxSeq);
}
