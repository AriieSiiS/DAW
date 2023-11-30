const divider = () => {
    //sacamos lo que está escrito en el textarea
    const textarea = document.getElementById("divitron").value;
    //hacemos split, convirtiendolo en una array de elementos separados por el espacio y cambiando las comas por puntos 
    const contenidoDividido = textarea.replace(/,/g, '.').split(" ");
    //validamos que el textarea solo tenga números

    const esNumero = contenidoDividido.every((elemento) => !isNaN(parseFloat(elemento)));
    if (!esNumero) {
      return "Error: El contenido no es un número válido.";
    }

    //si llega hasta aquí, significa que todo son números, así que podemos empezar a hacer las divisiones
    //primero le asignamos a resultadoFinal el valor del primer número del array 
    let resultadoFinal = contenidoDividido[0];
    for (let i = 1; i < contenidoDividido.length; i++) {
      //luego vamos haciendo un bucle for haciendo todas las divisiones hasta terminar
      resultadoFinal /= contenidoDividido[i];
    }

    //sacamos el elemento donde pondremos la respuesta y la ponemos
    const resultado = document.getElementById("resultado_division");
    //le ponemos como max 2 decimales y lo transformamos a numero, ya que toFixed lo transforma en string
    resultado.textContent = parseFloat(resultadoFinal.toFixed(2));
    return null;
  };

//aquí llamamos a la función y válidamos si trae un mensaje de error, y si lo trae lo mandamos como alerta
//antes de llamarla, buscamos el botón y le ponemos un evento listener para que cuando haga click sea cuando llame a la función divider
const button = document.getElementById("boton");
button.addEventListener("click", function() {
  const error = divider();
  if (error !== null) {
    alert(error);
  }
});

  