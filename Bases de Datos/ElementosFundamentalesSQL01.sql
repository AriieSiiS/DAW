-- ElementosFundamentalesSQL01

-- Página 5
-- Colocar las instrucciones que permitan que al ejecutar 
-- el archivo sql de  creación y carga de la Base de datos 
-- del Jardín Botánico, permita el borrado cuando exista 
-- y la creación posterior.
use master;
go
if DB_ID('JardinBotanicoBasicas') is not null 
	drop database JardinBotanicoBasicas;
go
create database JardinBotanicoBasicas;
go

-- Página 16
-- Usar la base de datos RestauranteBasicas.
-- Crear la Base de Datos, sus tablas y añadir los registros 
-- que contiene el archivo sql.

use restauranteBasicas
go
--ajustar el lenguaje a ingles
set language us_english
go
-- entrar dos comidas con los id 22 y 23, con fecha 
-- 13 de marzo de 2013 y 26 de diciembre de 2013
set dateformat dmy;
go

insert into Comida (IdComida, Fecha) values (22,'13/03/2013');
insert into Comida (IdComida, Fecha) values (23, '26/12/2013');
go
--validar que ha entrado con la fecha correctamente
select fecha from Comida
where IdComida = 22;

select fecha from Comida
where IdComida = 23;
go
--ajustar el lenguaje a español
set language español
go
	
--entrar dos comidas con los id 24 y 25, con fecha 18 de marzo de 2013 y 25 de julio de 2013
-- No es necesario set dateformat dmy; go
insert into Comida (IdComida, Fecha) values (24,'18/03/2013');
insert into Comida (IdComida, Fecha) values (25, '25/07/2013');
go
-- validar que ha entrado con la fecha correctamente
select fecha from Comida
where IdComida = 24;

select fecha from Comida
where IdComida = 25;	
go
--hacer un select con filtro a traves del campo fecha. 
--Ajustarlo para que filtre correctamente
select IdComida, Fecha, CodMesa, Pagado from Comida
	where Fecha <='18/02/2012'
	
--mostrar la fecha de la tabla en un formato más claro
select IdComida,CONVERT(varchar,fecha,103) as fecha
from Comida
go
-- formatos a mano
select DATENAME(DW,fecha)+' '+
DATENAME(day,Fecha)+' de '+DATENAME(month,Fecha) +' de '
+DATENAME(year,Fecha)
from Comida

-- Página 23
-- Usar la base de datos RestauranteBasicas.
-- Crear la Base de Datos, sus tablas y añadir los 
-- registros que contiene el archivo sql.
use RestauranteBasicas
go
-- Crear una tabla TipoPlato2 igual que la TipoPlato, 
-- dando como valor por defecto del campo TipoPlato a 
-- Bebidas básicas y en el campo Agrupa a Bebida.

if OBJECT_ID('TipoPlato2') is not null 
	drop table TipoPlato2;
go

create table TipoPlato2
(CodTipoPlato integer,
TipoPlato varchar(100) default 'Bebidas Básicas',
Agrupa varchar(10) default 'Bebida');
go

-- Probar insertando varios registros a TipoPlato 
-- que obliguen a usar los 2 valores por defecto y 
-- cada uno por separado. 
insert into TipoPlato2 (CodTipoPlato,  Agrupa)
			values (1, 'comidilla');
insert into TipoPlato2 (CodTipoPlato,  TipoPlato)
			values (2, 'valor tipo plato');
insert into TipoPlato2 (CodTipoPlato)
			values (3);
go
-- Añadiendo otro registro usando la cláusula default en la 
-- lista de valores.
insert into TipoPlato2 (CodTipoPlato, TipoPlato, Agrupa)
			values (4, default,default);
go
-- Mostar los datos para comprobar que la tabla actuó 
-- como se definió.

select CodTipoPlato, TipoPlato, Agrupa from TipoPlato2
go

-- Página 34
-- Usar la base de datos RestauranteBasicas.
-- Crear la Base de Datos, sus tablas y añadir los 
-- registros que contiene el archivo sql.
use RestauranteBasicas
go

-- Mostrar los precios de cinco platos de cada comida. 
-- Ponerle nombre a la columna calculada.
select Plato,precio*5 as CincoPlatosCadaComida
from Plato
go

-- Mostrar los precios de cada comida con el 5% de descuento. 
-- Ponerle nombre a la columna calculada.
select Plato,Precio - (precio *0.05) as Descuento5PorCiento
from Plato
go

-- Modificar el precio del plato 4 sumandole 3 euros
update Plato
set precio= precio +3
where CodPlato = 4
go

select precio 
from plato
where CodPlato = 4
go

-- Calcular y explicar las siguientes operaciones matemáticas, 
-- poniéndole nombre al cálculo:

--primero ejecuta el paréntesis y luego multiplica el resultado por 6.
select (4+5)*6 as Calculo1
go

-- realiza primero la multiplicación y luego la suma
select 3+4*2 as Calculo2
go

--realiza el cambio de signo, después la multiplicación y 
--luego la suma
select -4*5+2 as Calculo3
go

--realiza el resto de dividir 22 entre 5
select 22%5 as Calculo4
go

