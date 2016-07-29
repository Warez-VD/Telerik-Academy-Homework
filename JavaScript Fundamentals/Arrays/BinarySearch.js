"use strict";

function solve(args) {
    var seq = args[0].split('\n'),
        N = +seq[0],
        arr = [],
        X = +seq[seq.length - 1],
        i,
        arrLength,
        middle,
        index = -1;

     for(i = 0; i < N; i += 1) {
         arr[i] = +seq[i + 1];
     }

     arrLength = arr.length - 1;
     for(i = 0; i <= arrLength;) {
         middle = Math.floor((i + arrLength) / 2);
         if (arr[middle] === X) {
             index = middle;
             break;
         }
         else if (arr[middle] > X) {
             arrLength = middle - 1;
         }
         else if (arr[middle] < X) {
             i = middle + 1;
         }
     }

     console.log(index);  
}

solve(['10\n1\n2\n4\n8\n16\n31\n32\n64\n77\n99\n32']);
	