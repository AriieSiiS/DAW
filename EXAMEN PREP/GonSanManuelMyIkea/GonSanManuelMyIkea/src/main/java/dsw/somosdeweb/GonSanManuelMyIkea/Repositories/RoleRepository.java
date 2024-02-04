package dsw.somosdeweb.GonSanManuelMyIkea.Repositories;

import dsw.somosdeweb.GonSanManuelMyIkea.Models.Roles;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.Optional;

public interface RoleRepository extends JpaRepository<Roles, Long> {
    Optional<Roles> findByRole(String roleName);
}
