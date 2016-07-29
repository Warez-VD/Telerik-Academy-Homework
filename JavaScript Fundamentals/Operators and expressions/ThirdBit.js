function solve(args) {
    var number = +args[0];

    var bit = 3;
    var mask = 1 << bit;
    var result = (mask & number) >> bit;
    console.log(result);
}