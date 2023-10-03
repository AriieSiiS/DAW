
function test() {
    let texto = document.querySelector("#texto").value;
    let contadorO = 0;
    let contadorA = 0;
    let caracteres = texto.split("");
    for (let i = 0; i < caracteres.length; i++) {
         if (caracteres[i] === "o" || caracteres[i] === "O") {
           contadorO++;
        } else if (caracteres[i] === "a" || caracteres[i] === "A") {
           contadorA++;
         }
     }
    document.querySelector("#texto").value = "Hay " + contadorA + " aes y " + contadorO + " oes";
    alert("Número de letras 'a' y 'A': " + contadorA + " Número de letras 'o' y 'O': " + contadorO);
}