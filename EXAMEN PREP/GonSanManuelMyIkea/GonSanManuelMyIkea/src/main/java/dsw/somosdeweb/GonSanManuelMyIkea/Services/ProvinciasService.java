package dsw.somosdeweb.GonSanManuelMyIkea.Services;

import dsw.somosdeweb.GonSanManuelMyIkea.Models.Producto;
import dsw.somosdeweb.GonSanManuelMyIkea.Models.Provincias;
import dsw.somosdeweb.GonSanManuelMyIkea.Repositories.ProvinciasRepository;
import org.springframework.context.annotation.Primary;
import org.springframework.stereotype.Service;

import java.util.List;

@Primary
@Service
public class ProvinciasService {

    private final ProvinciasRepository provinciasRepository;


    public ProvinciasService(ProvinciasRepository provinciasRepository) {
        this.provinciasRepository = provinciasRepository;
    }

    public List<Provincias> getAllProvincias(){ return  provinciasRepository.findAll(); }
}
