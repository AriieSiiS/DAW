package dsw.somosdeweb.GonSanManuelMyIkea.Models;

import jakarta.persistence.*;

@Entity
@Table(name = "Carrito", schema = "myikea", catalog = "")
public class Carrito {

    @Id
    @GeneratedValue
    private Long carritoId;

    @Column(name = "productID")
    private int porductID;

    @ManyToOne
    @JoinColumn(name = "user_id")
    private User user;

    public Carrito(){

    }

    public Carrito(User user){
        this.user = user;
    }

    public Long getCarrito_id() {
        return carritoId;
    }

    public void setPorductID(int porductID) {
        this.porductID = porductID;
    }

    public Long getCarritoId() {
        return carritoId;
    }

    public int getPorductID() {
        return porductID;
    }

    public void setCarritoId(Long carritoId) {
        this.carritoId = carritoId;
    }

    public User getUser() {
        return user;
    }

    public void setUser(User user) {
        this.user = user;
    }
}
