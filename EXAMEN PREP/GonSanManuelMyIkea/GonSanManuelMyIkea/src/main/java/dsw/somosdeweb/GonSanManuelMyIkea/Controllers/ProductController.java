package dsw.somosdeweb.GonSanManuelMyIkea.Controllers;

import dsw.somosdeweb.GonSanManuelMyIkea.Models.*;
import dsw.somosdeweb.GonSanManuelMyIkea.Services.*;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.multipart.MultipartFile;

import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.OutputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.StandardCopyOption;
import java.util.*;


@Controller
public class ProductController {
    private final ProductService productService;

    private final MunicipiosService municipiosService;

    private final ProvinciasService provinciasService;

    public ProductController(ProductService productService, MunicipiosService municipiosService, ProvinciasService provinciasService) {
        this.productService = productService;
        this.municipiosService = municipiosService;
        this.provinciasService = provinciasService;
    }
    public static String UPLOAD_DIRECTORY = "target/classes/static/imagenes/";

    @PreAuthorize("hasAnyRole('ROLE_USER','ROLE_MANAGER')")
    @GetMapping("/productos/lista")
    public String getAllProducts(Model model)  {
        List<Producto> products = productService.getAllProducts();
        model.addAttribute("imageBasePath", "/imagenes/");
        model.addAttribute("products", products);

        return "productos/lista";
    }

    @PreAuthorize("hasAnyRole('ROLE_USER')")
    @GetMapping("/productos/detalles/{id}")
    public String verDetalles(@PathVariable("id") int productId, Model model) {
        Optional<Producto> productoOptional = productService.getProductById(productId);
        Producto producto = productoOptional.orElse(null);
        model.addAttribute("product", producto);
        return "productos/detalles";
    }

    @PreAuthorize("hasAnyRole('ROLE_MANAGER')")
    @GetMapping("/productos/crear")
    public String mostrarFormularioCreacion(Model model) {
        List<Municipios> municipios = municipiosService.getAllMunicipios();
        List<Provincias> provincias = provinciasService.getAllProvincias();
        model.addAttribute("newProduct", new Producto());
        model.addAttribute("municipios", municipios);
        model.addAttribute("provincias", provincias);

        // Agrega impresiones de log
        System.out.println("Provincias: " + provincias);
        System.out.println("Municipios: " + municipios);

        return "productos/crear";
    }

    @PreAuthorize("hasAnyRole('ROLE_MANAGER')")
    @PostMapping("/productos/crear")
    public String crearProducto(@ModelAttribute("newProduct") Producto producto, @RequestParam(value = "productImage", required = false) MultipartFile file) throws IOException {
        if (file != null && !file.isEmpty()) {
            StringBuilder fileNames = new StringBuilder();
            Path destPath = Path.of(UPLOAD_DIRECTORY + file.getOriginalFilename());
            fileNames.append(file.getOriginalFilename());
            Files.copy(file.getInputStream(), destPath, StandardCopyOption.REPLACE_EXISTING);

            System.out.printf(file.getOriginalFilename());

            producto.setProductPicture(file.getOriginalFilename());
        } else {
            producto.setProductPicture("defecto.png");
        }
        productService.saveProduct(producto);
        return "redirect:/productos/lista";
    }

    @GetMapping("productos/editar/{id}")
    public String editarProductoGet(@PathVariable Long id, Model model) {
        Optional<Producto> productoOptional = productService.getProductById(id);

        if (productoOptional.isPresent()) {
            Producto producto = productoOptional.get();

            List<Municipios> municipios = municipiosService.getAllMunicipios();
            List<Provincias> provincias = provinciasService.getAllProvincias();

            model.addAttribute("editedProduct", producto);
            model.addAttribute("municipios", municipios);
            model.addAttribute("provincias", provincias);

            return "productos/editar";
        } else {
            return "redirect:/productos";
        }
    }


    @PostMapping("productos/editar/{id}")
    public String editarProductoPost(@PathVariable Long id, @ModelAttribute("editedProduct") Producto editedProduct,
                                     @RequestParam(value = "productImage", required = false) MultipartFile file) throws IOException {
        Optional<Producto> existingProductOptional = productService.getProductById(id);

        if (existingProductOptional.isPresent()) {
            Producto existingProduct = existingProductOptional.get();

            if (file != null && !file.isEmpty()) {
                StringBuilder fileNames = new StringBuilder();
                Path destPath = Path.of(UPLOAD_DIRECTORY + file.getOriginalFilename());
                fileNames.append(file.getOriginalFilename());
                Files.copy(file.getInputStream(), destPath, StandardCopyOption.REPLACE_EXISTING);
                existingProduct.setProductPicture(file.getOriginalFilename());
            } else {
                existingProduct.setProductPicture(editedProduct.getProductPicture());
            }
            existingProduct.setProductName(editedProduct.getProductName());
            existingProduct.setProductPrice(editedProduct.getProductPrice());
            existingProduct.setProductStock(editedProduct.getProductStock());
            existingProduct.setMunicipio(editedProduct.getMunicipio());

            productService.saveProduct(existingProduct);

            return "redirect:/productos/lista";
        } else {
            return "redirect:/productos/lista";
        }
    }



}
