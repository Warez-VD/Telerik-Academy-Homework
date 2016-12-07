(function(){
    
    function getCoordinates(position){
        if(position.coords){
            return {
                lat: position.coords.latitude,
                long: position.coords.longitude
            };
        } else {
            throw {message: "No coordinates"};
        }
    }

    function createImage(coordinates) {
        var imgElement = document.createElement("img"),
            imgSrc = `http://maps.googleapis.com/maps/api/staticmap?center=${coordinates.lat},${coordinates.long}&zoom=16&size=500x500&sensor=false`;

        imgElement.setAttribute("src", imgSrc);
        var locationElement = document.getElementById("location");
        locationElement.appendChild(imgElement);
    }

    function handleError(msg){
        var error = document.createElement("h1");
        error.innerHTML = msg;
        document.body.appendChild(error);
    }

    var locationPromise = new Promise(function(resolve, reject) {
            navigator.geolocation.getCurrentPosition(
                function success(position) {
                    resolve(position);
                },
                function error(err) {
                    reject(err.message);
                });
        });

    locationPromise
        .then(getCoordinates)
        .then(createImage)
        .catch(handleError);
}());