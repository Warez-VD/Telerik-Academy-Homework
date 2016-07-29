function solve(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2];

    var discriminant = Math.sqrt((Math.pow(b, 2)) - (4 * a * c));
    if (discriminant > 0) {
        var xOne = (b + discriminant) / (2 * a);
        var xTwo = (b - discriminant) / (2 * a);

        if (xOne < xTwo) {
            console.log('x1=' + xOne.toFixed(2) + '; x2=' + xTwo.toFixed(2));
        }
        else{
            console.log('x1=' + xTwo.toFixed(2) + '; x2=' + xOne.toFixed(2));
        }
    }
    else if (discriminant === 0) {
        var root = b / (2 * a);
        console.log('x1=x2=' + root.toFixed(2));
    }
    else {
        console.log('no real roots');
    }
}
