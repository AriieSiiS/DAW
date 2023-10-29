let window1;
let isOpen;
const maxWidth = window.screen.width;
const maxHeight = window.screen.height;

const windowActions = () => {
    let openWindow = document.querySelector("#openWindow");
    openWindow.addEventListener("click", () => {
        const left = (maxWidth - 400) / 2;
        const top = (maxHeight - 400) / 2;
        window1 = window.open("", "_blank", `width=400,height=400, left=${left}, top=${top}`);
        isOpen = true;
    });

    let closeWindow = document.querySelector("#closeWindow");
    closeWindow.addEventListener("click", () => {
        console.log(window1);
        if (isOpen) {
            window1.close();
            isOpen = false;
        }
        else {
            alert("No hay ventana para cerrar");
        }
    });

    let expandWindow = document.querySelector("#expandWindow");
    expandWindow.addEventListener("click", () => {
        if (isOpen) {

            if (window1.outerWidth + 30 <= maxWidth && window1.outerHeight + 30 <= maxHeight) {
                window1.resizeBy(30, 30);
            }
            else {
                alert("La ventana llegó a su límite");
            }
        }
        else {
            alert("No hay ninguna ventana abierta");
        }
    });

    let reduceWindow = document.querySelector("#reduceWindow");
    reduceWindow.addEventListener("click", () => {
        if (isOpen) {
            if (window1.outerWidth - 30 > 0 && window1.outerHeight - 30 > 0) {
                window1.resizeBy(-30, -30);
            }
            else {
                alert("La ventana llegó a su límite");
            }
        }
        else {
            alert("No hay ninguna ventana abierta");
        }
    });

    let move = document.querySelector("#move");
    move.addEventListener("click", () => {
        let posX = document.querySelector("#posX").value;
        let posY = document.querySelector("#posY").value;
        if (isOpen) {
            if (posX >= 0 && posY >= 0) {
                window1.moveTo(posX, posY);
                //Intenté validarlo pero no conseguí que funcionase 
                // if (posX + window1.outerWidth <= maxWidth && posY + window1.outerHeight <= maxHeight) {
                    //window1.moveTo(posX, posY);
                // } else {
                //     alert("La ventana no se puede mover");
                // }
            }
            else {
                alert("Tienes que introducir números enteros");
            }
        } 
        else {
            alert("No hay ninguna ventana abierta");
        }
    });
}

windowActions();

