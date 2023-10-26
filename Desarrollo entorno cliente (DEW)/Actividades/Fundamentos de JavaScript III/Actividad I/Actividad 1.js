// ACTIVIDAD 1 y 2 ---------------------------------------------------------------------------------------

function obtenerInformacion() {
    if ('geolocation' in navigator && 'hardwareConcurrency' in navigator && 'deviceMemory' in navigator) {
      navigator.geolocation.getCurrentPosition(function(position) {
        let latitude = position.coords.latitude;
        let longitude = position.coords.longitude;
        let numProcesadores = navigator.hardwareConcurrency;
        let gbOfRAM = navigator.deviceMemory;
  
        document.getElementById('numCores').textContent = numProcesadores;
        document.getElementById('latitude').textContent = latitude;
        document.getElementById('longitude').textContent = longitude;
        document.getElementById('ramInfo').textContent = gbOfRAM + ' GB';
      });
    } else {
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

// ACTIVIDAD 4  ---------------------------------------------------------------------------------------

function obtenerInformacionIII() {
  document.getElementById('IE7').textContent = "<!--[if (IE 5) | (IE 7)]> <link rel='stylesheet' type='text/css' href='ESTILO1.css'> <![endif]>"
  document.getElementById('IE9').textContent = "<!--[if (IE 9)]> <link rel='stylesheet' type='text/css' href='ESTILO2.css'> <![endif]>"
}

obtenerInformacion();
obtenerInformacionII();
obtenerInformacionIII();
