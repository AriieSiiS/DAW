package dsw.somosdeweb.GonSanManuelMyIkea.Services;

import dsw.somosdeweb.GonSanManuelMyIkea.Models.Carrito;
import dsw.somosdeweb.GonSanManuelMyIkea.Models.Pedido;
import dsw.somosdeweb.GonSanManuelMyIkea.Models.User;
import dsw.somosdeweb.GonSanManuelMyIkea.Repositories.CarritoRepository;
import jakarta.transaction.Transactional;
import org.springframework.context.annotation.Primary;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
@Primary
public class CarritoService {

    private final CarritoRepository carritoRepository;

    public CarritoService(CarritoRepository carritoRepository) {
        this.carritoRepository = carritoRepository;
    }
    public List<Carrito> getAllCarritos() {
        return carritoRepository.findAll();
    }

    public Carrito saveCarrito(Carrito carrito) {
        return carritoRepository.save(carrito);
    }

    public void removeCarrito(Long carritoId) {
        carritoRepository.deleteById(carritoId);
    }

    @Transactional
    public void removeALLCarritosFromUser(User user){ carritoRepository.deleteCarritosByUser(user);}

    public List<Carrito> loadCarritosPorUser(User user){ return carritoRepository.getCarritosByUser(user);}
}
