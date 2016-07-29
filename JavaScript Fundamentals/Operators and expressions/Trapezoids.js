function solve(args) {
    var a = +args[0],
        b = +args[1],
        h = +args[2];

    var area = h * ((a + b) / 2);
    console.log(area.toFixed(7));
}