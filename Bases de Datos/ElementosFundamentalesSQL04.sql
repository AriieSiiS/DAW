-- ElementosFundamentalesSQL04

-- Página 12
--Group by (agrupando registros)
--En la base de datos parobasicas:
use parobasicas
go
--Mostrar los municipios de la ca de la rioja
select Municipio
from datoscompletostabla
where CA ='Rioja, La'
group by Municipio;
go

--Mostrar las provincias de Canarias, cantabria y Galicia. 
--Incluir el nombre de la CA en la salida.
select ca,Provincia
from datoscompletostabla
where CA in ('Canarias','Cantabria','Galicia')
group by ca,Provincia;
go

--Mostrar los municipios que están en Islas. Incluir el 
--nombre de la Isla en la salida.
select Municipio, ISLA
from datoscompletostabla
where ISLA is not null
group by Municipio, ISLA;
go

--En la base de datos turismobasicas:
use turismobasicas
go
--Sacar los países con datos, ordenado por el nombre del país.
select pais
from DatosTuristas
group by pais
order by pais;
go
--Sacar los países que hayan tenido algún dato de visitas de 
--mujeres De 25 a 44 años de más de 30000.
select pais
from DatosTuristas
where (sexo ='mujeres') and (grupoedad ='De 25 a 44 años') 
	and (turistas > 30000)
group by pais;
go


-- Página 25
-- Funciones agrupadoras y group by
--Para la BD parobasicas:
use parobasicas
go
set dateformat dmy
go

--Total de habitantes y parados por isla para datos del 1/3/2013.
select Isla,sum(Padron)as TotalHabitantes,
	SUM(TotalParoRegistrado) as TotalParados
from DatosCompletosTabla
where (fecha='1/3/2013') and (isla is not null)
group by isla;
go

--Mostrar los 3 municipios de Canarias con mayor media de parados.
select top 3 CA, Municipio, avg(Totalparoregistrado) as Mparo
from DatosCompletosTabla
where CA= 'Canarias'
group by CA, Municipio
order by Mparo desc;
go
--Cuántos municipios por provincia y CA tienen el paro por 
--encima del 20% de la población para el dato de 1/1/2013.
select CA,Provincia,count(Municipio) as NMunicipios 
from DatosCompletosTabla
where (Fecha= '1/1/2013') and TotalParoRegistrado>(Padron*20./100)
group by  CA,Provincia;
go

--Para la BD audienciasbasicas:
use audienciasbasicas
go
set dateformat dmy
go
--Cuántos programas diferentes tiene cada cadena con 
--algún share >20
select cadena, count(distinct programa) as Nprog
from Datosprogramas
where Share>20
group by cadena;
go
--Media de espectadores que han visto programas punteros 
--en la sexta los lunes, por hora de comienzo.
select datepart(hour,fechahora) as hora, 
	avg(Espectadores) as 'media de espectadores'
from Datosprogramas
where Cadena='la sexta' and datename(dw,FechaHora)='lunes'
group by datepart(hour,fechahora);
go

--Para la BD  turismobasicas:
use turismobasicas
go
set dateformat dmy
go
--Contar cuántos datos hay por grupo de edad.
select grupoedad,COUNT(*) as ndatos
from DatosTuristas
group by grupoedad
go
--Dar los 3 países con más turistas en el periodo de 2013.
select top 3 pais, sum(turistas) as SumTuristas
from DatosTuristas
where periodo=2013
group by pais
order by SumTuristas desc;
go

-- Página 37
--Filtrar grupos: Having
--Para la BD parobasicas:
use parobasicas
go
set dateformat dmy
go
--Sumar el padron de las ca con más de 5 provincias para 
--datos del 1/3/2013
select ca,SUM(padron)as TotalPadron
from DatosCompletosTabla
where Fecha='01/03/2013'
group by ca
having count (distinct Provincia)>5;
go

--Sumar el paro de las provincias con 4 islas 
--(usando having) para datos 1/1/2013.
select Provincia,
	SUM(TotalParoRegistrado) as ParoProvincias4Islas 
from DatosCompletosTabla
where Fecha='01/01/2013'
group by Provincia
having COUNT (distinct isla)=4;
go

--Para la BD audienciasbasicas:
use audienciasbasicas
go
set dateformat dmy
go
--Suma de audiencia de programas para cada cadena en 
--martes y para las cadenas con tres o menos programas.
select Cadena,SUM(Espectadores) as TotalEspectadores 
from Datosprogramas
where datename(dw,FechaHora)='martes'
group by Cadena
having COUNT (distinct programa)<=3;
go

--Mostrar las cadenas con media de share mayor que 10 
--en el horario de las 10, 11 y 12 de la mañana.
select Cadena, avg(Share) as Media
from Datosprogramas
where DATEPART(HOUR,FechaHora) in (10,11,12)
group by Cadena
having  AVG (share)>10;
go
--Para la BD  turismobasicas:
use turismobasicas
go
set dateformat dmy
go
--Mostrar la media de turistas por pais para aquellos 
--países con media mayor de 25000 en 2012
select pais,AVG (turistas) as MediaTuristaPais
from DatosTuristas
where periodo=2012
group by pais
having AVG(turistas)>25000;
go

--Mostrar los dos paises con mayor suma de turistas en 2013, 
--que tengan todos sus datos >23000.
select top 2 Pais, sum(turistas) as SumaTuristas2013
from DatosTuristas
where periodo= 2013 and turistas >23000
group by pais
order by SumaTuristas2013 desc;
go
