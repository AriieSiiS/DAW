-- ElementosFundamentalesSQL02

-- P�gina 10
--Ordenar registros
--Usar la base de datos RestauranteBasicas.
-- Crear la Base de Datos, sus tablas y a�adir los 
-- registros que contiene el archivo sql.
use RestauranteBasicas;
go
--Sacar los platos ordenados por su nombre.
select CodPlato,Plato,Precio,CodTipoPlato 
from Plato
order by Plato asc;
go
--Sacar los platos ordenados por su precio de mayor a menor.
select CodPlato,Plato,Precio,CodTipoPlato 
from Plato
order by Precio desc;
go
--Sacar los platos ordenados por codtipoplato y precio
select Plato,CodTipoPlato,Precio 
from Plato
order by CodTipoPlato,Precio;
--Sacar las comidas con pagado a S y ordenadas por 
--el n�mero del mes.
select Pagado,IdComida,Fecha,CodMesa,
	DATENAME(MONTH,Fecha)
from Comida
where (Pagado= 'S')
order by datepart(MONTH,Fecha);
go


-- P�gina 20
--Operadores l�gicos, Condiciones m�tiples
--Usar la base de datos RestauranteBasicas.
--Crear la Base de Datos, sus tablas y a�adir los registros 
--que contiene el archivo sql.
use RestauranteBasicas;
go
--Sacar los platos con nombre comenzando por A o C.
select CodPlato,Plato,Precio,CodTipoPlato
from Plato
where
((SUBSTRING(Plato,1,1)='A')
  or
 (SUBSTRING(Plato,1,1)='C'));
go
--Sacar los platos con nombre que no comiencen ni 
-- por A ni por C.
select CodPlato,Plato,Precio,CodTipoPlato
from Plato
where not
((SUBSTRING(Plato,1,1)='A')
  or
 (SUBSTRING(Plato,1,1)='C'));
go
--Sacar los platos con precio entre 10 y 20 
--(incluyendo ambos valores)
select CodPlato,Plato,Precio,CodTipoPlato
from Plato
where (Precio>=10) and (Precio<=20);
go

--Sacar los platos con codtipoplato menor que 3 o 
--con precio menor que 60
select CodPlato,Plato,Precio,CodTipoPlato
from Plato
where (CodTipoPlato<3) or (Precio<60);
go

--Sacar las comidas con pagado a S y de la semana viernes.
select Pagado,IdComida,Fecha,CodMesa,
	DATENAME(DW,Fecha) 
from Comida
where (pagado='S') and (datename(DW,Fecha) = 'Viernes');
go

-- P�gina 26
--Operador between
--Usar la base de datos RestauranteBasicas.
--Crear la Base de Datos, sus tablas y a�adir los registros que 
--contiene el archivo sql.
use RestauranteBasicas;
go
--Sacar los platos con nombre comenzando por las letras entre A y C.
select CodPlato,Plato,Precio,CodTipoPlato
from Plato
where substring (Plato,1,1) between 'A' and 'C';
go
--Sacar los platos con precio entre 10 y 20 
--(incluyendo ambos valores)
select CodPlato,Plato,Precio,CodTipoPlato
from Plato
where Precio between 10 and 20;
go
--Sacar las comidas entre los meses de marzo y diciembre.
-- cambiados los meses para que tenga resultados
select IdComida,Fecha,CodMesa,Pagado,
	DATENAME(month,Fecha)
from Comida
where DATEPART(month,Fecha) between 3 and 12;
go

-- P�gina 33
--Ejercicio Operador in.
--Usar la base de datos RestauranteBasicas.
--Crear la Base de Datos, sus tablas y a�adir los registros 
--que contiene el archivo sql.
use RestauranteBasicas;
go
--Sacar los platos con nombre comenzando por las vocales.
select CodPlato,Plato,Precio,CodTipoPlato
from Plato
where SUBSTRING(Plato,1,1) in ('a','e','i','o','u');
go
--Sacar los platos con precio 6, 9 ,11 o 16.
select CodPlato,Plato,Precio,CodTipoPlato
from Plato
where Precio in (6,9,11,16);
go
--Sacar los tipo plato que comienzan con A, B o C
select CodTipoPlato,TipoPlato,Agrupa
from TipoPlato
where substring(TipoPlato,1,1) in ('A','B','C');
go 
--Sacar las comidas con d�a de la semana en su fecha Lunes, 
-- Jueves o s�bado
--retocado para que salgan m�s resultados
select IdComida,Fecha,CodMesa,Pagado,
	DATENAME(dw,Fecha)
from Comida
where DATEname(dw,Fecha) in ('lunes', 'jueves', 'sabado');
go

-- P�gina 46
--Ejercicio Like.
--Usar la base de datos RestauranteBasicas.
--Crear la Base de Datos, sus tablas y a�adir los 
--registros que contiene el archivo sql.
use RestauranteBasicas;
go
--Sacar los platos con nombre comenzando por A hasta F.
select CodTipoPlato,Plato,Precio,CodTipoPlato
from Plato
where Plato like '[A-F]%';
go
--Sacar los tipo de plato que contengan ca en el 
--campo TipoPlato.
-- retocado para que salgan m�s resultados
select CodTipoPlato,TipoPlato,Agrupa
from TipoPlato
where TipoPlato like '%ca%';
go

--Sacar las comidas en las mesas que tengan un 1 o un 2 en 
--el tercer car�cter.
select IdComida,Fecha,CodMesa,Pagado
from Comida
where CodMesa like '__[12]%';
go
--Sacar los platos que contengan Lenguado o Salm�n en el campo Plato.
select CodTipoPlato,Plato,Precio,CodTipoPlato
from Plato
where (Plato like '%Lenguado%') or (Plato like '%Salm�n%');
go
--Sacar los platos que no tengan m�nimo en el campo plato.
select CodTipoPlato,Plato,Precio,CodTipoPlato
from Plato
where Plato  not like '%m�nimo%';
go
--sacar los platos cuyo campo plato terminen con C�sar.
select CodTipoPlato,Plato,Precio,CodTipoPlato
from Plato
where Plato like '%C�sar';
go