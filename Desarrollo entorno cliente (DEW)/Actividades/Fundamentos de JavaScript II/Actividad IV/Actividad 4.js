const obtenerContenido = () => {
    const textarea = document.getElementById("divitron");
    const resultado = document.getElementById("resultado_division");
    const button = document.getElementById("calcular");
    
    button.addEventListener("click", () => {
      const contenido = textarea.value;
      console.log("Contenido del TextArea: " + contenido);
      resultado.textContent = contenido;
    });
  };

  obtenerContenido();