function mostrarFecha() {
    const fechaElemento = document.getElementById("fecha");
    const fechaActual = new Date();

    const options = {
        hour: 'numeric', // Hora en formato numérico (ejemplo: "14" para las 2 PM)
        minute: 'numeric', // Minuto en formato numérico (ejemplo: "30")
        second: 'numeric', // Segundo en formato numérico (ejemplo: "45")
        weekday: 'long', // Día de la semana en formato largo (ejemplo: "martes")
        day: '2-digit', // Día del mes en formato numérico de dos dígitos (ejemplo: "09")
        month: 'long', // Mes en formato corto (ejemplo: "ene" para enero)
        year: 'numeric', // Año en formato numérico (ejemplo: "2023")
      };
    const fechaFormateada = fechaActual.toLocaleDateString('es-ES', options);

    fechaElemento.textContent = fechaFormateada;
  }

  // Mostrar la fecha inicial
  mostrarFecha();

  // Actualizar la fecha cada segundo (1000 milisegundos)
  setInterval(mostrarFecha, 1000);