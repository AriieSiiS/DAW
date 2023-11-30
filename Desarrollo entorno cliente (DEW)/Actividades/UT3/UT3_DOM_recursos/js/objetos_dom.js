const DOM = {
    tabla: undefined, 
    th: undefined,
    trImpar: undefined,
    trPar: undefined,
    primeraColumna: undefined, 
    tdPresidente: undefined,
    primeraFila: undefined,
    filas: undefined,
    tr: undefined,
    escudo: undefined,
    tfooter: undefined
}

window.addEventListener("load", () => {
    const DOM = {
        tabla: document.querySelector("#datos_tabla"),
        th: document.querySelectorAll("th"),
        trImpar: document.querySelectorAll("tr:nth-child(odd)"),
        trPar: document.querySelectorAll("tr:nth-child(even)"),
        primeraColumna: document.querySelectorAll("tr td:first-child"),
        tdPresidente: document.querySelectorAll("td"),
        primeraFila: document.querySelector("tr:first-child"),
        filas:  document.querySelector("#datos_tabla tr"),
        tr : document.querySelectorAll("tr"),
        escudo : document.querySelector("#escudo"),
        tfooter : document.querySelector("tfoot")
    };

    DOM.th.forEach(th => th.classList.add("cabecera"));
    DOM.trImpar.forEach(tr => tr.classList.add("filaImpar"));
    DOM.trPar.forEach(tr => tr.classList.add("filaPar"));
    DOM.primeraColumna.forEach(td => td.classList.add("primeraColumna"));

    DOM.tdPresidente.forEach(td => {
        if (td.textContent.toLowerCase() === "presidente") {
            td.classList.add("presidente");
        }
        if (td.textContent.toLowerCase() === "policía") {
            td.parentNode.classList.add("policia");
        }
    });

    let nodosFilas = DOM.filas.childNodes;
    
    for (i=nodosFilas.length - 1; i >= 0; i--) {
        let nodo = nodosFilas[i];
        if (nodo.nodeType === Node.TEXT_NODE && /^[\n\s]+$/.test(nodo.textContent)) {
            DOM.filas.removeChild(nodo);
        }
    }
    //copiamos el encabezado en el footer
    let firstTrClone = DOM.tr[0].cloneNode(true); 
    DOM.tfooter.appendChild(firstTrClone);




    DOM.tr = Array.from(DOM.tr).slice(1);
    DOM.tr.forEach(tr => {
        let primerTd = tr.children[1];
        let segundoTd = tr.children[2];
        let idTd = tr.children[0];
        let correo = tr.children[4].textContent;

        let contenidoPrimerTd = primerTd.textContent.trim().charAt(0).toUpperCase();
        if (contenidoPrimerTd === "M" || contenidoPrimerTd === "G") {
                   primerTd.style.textAlign = "right";
        }

        if (segundoTd.textContent.trim().charAt(0).toUpperCase() === "J") {
            segundoTd.textContent = segundoTd.textContent.toUpperCase();
            tr.firstElementChild.classList.add("borde_rojo");
            tr.lastElementChild.classList.add("borde_rojo");

            tr.firstElementChild.nextElementSibling.classList.add("destaca");
            tr.lastElementChild.previousElementSibling.previousElementSibling.classList.add("destaca");
        }

        let validarCorreoElectronico = (email => {
            const regexCorreoElectronico = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
            return regexCorreoElectronico.test(email);
        });

        let correovalido = validarCorreoElectronico(correo);
        if (!correovalido) {
            tr.children[4].textContent = "";
        }
        if (idTd.textContent === "8") {
            tr.lastElementChild.previousElementSibling.previousElementSibling.textContent = "jaqueline.power@yahoo.com";
        }
    });

    DOM.escudo.setAttribute('src' , 'img/objeto_dom.gif');
    DOM.escudo.setAttribute ('alt' , 'Logotipo del Gobierno');

    Array.from(DOM.tabla.rows).forEach((row, index) => {
        // Verifica si es la primera o última fila
        if (index === 0 || index === DOM.tabla.rows.length - 1) {
            // Si es la primera o última fila, inserta una nueva celda
            let nuevaCelda = document.createElement("th");
            let textoCelda = document.createTextNode("Edad");
            nuevaCelda.appendChild(textoCelda);
            row.insertBefore(nuevaCelda, index === 0 ? row.cells[3] : row.cells[3]);
            nuevaCelda.classList.add("cabecera");
        } else {
            // Si no es la primera ni la última fila, inserta una nueva celda en la posición 3
            let nuevaCelda = row.insertCell(3);
            let textoCelda = document.createTextNode("13");
            nuevaCelda.appendChild(textoCelda);

            // COMENTADO PARA QUE NO ME PIDA INGRESAR LAS EDADES CADA VEZ QUE HAGO F5
            // let edad = prompt("Ingrese la edad:");
            // let nuevaCelda = row.insertCell(3);
            // let textoCelda = document.createTextNode(edad);
            // nuevaCelda.appendChild(textoCelda);
        }
    });

    //borramos el tr que clonamos anteriormente para el último ejercicio
    DOM.tfooter.removeChild(firstTrClone);

    const sumarCeldasEnTr = () => {

        let sumaPosicion6 = 0;
        let sumaPosicion7 = 0;
    
        Array.from(DOM.tabla.rows).forEach(tr => {
            let td6 = tr.cells[6];
            let td7 = tr.cells[7];
    
            if (td6 && !isNaN(td6.textContent)) {
                sumaPosicion6 += parseFloat(td6.textContent);
            }
    
            if (td7 && !isNaN(td7.textContent)) {
                sumaPosicion7 += parseFloat(td7.textContent);
            }
        });
    
        return {
            sumaPosicion6,
            sumaPosicion7
        };
    };
    
    let nuevoTr = DOM.tfooter.appendChild(document.createElement("tr"));
    nuevoTr.classList.add("cabecera");
    
    const { sumaPosicion6, sumaPosicion7 } = sumarCeldasEnTr();

    nuevoTr.innerHTML = `
        <td colspan="6">TOTAL:</td>
        <td>${sumaPosicion6}</td>
        <td>${sumaPosicion7}</td>
    `;
    
    //COMENTADO PARA QUE NO ME SALTE EL ALERT CADA VEZ QUE HAGO F5
    //alert(DOM.primeraFila.childNodes.length)
});


