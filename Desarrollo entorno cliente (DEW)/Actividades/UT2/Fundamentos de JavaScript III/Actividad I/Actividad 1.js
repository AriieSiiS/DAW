
// PARTE 1 ------------------------------

const coords = () => {
  navigator.geolocation.getCurrentPosition(function(position) {

    let latitude = position.coords.latitude;
    let longitude = position.coords.longitude;

    document.getElementById('latitude').textContent = latitude;
    document.getElementById('longitude').textContent = longitude;

  });
}

// PARTE 2 ------------------------------

const pcInfo = () => {
  let numProcesadores = navigator.hardwareConcurrency;
  let gbOfRAM = navigator.deviceMemory;

  document.getElementById('numCores').textContent = numProcesadores;
  document.getElementById('ramInfo').textContent = gbOfRAM + ' GB';
}


// PARTE 3  ---------------------------------------------------------------------------------------

const mediaDevices = () => {
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

// PARTE 4  ---------------------------------------------------------------------------------------

document.getElementById('IE7').textContent = "<!--[if (IE 5) | (IE 7)]> <link rel='stylesheet' type='text/css' href='ESTILO1.css'> <![endif]>"
document.getElementById('IE9').textContent = "<!--[if (IE 9)]> <link rel='stylesheet' type='text/css' href='ESTILO2.css'> <![endif]>"


pcInfo();
coords();
mediaDevices();
