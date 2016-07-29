"use strict";

function solve(args) {
    var seq = args[0].split('\n'),
        N = +seq[0],
        arr = [],
        i,
        j,
        index = 0,
        maxCount = 0,
        count = 0;

     for(i = 0; i < N; i += 1) {
         arr[i] = +seq[i + 1];
     }

     for(i = 0; i < arr.length; i += 1) {
         for(j = 0; j < arr.length; j += 1) {
             if (arr[i] === arr[j]) {
                 count += 1;
             }
         }

         if (count > maxCount) {
             maxCount = count;
             index = i;
         }
         count = 0;
     }
     console.log(arr[index] + ' (' + maxCount + ' times)');    
}

