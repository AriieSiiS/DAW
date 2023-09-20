// Seleccionar el formulario y el elemento de entrada por su ID
var form = document.querySelector('form');
var input = document.getElementById('test');

// Agregar un evento de escucha para el envío del formulario
form.addEventListener('submit', function(event) {
    event.preventDefault(); // Evita la recarga de la página

    // Obtener el valor del campo de entrada
    var nombre = input.value;

    // Crear un nuevo párrafo con el mensaje
    var nuevoParrafo = document.createElement('p');
    nuevoParrafo.textContent = "Tu nombre es: " + nombre;

    // Agregar el párrafo al documento
    document.body.appendChild(nuevoParrafo);
});
