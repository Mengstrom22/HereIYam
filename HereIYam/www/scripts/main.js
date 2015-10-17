﻿// Wait for Cordova to load
document.addEventListener("deviceready", onDeviceReady, false);

var watchID = null;

// Cordova is ready
function onDeviceReady() {
    // Get the most accurate position updates available on the
    // device.
    var options = { enableHighAccuracy: true };
    watchID = navigator.geolocation.watchPosition(onSuccess, onError, options);
    console.log('hi' + watchID);
}

// onSuccess Geolocation
function onSuccess(position) {
    var element = document.getElementById('geolocation');
    element.innerHTML = 'Latitude: ' + position.coords.latitude + '<br />' +
                    'Longitude: ' + position.coords.longitude + '<br />';
}

// clear the watch that was started earlier
function clearWatch() {
    if (watchID != null) {
        navigator.geolocation.clearWatch(watchID);
        watchID = null;

        var element = document.getElementById('geolocation');
        element.innerHTML = '';
    }
}

// onError Callback receives a PositionError object
function onError(error) {
    alert('code: ' + error.code + '\n' + 'message: ' + error.message + '\n');
}