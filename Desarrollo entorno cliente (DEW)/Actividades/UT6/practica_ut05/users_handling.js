document.addEventListener('DOMContentLoaded', function() {
    // Obtén el botón y el div #new_user
    var button = document.querySelector('#new_user_button');
    var newUserDiv = document.querySelector('#new_user');
  
    // Verifica si los elementos existen antes de agregar el event listener
    if (button && newUserDiv) {
      // Agrega un event listener al botón
      button.addEventListener('click', function() {
        // Cuando se haga clic en el botón, muestra el div #new_user
        newUserDiv.style.display = 'block';
      });
    }
  });