// Variables
const results = document.querySelector("#resultado");
//pillamos todos los botones
const buttons = document.querySelectorAll("input[type='button']");



//por cada botón, le añadimos el evento listener click, de tal forma que cuando hagas click en el botón
//llame a la función buttonClick, esta función recibe como parametro el evento (un objeto que se crea
//de forma automática con el propio click), entonces registramos que botón es el que ha llamado al evento
//y guardamos su valor en la variable buttonValue

//variables
let currentNumber = "";
let operator = "";
let result = 0;

function buttonClick(event) {
    const clickedButton = event.target;
    const buttonValue = clickedButton.value;



    //si el valor del botón es un número o es el punto decimal, entra en el if
    if (!isNaN(buttonValue) || buttonValue === ".") {

        //dentro del if designamos el valor del botón (que sabemos que es un numero si o si) a la variable, y lo mostramos en el apartado resultado
        currentNumber += buttonValue;
        results.textContent = currentNumber;

    //si no es un numero, comprobamos que sea un operador matemático
    } else if (buttonValue === "+" || buttonValue === "-" || buttonValue === "*" || buttonValue === "/") {
        results.textContent = buttonValue;
        // Si se presiona un operador, guarda el número actual en caso de que lo tenga y el operador, si no tiene número primero no guarda nada
        if (currentNumber !== "") {
            operator = buttonValue;
            result = parseFloat(currentNumber); // Convierte el número actual a un valor float 
            currentNumber = ""; // Reinicia el número actual para que se pueda introducir otro (o si pone otro simbolo no entre de nuevo aquí)
        }

    //revisa si el botón pulsado es el "=" y por lo tanto el final de la operación matemática
    } else if (buttonValue === "=") {
        // Si se presiona "=", realiza la operación y muestra el resultado.
        if (currentNumber !== "") {
            const secondNumber = parseFloat(currentNumber);
            switch (operator) {
                case "+":
                    result += secondNumber;
                    break;
                case "-":
                    result -= secondNumber;
                    break;
                case "*":
                    result *= secondNumber;
                    break;
                case "/":
                    result /= secondNumber;
                    break;
            }
            results.textContent = result;
            currentNumber = ""; // Reinicia el número actual
        }
    } else if (buttonValue === "C") {
        results.textContent = "";
        result = 0;
        currentNumber = ""; // Reinicia el número actual
        operator = "";
    }
}

buttons.forEach(button => {
    button.addEventListener("click", buttonClick);
});