-- De todos los tipos de plato, mostrar el campo Agrupa 
-- seguido por dos puntos y un blanco y el campo TipoPlato. 
-- Darle el nombre "Su plato" a la columna.

select Agrupa+': '+TipoPlato as "Su Plato"
from TipoPlato
go

-- Página 45
--Funciones de cadenas de caracteres.
--crear la base de datos
create database PrestamoLibros
go
use PrestamoLibros
go
--Crear la tabla y cargarla con datos
if object_id ('libros') is not null
  drop table libros;
  
create table libros(
  codigo int identity,
  titulo varchar(40) not null,
  autor varchar(20) default 'Desconocido',
  editorial varchar(20),
  precio decimal(6,2),
  cantidad tinyint default 0,
  primary key (codigo)
 );
 -- Cargar con estos datos:
 insert into libros (titulo,autor,editorial,precio)
  values('El aleph','Borges','Emece',25);
 insert into libros
  values('Java en 10 minutos','Mario Molina','Siglo XXI',50.40,100);
 insert into libros (titulo,autor,editorial,precio,cantidad)
  values('Alicia en el pais de las maravillas','Lewis Carroll','Emece',15,50);
go
--Mostrar las 3 primeras letras de todos los títulos.
select left(titulo,3) from libros;
go

--Mostrar el precio como cadena de caracteres.
select ltrim(str(precio))  
from libros;
go

--Mostrar la cadena con el titulo, un guión, el autor un guión y el recio.
select titulo+'-'+autor+'-'+ltrim(str(precio)) as libro
from libros;
go
--Mostrar las seis últimas letras del titulo y del autor.
select right(titulo,6) as tit,right(autor,6) as aut 
from libros;
go

--Mostrar el nombre del autor en mayúscula.
select UPPER(autor)as NombreAutorMayúscula 
from libros;
go

--Indicar el número de letras del autor y del título.
select LEN(autor)as 'Numero de caracteres del autor'
	,LEN(titulo)as'Numero de caracteres del Título'  
from libros;
go
--Mostrar los caracteres del 4 al 10 del autor
-- (son 7 de longitud)
select SUBSTRING(autor,4,7) 
from libros;
go

--Cambiar arroba por el carácter arroba y punto por el 
--carácter punto en el texto correoarrobahormailpuntocom
-- hacemos los cambios uno primero y después hacemos el otro
-- cambio al resultado del primero
select REPLACE (
	REPLACE('correoarrobahormailpuntocom','arroba','@') -- primer cambio
			,'punto','.'); -- segundo cambio
go

--Página 51
--Funciones Matemáticas.
--Redondear 4567.345 con 2 decimales
select round(4567.345,2);
go

--Truncar 4567.356 con 1 decimal
select round(4567.356,1,1);

--Raíz cuadrada de 625
select SQRT(625);

--Resultado y resto de dividir 16 entre 3
-- si la operación no es entera hay que redondear primero
select round(16./3,0,1) as 'resultado',16%3 as 'resto';
go
--Cuadrado de 12
select SQUARE (12);
--Valor absoluto de la diferencia 23-56
select ABS (23-56);
go

--Usar la base de datos RestauranteBasicas.
--Crear la Base de Datos, sus tablas y añadir los registros que 
--contiene el archivo sql.
use RestauranteBasicas
go
--Dar el precio del plato redondeado sin decimales.
select Plato,round(Precio,0)as PrecioRedondeado
from Plato;
go
--Resultado de dividir el precio entre diez, dando el 
--cociente entero y el resto por separado.
-- truncar la división
select Plato, precio,round(Precio/10,0,1)as cocienteentero, 
	(Precio%10)as resto 
from Plato;
go

-- Página 60
--Funciones de fecha y hora.
--Mostrar la fecha actual
select getdate() as 'Fecha Actual';
go

--Indicar el nombre del día de la semana de hoy
select datename(dw,getdate());
go
--Indicar el nº del mes de la fecha actual.
select datepart(MONTH,getdate());
go
--Calcular el número de días de diferencia entre el 25/12/2010 
--y la fecha actual.
select datediff(DAY,'2010/12/25',getdate()) 
			as 'Diferencia entre días';
go
--Dar el nº del año actual
select datepart(YEAR,getdate());
go
select year(getdate());
go
--Sumar 35 días a la fecha actual.
select dateadd(DAY,35,GETDATE());
go

--Usar la base de datos RestauranteBasicas.
use RestauranteBasicas
go
--Crear la Base de Datos, sus tablas y añadir los registros 
--que contiene el archivo sql.
--Calcular el número de días transcurridos entre la fecha 
--actual y la fecha de cada comida.
select idcomida,datediff(DAY,Fecha,getdate()) 
	as 'Días transcurridos fecha actual y fecha comida' 
from comida;

--Dar las comidas efectuadas en Domingo.
select IdComida,Fecha,CodMesa,Pagado
from Comida
where datename(dw,Fecha)='Domingo';
go

--Dar el número del mes de cada comida.
select idcomida,DATEPART(month,Fecha)as 'Número del mes' 
from Comida;
go





