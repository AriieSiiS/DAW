document.addEventListener('DOMContentLoaded', function () {

    document.getElementById('textInput').addEventListener('keydown', function (event) {
        alert('Tecla presionada: ' + event.key);
    });

    document.getElementById('selectOption').addEventListener('change', function () {
        let selectedOption = this.value;
        updateContent(selectedOption);
    });

    const updateContent = (option) => {
        let contentContainer = document.getElementById('contentContainer');
    
        switch (option) {
            case 'opcion1':
                contentContainer.innerHTML = 'Contenido para la Opción 1';
                break;
            case 'opcion2':
                contentContainer.innerHTML = 'Contenido para la Opción 2';
                break;
            default:
                contentContainer.innerHTML = 'Contenido por defecto';
                break;
        }
    };
});
