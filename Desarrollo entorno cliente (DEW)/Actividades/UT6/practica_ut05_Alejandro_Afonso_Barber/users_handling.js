document.addEventListener('DOMContentLoaded', function () {
  // Div de registro de usuario
  var newUserDiv = document.querySelector('#new_user');
  // Botón para mostrar el div de registro de usuario
  var button = document.querySelector('#new_user_button');

  // Agrega un event listener al botón
  button.addEventListener('click', function () {
    // Cuando se haga clic en el botón, muestra el div #new_user (formulario de registro)
    newUserDiv.style.display = 'block';
  });

  // Formulario de registro de usuario
  var newUserForm = document.querySelector('#loggin_form');
  // Botón de login
  var loginButton = document.querySelector('#loggin_button');

  var lockIcon = document.querySelector('#lock_icon');
  var unloggedUserDialog = document.querySelector('#unlogged_user_dialog');
  var loggedUserDialog = document.querySelector('#logged_user_dialog');
  // Elemento que muestra el nombre del usuario loggeado
  var userNameLogged = document.querySelector('#user_name_logged');
  // Botón de logout
  var logoutButton = document.querySelector('#sign_out');


  var forgotPasswordLink = document.querySelector('#unlogged_user_dialog a');
  var sendButton = document.querySelector('#frgttn_psswrd_send');
  var emailInput = document.querySelector('#frgttn_psswrd input');
  var dialog = document.querySelector('#frgttn_psswrd');
  var dialog2 = document.querySelector('.dialog');

  // Mostrar el diálogo cuando se haga clic en "Forgot your password"
  forgotPasswordLink.addEventListener('click', function() {
      dialog.style.display = 'block';
  });

  // Enviar el correo electrónico cuando se haga clic en "Send"
  sendButton.addEventListener('click', function() {
    console.log("Hola")
      var email = emailInput.value;
      recoverPassword(email);
      dialog.style.display = 'none';
  });

  function recoverPassword(email) {
    var formData = new FormData();
    formData.append('email', email);

    fetch('psswrd_recover.php', {
        method: 'POST',
        body: formData
    })
    .then(response => response.text())
    .then(password => {
        dialog2.style.display = 'block';
        dialog2.textContent = 'La contraseña recuperada es: ' + password;
        console.log('La contraseña recuperada es: ' + password);
    })
    .catch(error => console.error('Error:', error));
}

  logoutButton.addEventListener('click', function () {
    // Ocultar el mensaje de bienvenida personalizado
    document.getElementsByClassName('dialog')[0].style.display = 'none';

    // Cambiar el icono de candado abierto por el icono de candado bloqueado
    lockIcon.setAttribute('src', 'padlock_locked_32x32_white.png');

    // Borrar el nombre del usuario loggeado
    userNameLogged.innerHTML = '';

    // Mostrar el diálogo de usuario no registrado y ocultar el diálogo de usuario registrado
    unloggedUserDialog.style.display = 'block';
    loggedUserDialog.style.display = 'none';

    // Restaurar la opacidad del formulario de registro
    document.getElementById('new_user').style.filter = 'opacity(100%)';
});

  loginButton.addEventListener('click', function () {
    // Recoger los datos del formulario
    var formData = new FormData(newUserForm);

    fetch('check_user.php', {
      method: 'POST',
      body: formData
    })
      .then(response => response.text())
      .then(data => {
        if (data === "1") {
          // Mostrar mensaje de bienvenida personalizado
          var username = formData.get('userName');
          var mssg = `¡Bienvenido, ${username}!`;
          document.getElementById('new_user').style.filter = 'opacity(20%)';
          document.getElementsByClassName('dialog')[0].style.display = 'block';
          document.getElementsByClassName('dialog')[0].getElementsByTagName('span')[0].innerHTML = mssg;

          // Cambiar el icono de candado bloqueado por el icono de candado abierto
          lockIcon.setAttribute('src', 'padlock_unlocked_32x32_white.png');

          // Mostrar el nombre del usuario loggeado
          userNameLogged.innerHTML = username;

          // Ocultar el diálogo de usuario no registrado y mostrar el diálogo de usuario registrado
          unloggedUserDialog.style.display = 'none';
          loggedUserDialog.style.display = 'block';
        } else {
          // El usuario no existe
          console.log("Usuario no existe");
        }
      })
      .catch((error) => {
        console.error('Error:', error);
      });
  });
});
