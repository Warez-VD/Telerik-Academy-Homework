"use strict";

function solve(args) {
    var arr = args[1].split(' ').map(Number),
        i;
    
    function GetMaxElement(startIndex, array) {
        var maxElement = array[startIndex],
            index = startIndex,
            elementAndIndex = [];

        for(var i = startIndex; i < array.length - 1; i += 1) {
            if (maxElement < array[i + 1]) {
                maxElement = array[i + 1];
                index = i + 1;
            }
        }
        elementAndIndex[0] = maxElement;
        elementAndIndex[1] = index;

        return elementAndIndex;
    }

    for(i = 0; i < arr.length; i += 1) {
        var temp = GetMaxElement(i, arr);
        var tempMax = temp[0];
        var tempIndex = temp[1];

        arr.splice(tempIndex, 1);
        arr.unshift(tempMax);
     }

    console.log(arr.join(' '));
}
