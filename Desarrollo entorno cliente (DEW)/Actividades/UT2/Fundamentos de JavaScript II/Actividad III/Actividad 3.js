// Variables
const results = document.querySelector("#resultado");
//Pillamos todos los botones
const buttons = document.querySelectorAll("input[type='button']");


// Variables
let currentInput = "";
let result = 0;

// Función para actualizar la pantalla
function updateScreen() {
    results.textContent = currentInput;
}

// Agregar un evento clic a cada botón
buttons.forEach(button => {
    button.addEventListener("click", () => {
        const buttonValue = button.value;

        if (buttonValue === "=") {
            // Si es igual, evalúa la expresión completa
            try {
                result = eval(currentInput);
                currentInput = result.toString();
                updateScreen();
            } catch (error) {
                // Maneja errores de sintaxis
                currentInput = "Error";
                result = 0;
                updateScreen();
            }
        } else if (buttonValue === "C") {
            // Si es "C", borra todo
            currentInput = "";
            result = 0;
            updateScreen();
        } else {
            // Agrega el valor del botón 
            currentInput += buttonValue;
            updateScreen();
        }
    });
});


