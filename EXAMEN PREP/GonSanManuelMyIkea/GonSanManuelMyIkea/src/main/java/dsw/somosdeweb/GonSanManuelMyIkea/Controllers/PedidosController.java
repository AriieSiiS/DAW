package dsw.somosdeweb.GonSanManuelMyIkea.Controllers;

import dsw.somosdeweb.GonSanManuelMyIkea.Models.Carrito;
import dsw.somosdeweb.GonSanManuelMyIkea.Models.Pedido;
import dsw.somosdeweb.GonSanManuelMyIkea.Models.Producto;
import dsw.somosdeweb.GonSanManuelMyIkea.Models.User;
import dsw.somosdeweb.GonSanManuelMyIkea.Services.CarritoService;
import dsw.somosdeweb.GonSanManuelMyIkea.Services.PedidoService;
import dsw.somosdeweb.GonSanManuelMyIkea.Services.ProductService;
import dsw.somosdeweb.GonSanManuelMyIkea.Services.UserService;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.security.core.Authentication;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.Optional;

@Controller
@PreAuthorize("hasAnyRole('ROLE_USER')")
public class PedidosController {
    private final CarritoService carritoService;
    private final ProductService productoService;
    private final PedidoService pedidoService;

    private final UserService userService;

    public PedidosController(CarritoService carritoService, ProductService productoService, PedidoService pedidoService, UserService userService) {
        this.carritoService = carritoService;
        this.productoService = productoService;
        this.pedidoService = pedidoService;
        this.userService = userService;
    }

    @GetMapping("/pedidos/crear")
    public String crearPedido(Model model, Authentication authentication) {
        String currentUsername = authentication.getName();
        User userAct = userService.loadUserDefault(currentUsername);


        List<Carrito> carritos = carritoService.loadCarritosPorUser(userAct);
        List<Producto> productos = new ArrayList<>();

        for (Carrito carrito : carritos) {
            Optional<Producto> productoOptional = productoService.getProductById(carrito.getPorductID());
            productoOptional.ifPresent(productos::add);
        }

        if (productos.isEmpty()) {
            return "redirect:/carrito/lista";
        }

        double precioTotal = productos.stream().mapToDouble(Producto::getProductPrice).sum();

        Pedido pedido = new Pedido();
        pedido.setFecha_pedido(new Date());
        pedido.setPrecio_Total(precioTotal);
        pedido.setProductos(productos);
        pedido.setUser(userAct);
        pedidoService.savePedido(pedido);
        carritoService.removeALLCarritosFromUser(userAct);
        return "redirect:/pedidos/lista";
    }


    @GetMapping("/pedidos/lista")
    public String listarPedidos(Model model, Authentication authentication) {
        String currentUsername = authentication.getName();
        User userAct = userService.loadUserDefault(currentUsername);
        List<Pedido> pedidos = pedidoService.loadPedidoPorUser(userAct);
        model.addAttribute("pedidos", pedidos);
        return "/pedidos/lista";
    }

    @GetMapping("/pedidos/detalles/{id}")
    public String mostrarDetallesPedido(@PathVariable("id") Long pedidoId, Model model) {
        Optional<Pedido> pedidoOptional = pedidoService.getPedidoById(pedidoId);

        if (pedidoOptional.isPresent()) {
            Pedido pedido = pedidoOptional.get();
            model.addAttribute("pedido", pedido);
            return "/pedidos/detalles";
        } else {
            return "redirect:/pedido/lista";
        }
    }
}
