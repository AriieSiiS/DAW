package dsw.somosdeweb.GonSanManuelMyIkea.Repositories;

import dsw.somosdeweb.GonSanManuelMyIkea.Models.Carrito;
import dsw.somosdeweb.GonSanManuelMyIkea.Models.User;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface CarritoRepository extends JpaRepository<Carrito, Long> {
    List<Carrito> getCarritosByUser(User user);
    void deleteCarritosByUser(User user);
}
