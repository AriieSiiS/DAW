// function showAlert() {
//     let grade = parseFloat(document.querySelector("#nota").value);
//     if (isNaN(grade)) {
//         alert("Error! - Indique un número entre 0 y 10");
//     } else {
//         switch (true) {
//             case (grade >= 0 && grade <= 4.9):
//                 alert("Suspenso"); break;
//             case (grade >= 5 && grade <= 6.9):
//                 alert("Aprobado"); break;
//             case (grade >= 7 && grade <= 8.9):
//                 alert("Notable"); break;
//             case (grade >= 9 && grade <= 10):
//                 alert("Sobresaliente"); break;
//             case (grade < 0 || grade > 10):
//                 alert("Error, indique un número entre 0 y 10"); break;
//         }
//     }
// }

function showDiv() {
    let grade = parseFloat(document.querySelector("#nota").value);

    let elementosSecundarios = document.querySelectorAll(".secundario");
    elementosSecundarios.forEach(function(elemento) {
        elemento.style.display = "none";
    });
    
    if (isNaN(grade)) {
        alert("Error! - Indique un número entre 0 y 10");
    } else {
        switch (true) {
            case (grade >= 0 && grade <= 4.9):
                document.querySelector("#suspenso").style.display = "inline";
                break;
            case (grade >= 5 && grade <= 6.9):
                document.querySelector("#aprobado").style.display = "inline";
                break;
            case (grade >= 7 && grade <= 8.9):
                document.querySelector("#notable").style.display = "inline";
                break;
            case (grade >= 9 && grade <= 10):
                document.querySelector("#sobresaliente").style.display = "inline";
                break;
            case (grade < 0 || grade > 10):
                document.querySelector("#error").style.display = "inline";
                break;
        }
    }
}