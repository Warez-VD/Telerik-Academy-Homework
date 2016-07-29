"use strict";

function solve(args) {
    var arr = args[0].split('\n'),
        firstArray = arr[0],
        secondArray = arr[1];


        if (firstArray > secondArray)
        {
            console.log('>');
        }
        else if(firstArray < secondArray)
        {
            console.log('<');
        }
        else{
            console.log('=');            
        }
}