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
    var element = document.getElementById('geolocation');
    element.innerHTML = 'Latitude: ' + position.coords.latitude + '<br />' +
                    'Longitude: ' + position.coords.longitude + '<br />';

    new Maplace({
        locations: [position.coords.latitude, position.coords.longitude],
        controls_on_map: false
    }).Load();
}

// onError Callback receives a PositionError object
function onError(error) {
    console.log('code: ' + error.code + '\n' + 'message: ' + error.message + '\n');
}