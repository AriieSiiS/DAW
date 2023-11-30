const DOM = {
    th: document.querySelectorAll("th"),
    tdPar: document.querySelectorAll("td:nth-child(odd)"),
    tdImpar: document.querySelectorAll("td:nth-child(even)"),
    fila: document.querySelector("tr"),
    tr: document.querySelectorAll("tr"),
    tfooter : document.querySelector("tfoot"),
    tabla: document.querySelector("table")
}



const parte1 = () => {
    DOM.th.forEach(th => th.classList.add("cabecera"));
    DOM.tdPar.forEach(td => td.classList.add("columnaPar"));
    DOM.tdImpar.forEach(td => td.classList.add("columnaImpar"));
}

const parte2 = () => {
    let array2 = []
    DOM.tr.forEach(tr => {
        array2.push(tr)
    })
}

const parte3 = () => {
    let array1 = Array.from(DOM.tabla.rows);
     array1[1].lastChild.previousSibling.remove(1)
     array1[2].lastChild.previousSibling.previousSibling.remove(1)
     array1[5].lastChild.previousSibling.remove(1)
     array1[6].lastChild.previousSibling.remove(1)
     array1[7].lastChild.previousSibling.remove(1)
     array1[8].lastChild.previousSibling.remove(1)
     array1[9].lastChild.previousSibling.remove(1)
     array1[10].lastChild.previousSibling.remove(1)
     array1[11].lastChild.previousSibling.remove(1)
     array1[12].lastChild.previousSibling.remove(1)
}



const parte5 = () => {

    let totalMensualidades = 0;
    let numeroMensualidades = 0;
    let num = 0;

    Array.from(DOM.tabla.rows).forEach(tr => {
        let td6 = tr.cells[6];
        num++;

        if (num > 1 && td6 && isNaN(td6.textContent)) {
            const td = td6.textContent.replace(/€/g, '');
            td6.textContent = td;
            totalMensualidades += parseFloat(td);
            numeroMensualidades++;
        }
    });

    let media = totalMensualidades / numeroMensualidades;

    let nuevoTr = DOM.tfooter.appendChild(document.createElement("tr"));
    nuevoTr.classList.add("pie");
    nuevoTr.innerHTML = `
        <td colspan="8">La media de mensualidad de hipotecas es ${media}€</td>
    `;
}

parte1();
parte2();
parte3();

parte5();
