package dsw.somosdeweb.GonSanManuelMyIkea.Models;

import jakarta.persistence.*;

@Entity
@Table(name = "municipios", schema = "myikea", catalog = "")
public class Municipios {
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Id
    @Column(name = "id_municipio", nullable = false)
    private short idMunicipioId;  // Cambiado el nombre para evitar confusión

    @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "id_provincia")
    private Provincias idProvincia;

    @Basic
    @Column(name = "cod_municipio", nullable = false)
    private int codMunicipio;

    @Basic
    @Column(name = "DC", nullable = false)
    private int dc;

    @Basic
    @Column(name = "nombre", nullable = false, length = 100)
    private String nombre;

    // Getter y Setter para idMunicipioId
    public short getIdMunicipioId() {
        return idMunicipioId;
    }

    public void setIdMunicipioId(short idMunicipioId) {
        this.idMunicipioId = idMunicipioId;
    }

    // Getter y Setter para idProvincia
    public Provincias getIdProvincia() {
        return idProvincia;
    }

    public void setIdProvincia(Provincias idProvincia) {
        this.idProvincia = idProvincia;
    }

    // Getter y Setter para codMunicipio
    public int getCodMunicipio() {
        return codMunicipio;
    }

    public void setCodMunicipio(int codMunicipio) {
        this.codMunicipio = codMunicipio;
    }

    // Getter y Setter para dc
    public int getDc() {
        return dc;
    }

    public void setDc(int dc) {
        this.dc = dc;
    }

    // Getter y Setter para nombre
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;

        Municipios that = (Municipios) o;

        if (idMunicipioId != that.idMunicipioId) return false;
        if (codMunicipio != that.codMunicipio) return false;
        if (dc != that.dc) return false;
        if (nombre != null ? !nombre.equals(that.nombre) : that.nombre != null) return false;

        return true;
    }

    @Override
    public int hashCode() {
        int result = (int) idMunicipioId;
        result = 31 * result + codMunicipio;
        result = 31 * result + dc;
        result = 31 * result + (nombre != null ? nombre.hashCode() : 0);
        return result;
    }
}
