function solve(args) {
            var x = +args[0],
                y = +args[1];

            var circleX = 1;
            var circleY = 1;
            var radius = 1.5;
            var distance = Math.sqrt(Math.pow((x - circleX), 2) + Math.pow((y - circleY), 2));
            var isInCircle = distance <= radius;
            var isInRectangle = (x >= -1) && (x <= 5) && (y >= -1) && (y <= 1);

            if (isInCircle === true && isInRectangle === false)
            {
                console.log("inside circle outside rectangle");
            }
            else if (isInCircle === false && isInRectangle === true)
            {
                console.log("outside circle inside rectangle");
            }
            else if (isInCircle === true && isInRectangle === true)
            {
                console.log("inside circle inside rectangle");
            }
            else
            {
                console.log("outside circle outside rectangle");
            }
}