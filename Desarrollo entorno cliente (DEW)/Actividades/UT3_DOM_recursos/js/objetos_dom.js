const DOM = {
    tabla: undefined, 
    th: undefined,
    trImpar: undefined,
    trPar: undefined,
    primeraColumna: undefined, 
    tdPresidente: undefined,
    primeraFila: undefined,
    filas: undefined
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
        filas:  document.querySelector("#datos_tabla tr")
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
    
    for (let i = nodosFilas.length - 1; i >= 0; i--) {
        let nodo = nodosFilas[i];
        if (nodo.nodeType === Node.TEXT_NODE && /^[\n\s]+$/.test(nodo.textContent)) {
            DOM.filas.removeChild(nodo);
        }
    }
    
    alert(DOM.primeraFila.childNodes.length)
});


