package dsw.somosdeweb.GonSanManuelMyIkea.Models;

import jakarta.persistence.*;
import jakarta.validation.constraints.NotBlank;
import jakarta.validation.constraints.NotNull;
import org.springframework.web.multipart.MultipartFile;

import java.util.List;

@Entity
@Table(name = "productoffer", schema = "myikea", catalog = "")
public class Producto {
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Id
    @Column(name = "product_id", nullable = false)
    private int productId;
    @Basic
    @NotBlank(message = "El nombre es obligatorio")
    @Column(name = "product_name", nullable = false, length = 512)
    private String productName;
    @Basic
    @NotNull(message = "El precio es obligatorio")
    @Column(name = "product_price", nullable = true, precision = 0)
    private Double productPrice;
    @Basic
    @Column(name = "product_picture", nullable = true, length = 512)
    private String productPicture;

    @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "id_municipio")
    @NotNull(message = "El municipio es obligatorio")
    private Municipios Municipio;

    @Basic
    @NotNull(message = "El stock es obligatorio")
    @Column(name = "product_stock", nullable = false)
    private int productStock;

    @ManyToMany(mappedBy = "productos")
    private List<Pedido> pedidos;


    public int getProductId() {
        return productId;
    }

    public void setProductId(int productId) {
        this.productId = productId;
    }

    public String getProductName() {
        return productName;
    }

    public void setProductName(String productName) {
        this.productName = productName;
    }

    public Double getProductPrice() {
        return productPrice;
    }

    public void setProductPrice(Double productPrice) {
        this.productPrice = productPrice;
    }

    public String getProductPicture() {
        return productPicture;
    }

    public void setProductPicture(String productPicture) {
        this.productPicture = productPicture;
    }

    public void setMunicipio(Municipios idMunicipio) {
        this.Municipio = idMunicipio;
    }

    public int getProductStock() {
        return productStock;
    }

    public void setProductStock(int productStock) {
        this.productStock = productStock;
    }

    public Municipios getMunicipio() {
        return Municipio;
    }

    public List<Pedido> getPedidos() {
        return pedidos;
    }

    public void setPedidos(List<Pedido> pedidos) {
        this.pedidos = pedidos;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;

        Producto that = (Producto) o;

        if (productId != that.productId) return false;
        if (Municipio != that.Municipio) return false;
        if (productStock != that.productStock) return false;
        if (productName != null ? !productName.equals(that.productName) : that.productName != null) return false;
        if (productPrice != null ? !productPrice.equals(that.productPrice) : that.productPrice != null) return false;
        if (productPicture != null ? !productPicture.equals(that.productPicture) : that.productPicture != null)
            return false;

        return true;
    }

    @Override
    public int hashCode() {
        return super.hashCode();
    }
}
