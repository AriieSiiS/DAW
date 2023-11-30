const DOM = {
    p: document.querySelector("p"),
    chico: document.getElementById("chico"),
    chica: document.getElementById("chica"),
    allDivs: document.querySelectorAll("div")
}

let dinero = 100;

const inicializa = () => {
    DOM.p.textContent = "Tiene " + dinero;
}


const regex = /^\d+$/;

//pedimos un numero 
const pedirNumero = () => {
    let numeroIngresado;
    var notNum = true;
    while (notNum) {
        numeroIngresado = prompt("Por favor, ingresa un número:");
        if (!isNaN(numeroIngresado)) {
          notNum = false;
        }
    }
    return numeroIngresado;
}

const maximo = pedirNumero();

//sacamos un valor aleatorio cuyo maximo numero es el que hemos pedido antes
const numeroAleatorio =  (maximo) => {
    return Math.floor(Math.random() * (maximo + 1));
}


// function correr() {
//     correChico = setInterval(carrera,100);
// }

const ganador = (winner) => {
    let ultimoDiv = DOM.allDivs[DOM.allDivs.length - 2];
    ultimoDiv.textContent = "Ha ganado " + winner;
    let apuesta = document.getElementById("apuesta").value
    let euroapuestaVal = document.getElementById("euroapuesta").value;
    euroapuestaVal = Number(euroapuestaVal);
    if (apuesta == 1) {
        if (winner == "Paterquito") {
            dinero += euroapuestaVal;
            inicializa();
        } else {
            dinero -= euroapuestaVal;
            inicializa();
        }
    }
    if (apuesta == 2) {
        if (winner == "Gumersinda") {
            dinero += euroapuestaVal;
            inicializa();
        } else {
            dinero -= euroapuestaVal;
            inicializa();
        }
    }
}


function carrera() {
    let winner = false;

    let posicion1 = 0;
    let posicion2 = 0;

    while (!winner) {
        posicion1 += numeroAleatorio(maximo);
        DOM.chico.style.left = posicion1 + "px";
        if (posicion1 > 1150) {
            winner = "Paterquito";
            break;
        }
        posicion2 += numeroAleatorio(maximo);
        DOM.chica.style.left = posicion2 + "px";
        if (posicion2 > 1150) {
            winner = "Gumersinda";
            break;
        }
    }
    ganador(winner);
}

const corre = () => {
    //a
    let ultimoDiv = DOM.allDivs[DOM.allDivs.length - 2];
    ultimoDiv.textContent = "";
    const apuesta = document.getElementById("apuesta").value
    //si se hace puesta, verificamos que contiene un numero entero positivo
    let euroapuestaVal = document.getElementById("euroapuesta").value;
    //si no hace apuesta, ponemos valor 0
    if (apuesta == 0) {
        euroapuestaVal = 0;
    }
    if (regex.test(euroapuestaVal)) {
        if (dinero >= euroapuestaVal) {
            carrera();
        } else {
            alert("Error, no tienes suficiente dinero")
        }
    } else {
        alert("Error, el numero está mal")
    }
}