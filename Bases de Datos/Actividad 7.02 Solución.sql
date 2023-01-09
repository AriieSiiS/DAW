use videojuegosbasicas

--Ejercicio 1

CREATE TABLE [Paises] (
  [idPais] INT identity primary key, 
  [Pais] VARCHAR(50)not null, 
  [codPais] char(3)not null
)

--Ejercicio 2

--a)
set identity_insert Paises on;

insert Paises
	(idPais,Pais,codPais)
	values (1, 'España', 001)

set identity_insert Paises off;

--b)

insert Paises
	(Pais,codPais)
	values ( 'Francia', 002)

--c)

insert Paises
	(Pais,codPais)
	values (null, 003)


--Ejercicio 3

update PuntuacionBasicas
set Fecha = DATEADD(month,1,Fecha)
where Plataforma='PC'

--Ejercicio 4

delete from Paises
where idpais> 1

--Ejercicio 5

select count (Juego) as 'JUEGOS PS3'
from Juegos
where Plataforma='PS3' and Tipo='Acción'

--Ejercicio 6

select top 2 Nombre
from Cliente
where Email like '%ca%' and DATENAME(month,FechaNacimiento) in ('mayo')
order by FechaNacimiento desc

--Ejercicio 7

select  top 3 Desarrollador, COUNT(distinct Juego) as Total
from Juegos
where Desarrollador like 'B%' and Tipo='Acción'
group by Desarrollador
order by Total desc

--Ejercicio 8

select COUNT(*) as 'Clientes Registrados', datename(dw,FechaRegistro) as 'día de la semana'
from Cliente
group by datename(DW,FechaRegistro), datepart(dw,FechaRegistro)
order by datepart(dw,FechaRegistro) asc

--Ejercicio 9

select plataforma, COUNT(*) AS nPuntuaciones, sum(Puntuacion) as suma, COUNT(distinct Juego) as Juegos
from PuntuacionBasicas
group by plataforma
having count(*)>6

--Ejercicio 10
select upper(nombreCliente),COUNT (*) as npunt, avg(puntuacion) as media
from PuntuacionBasicas
group by NombreCliente
having avg(puntuacion)>5 and count(*)>1
order by media desc
