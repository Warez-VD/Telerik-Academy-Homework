function solve(args) {
    var firstNum = +args[0],
        secondNum = +args[1];

    var temp;
    if (firstNum > secondNum) {
        temp = firstNum;
        firstNum = secondNum;
        secondNum = temp;
    }

    return firstNum + ' ' + secondNum;
}