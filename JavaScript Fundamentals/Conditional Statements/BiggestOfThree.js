function solve(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2];

    if (a > b && a > c) {
            return a;
    }
    else if (b > a && b > c) {
            return b;
    }
    else {
            return c;
    }
}