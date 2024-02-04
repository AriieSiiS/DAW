package dsw.somosdeweb.GonSanManuelMyIkea.Services;


import dsw.somosdeweb.GonSanManuelMyIkea.Models.Producto;
import dsw.somosdeweb.GonSanManuelMyIkea.Repositories.ProductRepository;
import org.springframework.context.annotation.Primary;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
@Primary
public class ProductService {

    private final ProductRepository productRepository;

    public ProductService(ProductRepository productRepository){ this.productRepository = productRepository; }

    public List<Producto> getAllProducts(){ return  productRepository.findAll(); }

    public Optional<Producto> getProductById(long id){return  productRepository.findById(id);}

    public Producto saveProduct(Producto product){return  productRepository.save(product);}
}
