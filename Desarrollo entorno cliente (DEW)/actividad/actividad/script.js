document.addEventListener('DOMContentLoaded', function() {
    // Obtener el elemento select de la isla
    var islaSelect = document.getElementById('isla');

    // Crear las opciones
    var laGomeraOption = document.createElement('option');
    laGomeraOption.value = 'La Gomera';
    laGomeraOption.textContent = 'La Gomera';

    var elHierroOption = document.createElement('option');
    elHierroOption.value = 'El Hierro';
    elHierroOption.textContent = 'El Hierro';

    // Agregar las opciones al select
    islaSelect.appendChild(laGomeraOption);
    islaSelect.appendChild(elHierroOption);
});

document.addEventListener('DOMContentLoaded', function() {
    // Obtener el elemento select de los municipios
    var municipioSelect = document.getElementById('municipio');

    // Crear las opciones para El Hierro (H)
    var elPinarOption = createMunicipioOption('El Pinar (H)', 'H');
    var fronteraOption = createMunicipioOption('Frontera (H)', 'H');
    var valverdeOption = createMunicipioOption('Valverde (H)', 'H');

    // Crear las opciones para La Gomera (G)
    var aguloOption = createMunicipioOption('Agulo (G)', 'G');
    var alajeroOption = createMunicipioOption('Alajeró (G)', 'G');
    var hermiguaOption = createMunicipioOption('Hermigua (G)', 'G');
    var sanSebastianOption = createMunicipioOption('San Sebastián de la Gomera (G)', 'G');
    var valleGranReyOption = createMunicipioOption('Valle Gran Rey (G)', 'G');
    var vallehermosoOption = createMunicipioOption('Vallehermoso (G)', 'G');

    // Agregar las opciones al select
    municipioSelect.appendChild(elPinarOption);
    municipioSelect.appendChild(fronteraOption);
    municipioSelect.appendChild(valverdeOption);
    municipioSelect.appendChild(aguloOption);
    municipioSelect.appendChild(alajeroOption);
    municipioSelect.appendChild(hermiguaOption);
    municipioSelect.appendChild(sanSebastianOption);
    municipioSelect.appendChild(valleGranReyOption);
    municipioSelect.appendChild(vallehermosoOption);
});

function createMunicipioOption(text, isla) {
    // Crear elemento option
    var option = document.createElement('option');
    
    // Establecer el texto y el valor de la opción
    option.textContent = text;
    option.value = text;

    // Establecer un atributo personalizado para identificar la isla
    option.setAttribute('data-isla', isla);

    return option;
}


function limpiarFormulario() {
    // Limpiar campos de texto
    var camposTexto = document.querySelectorAll('input[type="text"]');
    camposTexto.forEach(function(input) {
        input.value = '';
    });

    // Inicializar selectores al primer objeto "Indique ..."
    var selects = document.querySelectorAll('select');
    selects.forEach(function(select) {
        select.selectedIndex = 0;
    });

    // Seleccionar todos los checkboxes
    var checkboxes = document.querySelectorAll('input[type="checkbox"]');
    checkboxes.forEach(function(checkbox) {
        checkbox.checked = true;
    });
}