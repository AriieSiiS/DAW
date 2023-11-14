const DOM = {
    enlaces: document.querySelectorAll("a"),
    abrirVentana: document.querySelector("#abrir-ventanas"),
    allDivs: document.querySelectorAll("div")
}



const ventanasAbiertas = [];

const abrirVentanas = () => {
    let left = 0;
    let top = 100;
    const anchoVentana = window.innerWidth / 3; 
    const altoVentana = window.innerHeight / 3; 

    for (var i = 0; i < DOM.enlaces.length; i++) {
        var enlace = DOM.enlaces[i];
        var url = enlace.getAttribute("href"); 
        const ventana = window.open(url, "_blank", `width=${anchoVentana},height=${altoVentana}, left=${left}, top=${top}`);
        left += (anchoVentana / 2);
        top += 100;
        ventanasAbiertas.push(ventana);
      }
}

const cerrarVentanas = () => {
    for (let i = 0; i < ventanasAbiertas.length; i++) {
      const ventana = ventanasAbiertas[i];
      ventana.close();
    }
    ventanasAbiertas.length = 0;
}

const calculaMedida = () => {
    const valorInput = document.getElementById("numOper").value;
    const regex = /^\d+$/;
    const numerosMedia = [];


    if (regex.test(valorInput)) {
      for (let i = 0; i < valorInput; i++) {
        let numeroIngresado;
        var notNum = true;
        while (notNum) {
          numeroIngresado = prompt("Por favor, ingresa un número:");
          if (!isNaN(numeroIngresado)) {
            notNum = false;
          }
        }
        numerosMedia.push(numeroIngresado);
      }

      const suma = numerosMedia.reduce((acumulador, numero) => {
        let numeroEntero = parseFloat(numero, 10);
        numeroEntero = parseFloat(numeroEntero.toFixed(2));
        return acumulador + numeroEntero;
      }, 0);
      
      const media = suma / numerosMedia.length;
      let ultimoDiv = DOM.allDivs[DOM.allDivs.length - 1];

      const numerosConcatenados = numerosMedia.join(", "); // Convierte los números en una cadena separada por comas
      const mensaje = "La media de: " + numerosConcatenados  + " es -> " + media + ")";
      ultimoDiv.textContent = mensaje;

    } else {
      alert("Error: Debes ingresar un número entero no negativo.");
    }
}




