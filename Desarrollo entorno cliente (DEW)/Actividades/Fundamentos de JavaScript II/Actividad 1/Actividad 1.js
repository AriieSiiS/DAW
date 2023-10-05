const DOM = {
    numvalue: document.querySelector("#num"),
    divisor: document.getElementById("divisor"),
    divañadir: document.getElementById("añadir")
}



DOM.divisor.addEventListener("click", () => {
    DOM.divañadir.innerHTML = ""; // Limpia el contenido anterior si lo hay
    let num = DOM.numvalue.value;
    let divisores = "";
    console.log(valueof(num));
    if (isNaN(num)) {
        alert("Error! - Indique un número valido");
    } else {
        for (let i = 1; i <= num; i++) {
            if (num % i === 0) {
                divisores += "<p>" + i + "</p>";
            }
        }
    }
    DOM.divañadir.innerHTML = divisores;
});


