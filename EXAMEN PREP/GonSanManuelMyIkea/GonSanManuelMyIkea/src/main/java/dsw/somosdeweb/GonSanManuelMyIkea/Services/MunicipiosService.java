package dsw.somosdeweb.GonSanManuelMyIkea.Services;

import dsw.somosdeweb.GonSanManuelMyIkea.Models.Municipios;
import dsw.somosdeweb.GonSanManuelMyIkea.Repositories.MunicipiosRepository;
import org.springframework.context.annotation.Primary;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
@Primary
public class MunicipiosService {

    private final MunicipiosRepository municipiosRepository;


    public MunicipiosService(MunicipiosRepository municipiosRepository) {
        this.municipiosRepository = municipiosRepository;
    }

    public List<Municipios> getAllMunicipios(){ return  municipiosRepository.findAll();}
}
