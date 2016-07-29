function solve(args) {
    var number = +args[0];

    if (number < 2) {
        console.log('false');
    }
    else {
        var prime = true;
        for (var divider = 2; divider <= Math.sqrt(number); divider += 1) {
            if (number % divider === 0) {
                prime = false;
                break;
            }
        }
         console.log(prime);
    }
}