package dsw.somosdeweb.GonSanManuelMyIkea.Models;

import jakarta.persistence.*;

import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;

@Entity
@Table(name = "Pedido", schema = "myikea", catalog = "")
public class Pedido {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "pedido_id", nullable = false)
    private Long id;

    @Temporal(TemporalType.DATE)
    @Column(name = "fecha_pedido", nullable = false, length = 512)
    private Date fecha_pedido;

    @Basic
    @Column(name = "pedido_precioTotal", nullable = false, precision = 0)
    private double Precio_Total;


    @ManyToMany
    @JoinTable(
            name = "pedido_producto",
            joinColumns = @JoinColumn(name = "pedido_id"),
            inverseJoinColumns = @JoinColumn(name = "product_id")
    )
    private List<Producto> productos;


    @ManyToOne
    @JoinColumn(name = "user_id")
    private User user;

    public Pedido() {
        this.fecha_pedido = new Date();
    }

    public Pedido(User user){
        this.user = user;
        this.fecha_pedido = new Date();
    }

    public void setId(Long id) {
        this.id = id;
    }

    public Long getId() {
        return id;
    }

    public Date getFecha_pedido() {
        return fecha_pedido;
    }

    public void setFecha_pedido(Date fecha_pedido) {
        this.fecha_pedido = fecha_pedido;
    }

    public double getPrecio_Total() {
        return Precio_Total;
    }

    public void setPrecio_Total(double precio_Total) {
        Precio_Total = precio_Total;
    }

    public List<Producto> getProductos() {
        return productos;
    }

    public void setProductos(List<Producto> productos) {
        this.productos = productos;
    }

    public User getUser() {
        return user;
    }

    public void setUser(User user) {
        this.user = user;
    }
}


