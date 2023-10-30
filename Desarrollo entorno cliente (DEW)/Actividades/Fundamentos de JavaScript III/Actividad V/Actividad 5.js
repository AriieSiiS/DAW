let cart = []; 
const products = [
    { id: 1, name: "Producto 1 ", price: 10 },
    { id: 2, name: "Producto 2 ", price: 15 },
    { id: 3, name: "Producto 3 ", price: 20 },
];

// mostramos los productos disponibles
const showProducts = () => {
    const productList = document.querySelector("#product-list");
    productList.innerHTML = "";

    products.forEach((product) => {
        const item = document.createElement("li");
        item.innerHTML = `
        <span>${product.name}-&nbsp;</span>
        <span>${product.price}&nbsp;USD</span>
            <button class="add-to-cart" data-id="${product.id}">Agregar al carrito</button>
        `;
        productList.appendChild(item);
    });
};
showProducts();

// agregar productos nuevos al carrito (de la lista de productos disponibles)
const addToCart = (productId) => {
    const product = products.find(p => p.id === productId);
    if (product) {
        cart.push(product);
        updateCart();
        //guardamos los cambios en la localstorage 
        saveCartToLocalStorage();
    }
};

// ponemos eventos de escucha en el botón de agregar al carrito
document.addEventListener("click", (event) => {
    if (event.target.classList.contains("add-to-cart")) {
        const productId = parseInt(event.target.getAttribute("data-id"));
        addToCart(productId);
    }
});

// mostramos los cambios que hemos hecho en el carrito
const updateCart = () => {
    const cartItems = document.querySelector("#cart-items");
    const totalAmount = document.querySelector("#total-price");

    // Limpiar la lista de productos en el carrito
    cartItems.innerHTML = "";

    // calculamos el precio total de la suma de todos los productos
    let totalPrice = 0;

    // metemos los productos en el carrito
    cart.forEach((product) => {
        const item = document.createElement("li");
        item.innerHTML = `
        <span>${product.name}-&nbsp;</span>
        <span>${product.price}&nbsp;USD</span>
            <button class="remove-from-cart" data-id="${product.id}">Quitar del carrito</button>
        `;
        cartItems.appendChild(item);

        totalPrice += product.price;
    });

    // precio total de los productos del carrito
    totalAmount.textContent = totalPrice + " USD";
};

updateCart();

// quitar un producto del carrito 
const removeFromCart = (productId) => {
    // buscamos que producto hay que quitar usando al id que le hemos pasado al llamar a la función
    const index = cart.findIndex((product) => product.id === productId);

    if (index !== -1) {
        cart.splice(index, 1); 
        //al quitarlo llamamos a la función que muestra el estado del carrito para que se actualice y guardamos los cambios
        //en la local storage
        updateCart(); 
        saveCartToLocalStorage();
    }
};

document.addEventListener("click", (event) => {
    if (event.target.classList.contains("remove-from-cart")) {
        const productId = parseInt(event.target.getAttribute("data-id"));
        removeFromCart(productId); //llamamos a la función pasandole el id del producto que vamos a borrar
    }
});

// Limpiar todo el contenido del carrito
const clearCart = () => {
    cart = []; 
    updateCart(); 
    saveCartToLocalStorage();
};

document.querySelector("#clear-cart").addEventListener("click", clearCart);

// guardamos el carrito en la localstorage 
const saveCartToLocalStorage = () => {
    console.log("El carrito se ha guardado");
    localStorage.setItem("cart", JSON.stringify(cart));
};

// cargamos el carrito en la local storage
const loadCartFromLocalStorage = () => {

    const savedCart = localStorage.getItem("cart");
    if (savedCart) {
        cart = JSON.parse(savedCart);
        updateCart();
        console.log("El carrito se ha cargado");
    }
};

// y llamamos a la función para que si el carrito existe pues lo cargue 
loadCartFromLocalStorage();
