function solve(args) {
    var N = +args[0],
    arr = [],
    i;

    for(i = 0; i < N; i += 1) {
        arr[i] = i * 5;
        console.log(arr[i]);
    }
}