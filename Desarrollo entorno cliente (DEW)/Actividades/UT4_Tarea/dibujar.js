window.addEventListener('load', () => {
    // Este código se ejecutará después de que la página se haya cargado completamente

    // Función para crear la tabla
    const crearTabla = () => {
        // Obtén la referencia al div
        var zonaDibujo = document.getElementById('zonadibujo');

        // Crea la tabla
        var tabla = document.createElement('table');

        // Bucle para agregar filas
        for (var i = 0; i < 31; i++) {
            var fila = document.createElement('tr');

            // Bucle para agregar celdas a cada fila
            for (var j = 0; j < 31; j++) {
                var celda = document.createElement('td');

                // Aplica estilos mínimos a cada celda
                fila.appendChild(celda);
            }

            // Agrega la fila a la tabla
            tabla.appendChild(fila);
        }

        // Agrega la tabla al div
        zonaDibujo.appendChild(tabla);
    };

    const estadoPincel = () => {
        // Selecciona todas las celdas de color dentro de la primera fila
        var celdasColores = document.querySelectorAll('#paleta tr:first-child td');
    
        // Asigna un manejador de eventos de clic a cada celda de color
        celdasColores.forEach(function(celdaColor) {
            celdaColor.addEventListener('click', function() {
                // Quita la clase "seleccionado" de todas las celdas de color
                celdasColores.forEach(function(celda) {
                    celda.classList.remove('seleccionado');
                });
    
                // Añade la clase "seleccionado" a la celda de color clicada
                celdaColor.classList.add('seleccionado');
    
                // Actualiza el color de fondo de la celda "pincel"
                var celdaPincel = document.getElementById('pincel');
                // Obtiene la clase de color de la celda clicada (por ejemplo, "color1")
                var claseColor = celdaColor.classList[0];
                // Actualiza el fondo del "pincel" con el color asociado a la clase
                celdaPincel.style.backgroundColor = getComputedStyle(celdaColor).backgroundColor;
                if (celdaColor.classList.contains('color3') && celdaColor.classList.contains('seleccionado')) {
                    celdaPincel.style.color = 'white';
            });
        });
    };

    // Creamos la tabla
    crearTabla();
    // Seleccionamos el color del pincel 
    estadoPincel();

});



