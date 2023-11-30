const mostrarDatos =() => {
    let availHeight = window.screen.availHeight;
    let availWidth = window.screen.availWidth;
    let colorDepth = window.screen.colorDepth;
    let height = window.screen.height;
    let width = window.screen.width;
    
    document.getElementById('availHeight').textContent = availHeight;
    document.getElementById('availWidth').textContent = availWidth;
    document.getElementById('colorDepth').textContent = colorDepth;
    document.getElementById('height').textContent = height;
    document.getElementById('width').textContent = width;
}

mostrarDatos();