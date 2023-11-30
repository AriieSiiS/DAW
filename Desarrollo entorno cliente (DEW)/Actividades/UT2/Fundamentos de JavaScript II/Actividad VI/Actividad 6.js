document.getElementById("calcular").addEventListener("click", function() {
  const fechaNacimiento = new Date(document.getElementById("fechaNacimiento").value);
  const fechaActual = new Date();

  const diferenciaMinutos = (fechaActual - fechaNacimiento) / (1000 * 60);

  const añosTranscurridos = Math.floor(diferenciaMinutos / (60 * 24 * 365.25));
  const mesesTranscurridos = Math.floor(diferenciaMinutos / (60 * 24 * 30.44));
  const diasTranscurridos = Math.floor(diferenciaMinutos / (60 * 24));
  const horasTranscurridas = Math.floor(diferenciaMinutos / 60);

  // Cálculo de años bisiestos
  let añosBisiestos = 0;
  for (let i = fechaNacimiento.getFullYear(); i <= fechaActual.getFullYear(); i++) {
    if ((i % 4 === 0 && i % 100 !== 0) || (i % 400 === 0)) {
      añosBisiestos++;
    }
  }

  document.getElementById("resultado").innerHTML = `
    Años transcurridos: ${añosTranscurridos}<br>
    Meses transcurridos: ${mesesTranscurridos}<br>
    Días transcurridos: ${diasTranscurridos}<br>
    Horas transcurridas: ${horasTranscurridas}<br>
    Años bisiestos transcurridos: ${añosBisiestos}
  `;
});