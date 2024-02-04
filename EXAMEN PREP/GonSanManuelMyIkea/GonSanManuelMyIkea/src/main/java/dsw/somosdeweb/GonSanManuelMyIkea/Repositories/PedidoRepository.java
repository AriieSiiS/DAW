package dsw.somosdeweb.GonSanManuelMyIkea.Repositories;

import dsw.somosdeweb.GonSanManuelMyIkea.Models.Carrito;
import dsw.somosdeweb.GonSanManuelMyIkea.Models.Pedido;
import dsw.somosdeweb.GonSanManuelMyIkea.Models.User;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface PedidoRepository extends JpaRepository<Pedido, Long> {
    List<Pedido> getPedidosByUser(User user);
}
