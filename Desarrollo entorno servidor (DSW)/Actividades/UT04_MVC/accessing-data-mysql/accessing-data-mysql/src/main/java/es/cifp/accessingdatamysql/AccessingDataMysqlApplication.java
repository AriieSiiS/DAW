package es.cifp.accessingdatamysql;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.boot.autoconfigure.domain.EntityScan;

@SpringBootApplication
@EntityScan(basePackages = "es.cifp.accessingdatamysql.models")
public class AccessingDataMysqlApplication {

	public static void main(String[] args) {

		SpringApplication.run(AccessingDataMysqlApplication.class, args);
	}

}
