// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkID=397704
// To debug code on page load in Ripple or on Android devices/emulators: launch your app, set breakpoints, 
// and then run "window.location.reload()" in the JavaScript Console.
(function () {
    "use strict";

    document.addEventListener('deviceready', onDeviceReady.bind(this), false);

    function onDeviceReady() {
        // Handle the Cordova pause and resume events
        document.addEventListener('pause', onPause.bind(this), false);
        document.addEventListener('resume', onResume.bind(this), false);

        // TODO: Cordova has been loaded. Perform any initialization that requires Cordova here.
        $('#calcConsumption').on('click', calcConsumption);

        var liter = localStorage.getItem('liter');
        var kilometer = localStorage.getItem('kilometer');

        if (liter) {
            $('#liter').val(liter);
            $('#kilometer').val(kilometer);
        }

        //navigator.accelerometer.watchAcceleration(function (acceleration) {
        //    if (acceleration.x > 0.5) {
        //        $('#liter').val("");
        //        $('#kilometer').val("");
        //    }
        //}, function () {
        //    alert('error');
        //}, { frequency: 1000 });


        // Start watching for shake gestures and call "onShake"
        // with a shake sensitivity of 40 (optional, default 30)
        shake.startWatch(onShake, 40 /*, onError */);
    };

    var onShake = function () {
        // Fired when a shake is detected
        $('#liter').val("");
        $('#kilometer').val("");
    };

    var onError = function () {
        // Fired when there is an accelerometer error (optional)
    };

    var calcConsumption = function () {
        try {
            var liter = parseFloat($('#liter').val());
            var kilometer = parseFloat($('#kilometer').val());

            var consumption = liter * 100 / kilometer;
            $('#consumption').text(consumption.toFixed(2) + ' l/100km');

            localStorage.setItem('liter', liter);
            localStorage.setItem('kilometer', kilometer);
        } catch (ex) {
            alert('Liter und Kilometer müssen Decimalwerte sein!');
        }
    };


    function onPause() {
        // TODO: This application has been suspended. Save application state here.
    };

    function onResume() {
        // TODO: This application has been reactivated. Restore application state here.
    };
})();