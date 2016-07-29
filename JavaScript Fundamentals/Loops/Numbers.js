function solve(args) {
    var N = +args[0],
        output = '';

    for(var i = 1; i <= N; i += 1) {
        output += i + ' ';
    }

    console.log(output);
}