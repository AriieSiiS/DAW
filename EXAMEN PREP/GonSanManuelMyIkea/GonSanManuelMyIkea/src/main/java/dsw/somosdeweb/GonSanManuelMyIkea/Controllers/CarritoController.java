package dsw.somosdeweb.GonSanManuelMyIkea.Controllers;

import dsw.somosdeweb.GonSanManuelMyIkea.Models.Carrito;
import dsw.somosdeweb.GonSanManuelMyIkea.Models.Producto;
import dsw.somosdeweb.GonSanManuelMyIkea.Models.User;
import dsw.somosdeweb.GonSanManuelMyIkea.Services.CarritoService;
import dsw.somosdeweb.GonSanManuelMyIkea.Services.ProductService;
import dsw.somosdeweb.GonSanManuelMyIkea.Services.UserService;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.security.core.Authentication;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;

import java.util.*;

@Controller
@PreAuthorize("hasAnyRole('ROLE_USER')")
public class CarritoController {

    private final CarritoService carritoService;
    private final ProductService productoService;
    private final UserService userService;

    private static final Logger logger = LoggerFactory.getLogger(UserController.class);

    public CarritoController(CarritoService carritoService, ProductService productoService, UserService userService) {
        this.carritoService = carritoService;
        this.productoService = productoService;
        this.userService = userService;
    }

    @GetMapping("/productos/comprar/{id}")
    public String comprarProducto(@PathVariable("id") int productId, Authentication authentication) {
        logger.info(authentication.getName());
            String currentUsername = authentication.getName();
            User userAct = userService.loadUserDefault(currentUsername);
            Carrito carrito1 = new Carrito(userAct);
            carrito1.setPorductID(productId);
            carritoService.saveCarrito(carrito1);
            return "redirect:/carrito/lista";
    }


    @GetMapping("/carrito/lista")
    public String getCarritos(Model model, Authentication authentication) {
        String currentUsername = authentication.getName();
        User userAct = userService.loadUserDefault(currentUsername);

        List<Carrito> carritos = carritoService.loadCarritosPorUser(userAct);
        List<Producto> productos = new ArrayList<>();

        for (Carrito carrito : carritos) {
            Optional<Producto> productoOptional = productoService.getProductById(carrito.getPorductID());
            productoOptional.ifPresent(productos::add);
        }

        double preciototal = productos.stream().mapToDouble(Producto::getProductPrice).sum();

        model.addAttribute("productos", productos);
        model.addAttribute("precioTotal", preciototal);

        return "/carrito/lista";
    }


    @GetMapping("/carrito/eliminar/{id}")
    public String eliminarCarritoConProducto(@PathVariable("id") long productId, Authentication authentication) {
        String currentUsername = authentication.getName();
        User userAct = userService.loadUserDefault(currentUsername);

        List<Carrito> carritos = carritoService.loadCarritosPorUser(userAct);

        for (Carrito carrito : carritos) {
            if (carrito.getPorductID() == productId) {
                carritoService.removeCarrito(carrito.getCarritoId());
                return "redirect:/carrito/lista";
            }
        }

        return "redirect:/carrito/lista";
    }



}
