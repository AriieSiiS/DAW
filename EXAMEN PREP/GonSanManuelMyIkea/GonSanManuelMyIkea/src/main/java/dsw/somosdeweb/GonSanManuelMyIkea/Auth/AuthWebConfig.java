package dsw.somosdeweb.GonSanManuelMyIkea.Auth;

import dsw.somosdeweb.GonSanManuelMyIkea.Services.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.Lazy;
import org.springframework.security.config.annotation.method.configuration.EnableMethodSecurity;
import org.springframework.security.config.annotation.web.builders.HttpSecurity;
import org.springframework.security.config.annotation.web.configuration.EnableWebSecurity;
import org.springframework.security.web.SecurityFilterChain;

@Configuration
@EnableWebSecurity
@EnableMethodSecurity
public class AuthWebConfig {

    @Lazy
    @Autowired
    private UserService userService;

    @Bean
    SecurityFilterChain securityFilterChain(HttpSecurity http) throws Exception {

        http.authorizeHttpRequests((auth) -> auth
                .requestMatchers("/", "/register", "/login").permitAll()
                .requestMatchers("/pedidos","/pedidos/detalles", "/pedidos/crear" ,"/carrito/eliminar", "/carrito", "/productos", "/productos/detalles", "/productos/comprar").hasAnyRole("USER")
                .requestMatchers("/productos/crear", "/productos", "/productos/editar").hasRole("MANAGER")
                .requestMatchers("/usuarios", "/usuarios/lista", "/usuarios/eliminar").hasRole("ADMIN")
                .anyRequest().authenticated()
        );

        http.formLogin(form -> form
                .loginPage("/login")
                .loginProcessingUrl("/login")
                .defaultSuccessUrl("/")
                .permitAll()
        );

        http.logout(form -> form
                .logoutUrl("/logout")
                .logoutSuccessUrl("/")
        );

        http.userDetailsService(userService);

        return http.build();
    }

}
