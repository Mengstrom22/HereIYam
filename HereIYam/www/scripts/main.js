// Wait for Cordova to load
document.addEventListener("deviceready", onDeviceReady, false);

var watchID = null;

// Cordova is ready
function onDeviceReady() {
    // Get the most accurate position updates available on the
    // device.
    var options = { enableHighAccuracy: true };
    watchID = navigator.geolocation.watchPosition(onSuccess, onError, options);
}

// onSuccess Geolocation
function onSuccess(position) {
    var latitude = position.coords.latitude;
    var longitude = position.coords.longitude;

    var output = document.getElementById("out");

    output.innerHTML = '<p>Latitude is ' + latitude + '° <br>Longitude is ' + longitude + '°</p>';

    var img = new Image();
    img.src = "https://maps.googleapis.com/maps/api/staticmap?center=" + latitude + "," + longitude + "&zoom=13&size=300x300&sensor=false";

    output.appendChild(img);
}

// onError Callback receives a PositionError object
function onError(error) {
    console.log('code: ' + error.code + '\n' + 'message: ' + error.message + '\n');
}