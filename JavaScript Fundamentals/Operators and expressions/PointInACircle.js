function solve(args) {
    var x = +args[0],
        y = +args[1],
	   xCenter = 0,
        yCenter = 0,
    	   radius = 2;

    var newX = Math.pow(x - xCenter, 2);
    var newY = Math.pow(y - yCenter, 2);
    var distance = Math.sqrt(newX + newY);

    if (newX + newY <= Math.pow(radius, 2)) {
        console.log('yes ' + distance.toFixed(2));
    }
    else{
        console.log('no '+ distance.toFixed(2));
    }
}