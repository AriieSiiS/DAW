window.addEventListener('load', () => {

    //variables globales
    var colorSeleccionado = null;
    var haciendoClic = false;

    const crearTabla = () => {

        let zonaDibujo = document.getElementById('zonadibujo');
        let tabla = document.createElement('table');

        for (var i = 0; i < 31; i++) {
            let fila = document.createElement('tr');
            for (var j = 0; j < 31; j++) {
                let celda = document.createElement('td');
                fila.appendChild(celda);
            }
            tabla.appendChild(fila);
        }
        zonaDibujo.appendChild(tabla);
    };

    const estadoPincel = () => {
        let celdasColores = document.querySelectorAll('#paleta tr:first-child td');
    
        celdasColores.forEach(function(celdaColor) {
            celdaColor.addEventListener('click', function() {
                celdasColores.forEach(function(celda) {
                    celda.classList.remove('seleccionado');
                });
    
                celdaColor.classList.add('seleccionado');
                let celdaPincel = document.getElementById('pincel');
                celdaPincel.style.backgroundColor = getComputedStyle(celdaColor).backgroundColor;
                colorSeleccionado = getComputedStyle(celdaColor).backgroundColor;
                
                if (celdaColor.classList.contains('color3') && celdaColor.classList.contains('seleccionado')) {
                    celdaPincel.style.color = 'white';
                }
                else {
                    celdaPincel.style.color = 'black';
                }
            });
        });
    };

    const pintarTabla = () => {
        let celdasTabla = document.querySelectorAll('#zonadibujo td');

        celdasTabla.forEach(function(celda) {
            celda.addEventListener('mouseover', function() {
                if (haciendoClic && colorSeleccionado) {
                    celda.style.backgroundColor = colorSeleccionado;
                }
            });
        });

        let tabla = document.getElementById('zonadibujo');
        tabla.addEventListener('click', function() {
            haciendoClic = !haciendoClic; 
            // pensé que era el caption pero bueno ya lo dejo
            let caption = document.querySelector('#pincel');
            caption.textContent = haciendoClic ? 'PINCEL ACTIVADO' : 'PINCEL DESACTIVADO';
        });
    };

    // Creamos la tabla
    crearTabla();
    // Seleccionamos el color del pincel 
    estadoPincel();
    // Llama a la función para pintar al pasar el ratón por encima
    pintarTabla();

});



