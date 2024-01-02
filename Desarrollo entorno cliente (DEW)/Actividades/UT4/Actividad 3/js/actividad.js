let num_registros = 0;

const carga_datos = () => {
  fetch("js/info.json")
    .then(response => response.json())
    .then(json => {
      console.log(json);

      const tablaCuerpo = document.querySelector("#tabla tbody"); 

      // Ocultar el div que tiene el id formulario y el input con id userId.
      const formularioDiv = document.getElementById("formulario");
      formularioDiv.style.display = "none";
      const userIdInput = document.getElementById("userId");
      userIdInput.style.display = "none";

      tablaCuerpo.innerHTML = "";

      // Solicitar la carga del json
      json.forEach(item => {
        const fila = document.createElement("tr");

        const userIdCell = document.createElement("td");
        userIdCell.textContent = item.userId;
        fila.appendChild(userIdCell);

        const idCell = document.createElement("td");
        idCell.textContent = item.id;
        fila.appendChild(idCell);

        const titleCell = document.createElement("td");
        titleCell.textContent = item.title;
        fila.appendChild(titleCell);

        const completedCell = document.createElement("td");
        completedCell.textContent = item.completed ? "Sí" : "No";
        fila.appendChild(completedCell);

        tablaCuerpo.appendChild(fila);
      });

      // Se definirá el evento sobre el botón Nuevo, que mostrará el div que tiene el id formulario e 
      // inicializará todos los inputs a vacío y el checkbox lo dejará en blanco.
      document.getElementById("nuevo").addEventListener("click", function () {

        const formularioDiv = document.getElementById("formulario");
        formularioDiv.style.display = "block";
      

        const userIdInput = document.getElementById("userId");
        const idInput = document.getElementById("id");
        const titleInput = document.getElementById("title");
        const completedCheckbox = document.getElementById("completed");
      
        userIdInput.value = "";
        idInput.value = "";
        titleInput.value = "";
        completedCheckbox.checked = false;
      });

      // Se definirá el evento sobre el botón Cancelar, que al pulsarlo ocultará el div que tiene el id formulario.
      document.getElementById("cancelar").addEventListener("click", function () {
      formularioDiv.style.display = "none";
      });

      // Se definirá el evento sobre el botón Aceptar,
      // que al pulsarlo ocultará el div que tiene el id formulario y guardará los cambios en la tabla 
      // si se ha cargado un registro en el formulario o se añadirá un nuevo registro en la tabla (una fila) si se se trata de un registro nuevo.
      document.getElementById("aceptar").addEventListener("click", function () {

        const formularioDiv = document.getElementById("formulario");
        formularioDiv.style.display = "none";

        const userIdInput = document.getElementById("userId");
        const idInput = document.getElementById("id");
        const titleInput = document.getElementById("title");
        const completedCheckbox = document.getElementById("completed");

        const tablaCuerpo = document.querySelector("#tabla tbody");
        const id = idInput.value;
        if (id) {
          const filaExistente = document.getElementById(`fila-${id}`);
          filaExistente.children[2].textContent = titleInput.value;
          filaExistente.children[3].textContent = completedCheckbox.checked ? "Sí" : "No";
        } else {
          const fila = document.createElement("tr");
          fila.id = `fila-${++num_registros}`;

          const userIdCell = document.createElement("td");
          userIdCell.textContent = userIdInput.value;
          fila.appendChild(userIdCell);

          const idCell = document.createElement("td");
          idCell.textContent = num_registros;
          fila.appendChild(idCell);

          const titleCell = document.createElement("td");
          titleCell.textContent = titleInput.value;
          fila.appendChild(titleCell);

          const completedCell = document.createElement("td");
          completedCell.textContent = completedCheckbox.checked ? "Sí" : "No";
          fila.appendChild(completedCell);
          tablaCuerpo.appendChild(fila);
        }

        userIdInput.value = "";
        idInput.value = "";
        titleInput.value = "";
        completedCheckbox.checked = false;

      });
    });
};

const iniciar = () => {
  carga_datos();
};

window.addEventListener("load", iniciar, false); // Al realizar la carga se ejecuta la inicialización
