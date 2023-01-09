-- ElementosFundamentalesSQL03

use parobasicas
go

-- P�gina 11
--Contar Registros(count)
--Contar n� de registros con provincia Santa Cruz de Tenerife
select COUNT(*) as NumeroRegistros
from DatosCompletosTabla
where Provincia='Santa Cruz de Tenerife';
go

--Contar el n�mero de Islas diferentes
select count(distinct isla)as NumeroDeIslas
from DatosCompletosTabla;
go

--Contar el n� de Municipios de la provincia de "Palmas, Las"
select count(distinct Municipio) as 'Municipios Las Palmas'
from DatosCompletosTabla
where Provincia ='Palmas, Las';
go

--Contar el n�mero de registros del segundo mes del a�o
select COUNT(*) as 'Registros febrero'
from DatosCompletosTabla
where Datepart(month,fecha)=2;
go

--Igual que el anterior si el n�mero fuera muy grande
select COUNT_big(*)
from DatosCompletosTabla
where Datepart(month,fecha)=2;
go

--Contar los registros con menos de 1000 habitantes con islas
select COUNT(ISLA) as 'registros con isla'--isla not null
from DatosCompletosTabla
where Padron < 1000;
go

--Contar las comunidades aut�nomas que contengan una E.
select count(distinct CA) as 'Comunidades con E'
from DatosCompletosTabla
where ca like '%E%';
go

-- P�gina 16
--Sumar campos (sum)
--Sumar el padr�n a fecha '01/03/2013' de la provincia de 
--Santa Cruz de Tenerife
set dateformat dmy
select sum(padron) as 'Padr�n S/C Tfe'
from DatosCompletosTabla
where (fecha='01/03/2013') and (provincia='Santa Cruz de Tenerife');
go
--Sumar el paro a fecha '01/02/2013' de los municipios de 
--la comunidad aut�noma de "Madrid, Comunidad de"
set dateformat dmy
select sum(TotalParoRegistrado) as 'Paro Madrid'
from DatosCompletosTabla
where (fecha='01/02/2013') and (CA='Madrid, Comunidad de');
go
--Sumar los habitantes a fecha '01/02/2013' de las 
--Comunidades aut�nomas de Extremadura, Andaluc�a, Arag�n y Canarias
set dateformat dmy
select sum(Padron)
from DatosCompletosTabla
where (fecha='01/02/2013') and 
(CA in ('Extremadura','Andaluc�a','Arag�n','Canarias'));
go

-- P�gina 24
--Resto de funciones agrupadoras: max, min, avg, stdev y var.
--Calcular n� de registros, n� de registros con isla, media de paro,
--suma de padr�n, varianza de padr�n  de los datos de Canarias 
--y Andaluc�a de fecha 01/02/2013.
select count(*) as Nregistros, 
	count(isla) as NIslas,
	avg(TotalParoRegistrado) as MParo,
	sum(Padron) as SumaPadron,
	var(padron) as VarPadron
from DatosCompletosTabla
where (fecha='01/02/2013') and 
((CA='Canarias') or (CA='Andaluc�a'));
go
--Calcular la media de los datos de paro de los registros con isla.
select avg(TotalParoRegistrado) as MediaParo
from DatosCompletosTabla
where ISLA is not null;
go
--Calcular la media y la desviaci�n t�pica de los datos de padr�n 
--de los municipios que contengan Villa.
select avg(Padron) as MediaParo,
	stdev(Padron) as DesviacionTipica
from DatosCompletosTabla
where Municipio like '%Villa%';
go

-- P�gina 28
--Cl�usula distinct
--Mostrar los nombres de las provincias (s�lo una vez), ordenados.
select distinct Provincia
from DatosCompletosTabla
order by Provincia;
go
--Mostrar los nombres de los municipios de Arag�n (s�lo una vez), 
--ordenados.
select distinct Municipio
from DatosCompletosTabla
where CA = 'Arag�n'
order by Municipio;
go

-- P�gina 34
--Cl�usula TOP
--Mostrar los 10 municipios con m�s habitantes  dentro 
--de los de menos de 1000. Datos de fecha 01/03/2013
select top 10 municipio,Padron 
from DatosCompletosTabla
where (padron<1000) and (fecha='01/03/2013')
order by padron desc;
go
--Mostrar los 10 municipios con m�s parados dentro de 
--los de menos de 100 habitantes, sacando los que empaten 
--con el �ltimo. Datos de fecha 01/01/2013.
select top 10 with ties Municipio,TotalParoRegistrado 
from DatosCompletosTabla
where (padron<100) and (fecha='01/01/2013')
order by TotalParoRegistrado desc;
go

--Mostrar los 10 municipios de Canarias con menor cociente 
--paro partido por habitantes. Datos de fecha 01/01/2013
select top 10 Municipio, 
 (CAST(TotalParoRegistrado as float) / Cast(Padron as float)) 
		as CocientePadron
from DatosCompletosTabla
where (CA='Canarias') and (fecha='01/01/2013')
order by CocientePadron asc;
go