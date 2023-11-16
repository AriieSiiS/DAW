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
    
    let firstTrClone = DOM.tr[0].cloneNode(true); 
    DOM.tfooter.appendChild(firstTrClone);



    DOM.tr = Array.from(DOM.tr).slice(1);
    DOM.tr.forEach(tr => {
        let segundoTd = tr.children[2];
        let idTd = tr.children[0];
        let correo = tr.children[4].textContent;


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
            console.log("hola")
            tr.lastElementChild.previousElementSibling.previousElementSibling.textContent = "jaqueline.power@yahoo.com";
        }


    });



    DOM.escudo.setAttribute('src' , 'img/objeto_dom.gif');
    DOM.escudo.setAttribute ('alt' , 'Logotipo del Gobierno');




    //alert(DOM.primeraFila.childNodes.length)
});


