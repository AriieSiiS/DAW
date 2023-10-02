function showEstacion() {
    const estaciones = ["Invierno", "Primavera", "Verano", "Otoño"];
    let mes = document.querySelector("#mes").value;
    let estacion = "";
    switch (mes) {
        case "enero":
        case "febrero":
        case "diciembre":
            estacion = estaciones[0]; // Invierno
            break;
        case "marzo":
        case "abril":
        case "mayo":
            estacion = estaciones[1]; // Primavera
            break;
        case "junio":
        case "julio":
        case "agosto":
            estacion = estaciones[2]; // Verano
            break;
        case "septiembre":
        case "octubre":
        case "noviembre":
            estacion = estaciones[3]; // Otoño
            break;
        default:
            estacion = "Desconocida";
    }
    document.querySelector("#estaciones").value = estacion;
}
