"use strict";

function solve(args) {
    Array.prototype.remove = function (removeElement) {
    var result = [];

    for(var i = 0; i < this.length; i += 1) {
        if (this[i] !== removeElement) {
            result.push(this[i]);
        }
    }

    return result;
};
    var arr = args,
        remove = arr[0],
        result = [];

    result = arr.remove(remove);
    console.log(result.join('\n'));
}
