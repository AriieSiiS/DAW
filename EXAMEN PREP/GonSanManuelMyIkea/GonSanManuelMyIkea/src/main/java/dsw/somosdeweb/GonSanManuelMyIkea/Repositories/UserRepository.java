package dsw.somosdeweb.GonSanManuelMyIkea.Repositories;

import dsw.somosdeweb.GonSanManuelMyIkea.Models.User;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.Optional;

public interface UserRepository extends JpaRepository<User, Long> {
    Optional<User> findByUserMail(String userMail);
}
