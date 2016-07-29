function solve(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2];

    if (a >= b && a >= c && b >= c) {
        console.log(a + ' ' + b + ' ' + c);
    }
    else if (a >= b && a >= c && c >= b) {
        console.log(a + ' ' + c + ' ' + b);
    }
    else if (b >= a && b >= c && a >= c) {
        console.log(b + ' ' + a + ' ' + c);
    }
    else if (b >= a && b >= c && c >= a) {
        console.log(b + ' ' + c + ' ' + a);
    }
    else if (c >= a && c >= b && a >= b) {
        console.log(c + ' ' + a + ' ' + b);
    }
    else if (c >= a && c >= b && b >= a) {
        console.log(c + ' ' + b + ' ' + a);
    }
}