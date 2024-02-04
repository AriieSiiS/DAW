package dsw.somosdeweb.GonSanManuelMyIkea.Repositories;

import dsw.somosdeweb.GonSanManuelMyIkea.Models.Producto;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ProductRepository extends JpaRepository<Producto, Long> {
}
