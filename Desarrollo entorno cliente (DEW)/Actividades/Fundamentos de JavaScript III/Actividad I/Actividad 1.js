// ACTIVIDAD 1 y 2 ---------------------------------------------------------------------------------------

function obtenerInformacion() {
    if ('geolocation' in navigator && 'hardwareConcurrency' in navigator && 'deviceMemory' in navigator) {
      navigator.geolocation.getCurrentPosition(function(position) {
        var latitude = position.coords.latitude;
        var longitude = position.coords.longitude;
        var numProcesadores = navigator.hardwareConcurrency;
        var gbOfRAM = navigator.deviceMemory;
  
        // Actualiza los elementos HTML con los valores de esos datos
        document.getElementById('numCores').textContent = numProcesadores;
        document.getElementById('latitude').textContent = latitude;
        document.getElementById('longitude').textContent = longitude;
        document.getElementById('ramInfo').textContent = gbOfRAM + ' GB';
      });
    } else {
      // En caso de que no tengamos esos datos en nuestro navegador ponemos un mensaje de error
      document.getElementById('latitude').textContent = 'Esta información no está disponible en este navegador.';
      document.getElementById('longitude').textContent = 'Esta información no está disponible en este navegador.';
      document.getElementById('numCores').textContent = 'Esta información no está disponible en este navegador.';
      document.getElementById('ramInfo').textContent = 'Esta información no está disponible en este navegador.';
    }
  }

// ACTIVIDAD 3  ---------------------------------------------------------------------------------------

function obtenerInformacionII() {
    if('mediaDevices' in navigator && 'getUserMedia' in navigator.mediaDevices) {
        navigator.mediaDevices.getUserMedia({ video: true })
        .then(function(stream) {
            document.getElementById('webcam').textContent = "Tienes una WebCam";
        })
        .catch(function(error) {
            document.getElementById('webcam').textContent = "No se puede acceder o no tienes webcam";
        });
        navigator.mediaDevices.getUserMedia({ audio: true })
        .then(function(stream) {
            document.getElementById('audio').textContent = "Tienes microfono";
        })
          .catch(function(error) {
            document.getElementById('audio').textContent = "No se puede acceder o no tienes micrófono";
        });
    }
}

// Llama a las funciones cuando se cargue la página
window.onload = function() {
    obtenerInformacion();
    obtenerInformacionII();
  };