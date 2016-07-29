function solve(args) {
    var number = +args[0];

    var thirdDigit = ((number / 100) | 0) % 10;
    if (thirdDigit === 7) {
        console.log('true');
    }
    else {
        console.log('false ' + thirdDigit);
    }

}