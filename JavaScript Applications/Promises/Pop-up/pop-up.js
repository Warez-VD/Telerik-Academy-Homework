(function() {
    var message,
        popUpPromise;

    function redirect() {
        setTimeout(function() {
            window.location.replace("https://google.bg");
        }, 5000);
    }

    function sendMessage(msg){
        var popUp = document.getElementById("pop-up");
        popUp.innerHTML = msg;
    }

    popUpPromise = new Promise(function(resolve, reject) {
        resolve();
    });

    message = "Going to redirect you to Google.com after 5 seconds";    
    popUpPromise
        .then(sendMessage(message))
        .then(redirect);
}());