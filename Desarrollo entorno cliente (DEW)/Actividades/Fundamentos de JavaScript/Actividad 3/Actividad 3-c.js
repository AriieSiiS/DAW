function multiplicar() {
    let numero1 = parseInt(document.querySelector("#numero1").value);
    let numero2 = parseInt(document.querySelector("#numero2").value);
    if (isNaN(numero1) || isNaN(numero2)) {
        alert("Por favor, ingrese valores numéricos.");
    } else {
    let resultado = numero1 * numero2; 
    document.querySelector("#resultado").value = resultado;
    }
}



// function multiplicar() {
//     let campoNumero1 = document.getElementById("numero1");
//     let valorNumero1 = campoNumero1.value;

//     let campoNumero2 = document.getElementsByName("numero2")[0];
//     let valorNumero2 = campoNumero2.value;

//     let camposTag = document.getElementsByTagName("input");
//     for (var i = 0; i < camposTag.length; i++) {
//         if (camposTag[i].name === "resultado") {
//             var campoResultado = camposTag[i];
//             break;
//         }
//     }
//     let resultado = parseFloat(valorNumero1) * parseFloat(valorNumero2);
//     campoResultado.value = resultado;
// }


