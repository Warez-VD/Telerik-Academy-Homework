"use strict";

function solve(args) { 
    var result = args.map(Number);

    function buildPoint(a, b){
        return {
                x: a,
                y: b
        };
    }

    function buildLine(a, b) {
        return {
            firstPoint: a,
            secondPoint: b,
            dist: function() {
                return Math.sqrt(Math.pow((Math.abs(this.firstPoint.x - this.secondPoint.x)), 2)
                 + Math.pow((Math.abs(this.firstPoint.y - this.secondPoint.y)), 2));
            }
        };
    }

    function formATriangle(a, b, c) {
        if (a + b > c &&
            b + c > a &&
            a + c > b) {
            console.log('Triangle can be built');
        }
        else {
            console.log("Triangle can not be built");
        }
    }


    var lineOnePointOne = buildPoint(result[0], result[1]);
    var lineOnePointTwo = buildPoint(result[2], result[3]);
    var lineTwoPointOne = buildPoint(result[4], result[5]); 
    var lineTwoPointTwo = buildPoint(result[6], result[7]);
    var lineThreePointOne = buildPoint(result[8], result[9]); 
    var lineThreePointTwo = buildPoint(result[10], result[11]);
    var lineOne = buildLine(lineOnePointOne, lineOnePointTwo);
    var lineTwo = buildLine(lineTwoPointOne, lineTwoPointTwo);
    var lineThree = buildLine(lineThreePointOne, lineThreePointTwo);

    var a = lineOne.dist();
    var b = lineTwo.dist();
    var c = lineThree.dist();
    
    console.log(a.toFixed(2));
    console.log(b.toFixed(2));
    console.log(c.toFixed(2));
    formATriangle(a, b, c);
}
