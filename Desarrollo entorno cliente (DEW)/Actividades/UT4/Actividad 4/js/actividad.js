let num_registros = 0;
let editando = null;

const carga_datos = () => {
  fetch("https://jsonplaceholder.typicode.com/users/1/todos")
    .then(response => response.json())
    .then(json => {
      console.log(json);

      const tablaCuerpo = document.querySelector("#tabla tbody");
      tablaCuerpo.innerHTML = "";

      json.forEach(item => {
        const fila = document.createElement("tr");
        fila.id = `fila-${++num_registros}`;

        for (const key in item) {
          const cell = document.createElement("td");
          cell.textContent = item[key];
          cell.addEventListener("dblclick", () => iniciarEdicion(cell));
          fila.appendChild(cell);
        }

        tablaCuerpo.appendChild(fila);
      });
    });
};

const iniciarEdicion = (celda) => {
  if (editando) {
    finalizarEdicion();
  }

  const contenidoOriginal = celda.textContent;

  const input = document.createElement("input");
  input.type = "text";
  input.value = contenidoOriginal;

  editando = celda;

  celda.innerHTML = "";
  celda.appendChild(input);

  input.focus();

  input.addEventListener("blur", finalizarEdicion);
};

const finalizarEdicion = () => {
  if (editando) {
    const input = editando.querySelector("input");
    const nuevoContenido = input.value;

    const nuevoTexto = document.createTextNode(nuevoContenido);

    editando.innerHTML = "";
    editando.appendChild(nuevoTexto);

    editando = null;
  }
};

window.addEventListener("load", carga_datos, false);
