"use strict";

function  solve(args) {
    var numbers = args[0].split(' ');

    function GetMax(firstNum, secondNum) {
    var fNum = +firstNum,
        secNum = + secondNum;

    if (fNum > secNum) {
        return fNum;
    }
    else {
        return secNum;
    }
}
    var biggestOfThree = GetMax(GetMax(numbers[0], numbers[1]),numbers[2]);
    console.log(biggestOfThree);
}