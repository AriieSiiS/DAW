const isFirexox = () => {
    let firefox = userAgent.includes("Firefox");
    if (firefox) {
        var link = document.querySelector("link[rel='stylesheet']");
        link.href = "Firefox.css";
      }
}

const mostrarDatos = () => {
    //pantalla
    let availHeight = window.screen.availHeight;
    let availWidth = window.screen.availWidth;
    let height = window.screen.height;
    let width = window.screen.width;
    let colorDepth = window.screen.colorDepth;
    let pixelDepth = window.screen.pixelDepth

    const pantalla = document.querySelectorAll('.pantalla p');

    pantalla[0].textContent += ` ${availHeight} px`;
    pantalla[1].textContent += ` ${availWidth} px`;
    pantalla[2].textContent += ` ${height} px`;
    pantalla[3].textContent += ` ${width} px`;
    pantalla[4].textContent += ` ${colorDepth} bits`;
    pantalla[5].textContent += ` ${pixelDepth} bits por pixel`;

    document.getElementById

    //ventana
    let outerHeight = window.outerHeight;
    let outerWidth = window.outerWidth;
    let coordX = window.screenX;
    let coordY = window.screenY;

    const ventana = document.querySelectorAll('.ventana p');

    ventana[0].textContent += ` ${outerHeight} px`;
    ventana[1].textContent += ` ${outerWidth} px`;
    ventana[2].textContent += ` ${coordX} px`;
    ventana[3].textContent += ` ${coordY} px`;
}

mostrarDatos();