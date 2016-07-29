function solve(args) {

    var len = args.length;
    var sum = +args[0];
    var min = +args[0];
    var max = +args[0];
    var avg = 0;

    for (var i = 1; i < len; i += 1) {

        sum += +args[i];

        if (+args[i] <  min) {
            min = +args[i];
        }

        if (+args[i] > max) {
            max = +args[i];
        }
    }

    avg = sum / len;

    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + avg.toFixed(2));
}