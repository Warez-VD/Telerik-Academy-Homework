function solve(args) {
    var N = +args[0];

    var output = '';

    for(var i = 1; i <= N; i += 1) {
        var counter = i;
        for(var j = 0; j < N; j += 1) {
            output += counter + ' '; 
            counter += 1;
        }
        console.log(output + ' ');
        output = '';
    }
}