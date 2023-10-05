const DOM = {
    numvalue: document.querySelector("#num"),
    fibonacci: document.getElementById("fibonacci"),
    añadir: document.getElementById("añadir")
}

// FORMA NORMAL ------------------------------------------------------------------

    // DOM.fibonacci.addEventListener("click", () => {
    //     DOM.añadir.innerHTML = "";
    //     let n = DOM.numvalue.value;
    //     let answer = "";
    //     let a = 0;
    //     let b = 1;
    //     let c = "";
    //     if (isNaN(n) || n === "") {
    //         alert("Error! - Indique un número valido");
    //     } else {
    //         for (let i = 1; i <= n; i++) {
    //             answer += "<p>" + a + "</p>";
    //             c = a + b;
    //             a = b;
    //             b = c;
    //         }
    //     }
    //     DOM.añadir.innerHTML = answer;
    // });

// FORMA RECURSIVA  ------------------------------------------------------------------

function fibonacciRecursive(n) {
    if (n === 0) {
        return 0;
    } else if (n === 1) {
        return 1;
    } else {
        return fibonacciRecursive(n - 1) + fibonacciRecursive(n - 2);
    }
}

DOM.fibonacci.addEventListener("click", () => {
    DOM.añadir.innerHTML = "";
    let n = DOM.numvalue.value;
    let answer = "";
    
    if (isNaN(n) || n === "") {
        alert("Error! - Indique un número valido");
    } else {
        for (let i = 0; i < n; i++) {
            answer += "<p>" + fibonacciRecursive(i) + "</p>";
        }
    }
    DOM.añadir.innerHTML = answer;
});

