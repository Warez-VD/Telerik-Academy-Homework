"use strict";

function solve(args) {
    var seq = args[0].split('\n'),
        N = +seq[0],
        arr = [],
        temp,
        i,
        j;

     for(i = 0; i < N; i += 1) {
         arr[i] = +seq[i + 1];
     }

     for (i = 0; i < arr.length - 1; i += 1) {
         for (j = i + 1; j < arr.length; j += 1) {
             if (arr[j] < arr[i]) {
                  temp = arr[i];
                  arr[i] = arr[j];
                  arr[j] = temp;
             }
          }
      }

      console.log(arr.join('\n'));
}