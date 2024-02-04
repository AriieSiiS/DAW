package dsw.somosdeweb.GonSanManuelMyIkea.Services;

import dsw.somosdeweb.GonSanManuelMyIkea.Models.Carrito;
import dsw.somosdeweb.GonSanManuelMyIkea.Models.Pedido;
import dsw.somosdeweb.GonSanManuelMyIkea.Models.Producto;
import dsw.somosdeweb.GonSanManuelMyIkea.Models.User;
import dsw.somosdeweb.GonSanManuelMyIkea.Repositories.PedidoRepository;
import org.springframework.context.annotation.Primary;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
@Primary
public class PedidoService {

    private final PedidoRepository pedidoRepository;

    public PedidoService(PedidoRepository pedidoRepository) {
        this.pedidoRepository = pedidoRepository;
    }

    public List<Pedido> getAllPedidos(){ return  pedidoRepository.findAll(); }

    public Optional<Pedido> getPedidoById(long id){return  pedidoRepository.findById(id);}

    public Pedido savePedido(Pedido pedido){return  pedidoRepository.save(pedido);}

    public List<Pedido> loadPedidoPorUser(User user){ return pedidoRepository.getPedidosByUser(user);}

}
