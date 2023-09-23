create database [pokemonDB8]
go
use [pokemonDB8]
go



CREATE TABLE Pokemon (
    numero_pokedex INT PRIMARY KEY IDENTITY,
    nombre VARCHAR(50) NOT NULL,
    peso DECIMAL(5, 2) NOT NULL,
    altura DECIMAL(5, 2) NOT NULL,
    id_tipo INT NOT NULL,
    es_evolucion BIT NOT NULL
);


CREATE TABLE Tipos (
    id_tipo INT PRIMARY KEY IDENTITY,
    nombre VARCHAR(20) NOT NULL
);

CREATE TABLE JuegosPokemon (
    id_juego INT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    plataforma VARCHAR(50) NOT NULL,
    fecha_lanzamiento DATE NOT NULL
);

CREATE TABLE Ataques (
    id_ataque INT PRIMARY KEY IDENTITY,
    id_pokemon INT NOT NULL,
    nombre VARCHAR(50) NOT NULL,
);


INSERT INTO Ataques (id_pokemon, nombre)
VALUES
  (5, 'Lanzallamas'),
  (5, 'Giro Fuego'),
  (5, 'Triturar'),
  (5, 'Rugido'),
  (6, 'Lanzallamas'),
  (6, 'Giro Fuego'),
  (6, 'Vuelo'),
  (6, 'Triturar'),
  (38, 'Lanzallamas'),
  (38, 'Triturar'),
  (38, 'Onda Ígnea'),
  (38, 'Fuego Fatuo'),
  (59, 'Nitrocarga'),
  (59, 'Ascuas'),
  (59, 'Gruñido'),
  (59, 'Golpe Cabeza'),
  (78, 'Nitrocarga'),
  (78, 'Ataque Rápido'),
  (78, 'Gruñido'),
  (78, 'Derribo'),
  (136, 'Giro Fuego'),
  (136, 'Lanzallamas'),
  (136, 'Rueda Fuego'),
  (136, 'Furia'),
   (4, 'Arañazo'),
    (4, 'Ascuas'),
    (4, 'Gruñido'),
    (4, 'Pantalla de Humo'),
    (37, 'Ascuas'),
    (37, 'Ataque Rápido'),
    (37, 'Rugido'),
    (37, 'Rayo Confuso'),
    (58, 'Mordisco'),
    (58, 'Ascuas'),
    (58, 'Gruñido'),
    (58, 'Rugido'),
    (77, 'Placaje'),
    (77, 'Ascuas'),
    (77, 'Malicioso'),
    (77, 'Rayo Solar'),
    (146, 'Ataque Rápido'),
    (146, 'Ascuas'),
    (146, 'Mordisco'),
    (146, 'Gruñido'),
    (146, 'Placaje'),
    (146, 'Lanzallamas'),
    (146, 'Rugido'),
    (1, 'Placaje'),
    (1, 'Gruñido'),
    (1, 'Latigazo'),
    (1, 'Drenadoras'),
    (43, 'Ácido'),
    (43, 'Somnífero'),
    (43, 'Canto Mortal'),
    (43, 'Bomba Lodo'),
    (69, 'Placaje'),
    (69, 'Gruñido'),
    (69, 'Drenadoras'),
    (69, 'Gigadrenado'),
    (69, 'Lluevehojas'),
    (69, 'Somnífero'),
    (69, 'Ráfaga'),
    (69, 'Bomba Lodo'),
    (69, 'Síntesis'),
    (69, 'Drenadoras'),
    (69, 'Golpe Cabeza'),
    (69, 'Acróbata'),
    (69, 'Espora'),
    (69, 'Zumbido'),
    (102, 'Placaje'),
    (102, 'Gruñido'),
    (102, 'Drenadoras'),
    (102, 'Confusión'),
    (114, 'Placaje'),
    (114, 'Gruñido'),
    (114, 'Drenadoras'),
    (114, 'Látigo Cepa'),
    (114, 'Pisotón'),
    (114, 'Enredadera'),
        (2, 'Gruñido'),
    (2, 'Latigazo'),
    (2, 'Drenadoras'),
    (2, 'Doble Filo'),
    (3, 'Gruñido'),
    (3, 'Latigazo'),
    (3, 'Drenadoras'),
    (3, 'Doble Filo'),
    (44, 'Gruñido'),
    (44, 'Drenadoras'),
    (44, 'Ácido'),
    (44, 'Somnífero'),
    (70, 'Gruñido'),
    (70, 'Drenadoras'),
    (70, 'Bomba Lodo'),
    (70, 'Petal Dance'),
    (103, 'Gruñido'),
    (103, 'Hoja Aguda'),
    (103, 'Hoja Afilada'),
    (103, 'Rayo Solar'),
    (115, 'Gruñido'),
    (115, 'Látigo Cepa'),
    (115, 'Pisotón'),
    (115, 'Bomba Germen'),
    (8, 'Pistola Agua'),
    (8, 'Hidrobomba'),
    (8, 'Golpe Cuerpo'),
    (8, 'Mordisco'),
    (9, 'Pistola Agua'),
    (9, 'Hidrobomba'),
    (9, 'Golpe Cuerpo'),
    (9, 'Mordisco'),
    (36, 'Onda Trueno'),
    (36, 'Rayo'),
    (36, 'Confusión'),
    (36, 'Psíquico'),
    (40, 'Onda Trueno'),
    (40, 'Rayo'),
    (40, 'Confusión'),
    (40, 'Hiperrayo'),
    (55, 'Rayo Hielo'),
    (55, 'Golpe Cuerpo'),
    (55, 'Canto Helado'),
    (55, 'Rayo Burbuja'),
    (87, 'Rayo Hielo'),
    (87, 'Golpe Cuerpo'),
    (87, 'Canto Helado'),
    (87, 'Hidrobomba'),
    (91, 'Golpe Cuerpo'),
    (91, 'Hidrobomba'),
    (91, 'Golpe Bajo'),
    (91, 'Pulso Dragón'),
    (99, 'Golpe Cuerpo'),
    (99, 'Hidrobomba'),
    (99, 'Canto Helado'),
    (99, 'Velo Sagrado'),
    (91, 'Canto Helado'),
    (91, 'Golpe Cuerpo'),
    (91, 'Pulso Dragón'),
    (91, 'Hidrobomba'),
        (7, 'Pistola Agua'),
    (7, 'Golpe Cuerpo'),
    (7, 'Cabezazo'),
    (7, 'Mordisco'),
    (35, 'Metrónomo'),
    (35, 'Beso Amoroso'),
    (35, 'Hiperrayo'),
    (35, 'Doble Filo'),
    (39, 'Canto'),
    (39, 'Golpe Cuerpo'),
    (39, 'Canto Curación'),
    (39, 'Pulso Dragón'),
    (54, 'Psicocorte'),
    (54, 'Golpe Cuerpo'),
    (54, 'Bola Sombra'),
    (54, 'Amnesia'),
    (79, 'Cabezazo Zen'),
    (79, 'Golpe Cuerpo'),
    (79, 'Golpe Cabeza'),
    (79, 'Poder Oculto'),
    (86, 'Golpe Cabeza'),
    (86, 'Golpe Cuerpo'),
    (86, 'Rayo Burbuja'),
    (86, 'Hidrobomba'),
    (90, 'Golpe Cuerpo'),
    (90, 'Golpe Cabeza'),
    (90, 'Hidropulso'),
    (90, 'Velo Sagrado'),
    (98, 'Golpe Cuerpo'),
    (98, 'Golpe Cabeza'),
    (98, 'Canto Helado'),
    (98, 'Rayo Burbuja'),
    (116, 'Salpicadura'),
    (116, 'Golpe Cuerpo'),
    (116, 'Canto'),
    (116, 'Bote'),
    (129, 'Salpicadura'),
    (129, 'Golpe Cuerpo'),
    (129, 'Canto'),
    (129, 'Saltar');





INSERT INTO JuegosPokemon (id_juego, nombre, plataforma, fecha_lanzamiento)
VALUES
    (1, 'Pokémon Rojo', 'Game Boy', '1996-02-27'),
    (2, 'Pokémon Azul', 'Game Boy', '1996-02-27'),
    (3, 'Pokémon Amarillo', 'Game Boy', '1998-09-12'),
    (4, 'Pokémon Oro', 'Game Boy Color', '1999-11-21'),
    (5, 'Pokémon Plata', 'Game Boy Color', '1999-11-21'),
    (6, 'Pokémon Cristal', 'Game Boy Color', '2000-12-14'),
    (7, 'Pokémon Rubí', 'Game Boy Advance', '2002-11-21'),
    (8, 'Pokémon Zafiro', 'Game Boy Advance', '2002-11-21'),
    (9, 'Pokémon Rojo Fuego', 'Game Boy Advance', '2004-01-29'),
    (10, 'Pokémon Verde Hoja', 'Game Boy Advance', '2004-01-29'),
    (11, 'Pokémon Esmeralda', 'Game Boy Advance', '2004-09-16'),
    (12, 'Pokémon Diamante', 'Nintendo DS', '2006-09-28'),
    (13, 'Pokémon Perla', 'Nintendo DS', '2006-09-28'),
    (14, 'Pokémon Platino', 'Nintendo DS', '2008-09-13'),
    (15, 'Pokémon Oro HeartGold', 'Nintendo DS', '2009-09-12');


-- Pokémon 1
INSERT INTO Pokemon (nombre, peso, altura, id_tipo, es_evolucion) VALUES ('Bulbasaur', 6.9, 0.7, 10, 0);

-- Pokémon 2
INSERT INTO Pokemon (nombre, peso, altura, id_tipo, es_evolucion) VALUES ('Ivysaur', 13, 1, 10, 1);

-- Pokémon 3
INSERT INTO Pokemon (nombre, peso, altura, id_tipo, es_evolucion) VALUES ('Venusaur', 100, 2, 10, 1);

-- Pokémon 4
INSERT INTO Pokemon (nombre, peso, altura, id_tipo, es_evolucion) VALUES ('Charmander', 8.5, 0.6, 6, 0);

-- Pokémon 5
INSERT INTO Pokemon (nombre, peso, altura, id_tipo, es_evolucion) VALUES ('Charmeleon', 19, 1.1, 6, 1);

-- Pokémon 6
INSERT INTO Pokemon (nombre, peso, altura, id_tipo, es_evolucion) VALUES ('Charizard', 90.5, 1.7, 6, 1);

-- Pokémon 7
INSERT INTO Pokemon (nombre, peso, altura, id_tipo, es_evolucion) VALUES ('Squirtle', 9, 0.5, 1, 0);

-- Pokémon 8
INSERT INTO Pokemon (nombre, peso, altura, id_tipo, es_evolucion) VALUES ('Wartortle', 22.5, 1, 1, 1);

-- Pokémon 9
INSERT INTO Pokemon (nombre, peso, altura, id_tipo, es_evolucion) VALUES ('Blastoise', 85.5, 1.6, 1, 1);

-- Pokémon 10
INSERT INTO Pokemon (nombre, peso, altura, id_tipo, es_evolucion) VALUES ('Caterpie', 2.9, 0.3, 2, 0);

-- Pokémon 11
INSERT INTO Pokemon (nombre, peso, altura, id_tipo, es_evolucion) VALUES ('Metapod', 9.9, 0.7, 2, 1);

-- Pokémon 12
INSERT INTO Pokemon (nombre, peso, altura, id_tipo, es_evolucion) VALUES ('Butterfree', 32, 1.1, 2, 1);

-- Pokémon 13
INSERT INTO Pokemon (nombre, peso, altura, id_tipo, es_evolucion) VALUES ('Weedle', 3.2, 0.3, 2, 0);

-- Pokémon 14
INSERT INTO Pokemon (nombre, peso, altura, id_tipo, es_evolucion) VALUES ('Kakuna', 10, 0.6, 2, 1);

-- Pokémon 15
INSERT INTO Pokemon (nombre, peso, altura, id_tipo, es_evolucion) VALUES ('Beedrill', 29.5, 1, 2, 1);

-- Pokémon 16
INSERT INTO Pokemon (nombre, peso, altura, id_tipo, es_evolucion) VALUES ('Pidgey', 1.8, 0.3, 15, 0);

INSERT INTO Pokemon (nombre, peso, altura, id_tipo, es_evolucion) 
VALUES 
       ('Pidgeotto', 30.0, 1.1, 15, 1),
       ('Pidgeot', 39.5, 1.5, 15, 1),
       ('Rattata', 3.5, 0.3, 14, 0),
       ('Raticate', 18.5, 0.7, 14, 1),
       ('Spearow', 2.0, 0.3, 15, 0),
       ('Fearow', 38.0, 1.2, 15, 1),
       ('Ekans', 6.9, 2.0, 9, 0),
       ('Arbok', 65.0, 3.5, 9, 1),
       ('Pikachu', 6.0, 0.4, 4, 0),
       ('Raichu', 30.0, 0.8, 4, 1),
       ('Sandshrew', 12.0, 0.6, 13, 0),
       ('Sandslash', 29.5, 1.0, 13, 1),
       ('Nidoran♀', 7.0, 0.4, 8, 0),
       ('Nidorina', 20.0, 0.8, 8, 1),
       ('Nidoqueen', 60.0, 1.3, 8, 1),
       ('Nidoran♂', 9.0, 0.5, 8, 0),
       ('Nidorino', 19.5, 0.9, 8, 1),
       ('Nidoking', 62.0, 1.4, 8, 1),
       ('Clefairy', 7.5, 0.6, 1, 0),
       ('Clefable', 40.0, 1.3, 1, 1),
       ('Vulpix', 9.9, 0.6, 6, 0),
       ('Ninetales', 19.9, 1.1, 6, 1),
       ('Jigglypuff', 5.5, 0.5, 1, 0),
       ('Wigglytuff', 12.0, 1.0, 1, 1),
       ('Zubat', 7.5, 0.8, 5, 0),
       ('Golbat', 55.0, 1.6, 5, 1),
       ('Oddish', 5.4, 0.5, 10, 0),
       ('Gloom', 8.6, 0.8, 10, 1),
       ('Vileplume', 18.6, 1.2, 10, 1),
       ('Paras', 5.4, 0.3, 12, 0),
       ('Parasect', 29.5, 1.0, 12, 1),
       ('Venonat', 30.0, 1.0, 14, 0),
       ('Venomoth', 12.5, 1.5, 14, 1),
       ('Diglett', 0.8, 0.2, 13, 0),
       ('Dugtrio', 33.3, 0.7, 13, 1),
       ('Meowth', 4.2, 0.4, 14, 0),
       ('Persian', 32.0, 1.0, 14, 1),
       ('Psyduck', 19.6, 0.8, 1, 0),
       ('Golduck', 76.6, 1.7, 1, 1),
       ('Mankey', 28.0, 0.5, 8, 0),
       ('Primeape', 32.0, 1.0, 8, 1),
       ('Growlithe', 19.0, 0.7, 6, 0),
       ('Arcanine', 155.0, 1.9, 6, 1),
       ('Poliwag', 12.4, 0.6, 2, 0),
       ('Poliwhirl', 20.0, 1.0, 2, 1),
       ('Poliwrath', 54.0, 1.3, 2, 1),
       ('Abra', 19.5, 0.9, 11, 0),
       ('Kadabra', 56.5, 1.3, 11, 1),
       ('Alakazam', 48.0, 1.5, 11, 1),
       ('Machop', 19.5, 0.8, 8, 0),
       ('Machoke', 70.5, 1.5, 8, 1),
       ('Machamp', 130.0, 1.6, 8, 1),
       ('Bellsprout', 4.0, 0.7, 10, 0),
       ('Weepinbell', 6.4, 1.0, 10, 1),
       ('Victreebel', 15.5, 1.7, 10, 1),
       ('Tentacool', 45.5, 0.9, 4, 0),
       ('Tentacruel', 55.0, 1.6, 4, 1),
       ('Geodude', 20.0, 0.4, 12, 0),
       ('Graveler', 105.0, 1.0, 12, 1),
       ('Golem', 300.0, 1.4, 12, 1),
       ('Ponyta', 30.0, 1.0, 6, 0),
       ('Rapidash', 95.0, 1.7, 6, 1),
       ('Slowpoke', 36.0, 1.2, 1, 0),
       ('Slowbro', 78.5, 1.6, 1, 1),
       ('Magnemite', 6.0, 0.3, 4, 0),
       ('Magneton', 60.0, 1.0, 4, 1),
       ('Farfetch', 15.0, 0.8, 15, 0),
       ('Doduo', 39.2, 1.4, 15, 0),
       ('Dodrio', 85.2, 1.8, 15, 1),
       ('Seel', 90.0, 1.1, 1, 0),
       ('Dewgong', 120.0, 1.7, 1, 1),
       ('Grimer', 30.0, 0.9, 14, 0),
       ('Muk', 30.0, 1.2, 14, 1),
       ('Shellder', 4.0, 0.3, 1, 0),
       ('Cloyster', 132.5, 1.5, 1, 1),
       ('Gastly', 0.1, 1.3, 5, 0),
       ('Haunter', 0.1, 1.6, 5, 1),
       ('Gengar', 40.5, 1.5, 5, 1),
       ('Onix', 210.0, 8.8, 12, 0),
       ('Drowzee', 32.4, 1.0, 11, 0),
       ('Hypno', 75.6, 1.6, 11, 1),
       ('Krabby', 6.5, 0.4, 1, 0),
       ('Kingler', 60.0, 1.3, 1, 1),
       ('Voltorb', 10.4, 0.5, 4, 0),
       ('Electrode', 66.6, 1.2, 4, 1),
       ('Exeggcute', 2.5, 0.4, 10, 0),
       ('Exeggutor', 120.0, 2.0, 10, 1),
       ('Cubone', 6.5, 0.4, 12, 0),
       ('Marowak', 45.0, 1.0, 12, 1),
       ('Hitmonlee', 49.8, 1.5, 8, 0),
       ('Hitmonchan', 50.2, 1.4, 8, 0),
       ('Lickitung', 65.5, 1.2, 9, 0),
       ('Koffing', 1.0, 0.6, 14, 0),
       ('Weezing', 9.5, 1.2, 14, 1),
       ('Rhyhorn', 115.0, 1.0, 13, 0),
       ('Rhydon', 120.0, 1.9, 13, 1),
       ('Chansey', 34.6, 1.1, 9, 0),
       ('Tangela', 35.0, 1.0, 10, 0),
       ('Kangaskhan', 80.0, 2.2, 9, 0),
       ('Horsea', 8.0, 0.4, 1, 0),
       ('Seadra', 25.0, 1.2, 1, 1),
       ('Goldeen', 15.0, 0.6, 1, 0),
       ('Seaking', 39.0, 1.3, 1, 1),
       ('Staryu', 34.5, 0.8, 4, 0),
       ('Starmie', 80.0, 1.1, 4, 1),
       ('Mr. Mime', 54.5, 1.3, 11, 0),
       ('Scyther', 56.0, 1.5, 2, 0),
       ('Jynx', 40.6, 1.4, 11, 0),
       ('Electabuzz', 30.0, 1.1, 4, 0),
       ('Magmar', 44.5, 1.3, 6, 0),
       ('Pinsir', 55.0, 1.5, 2, 0),
       ('Tauros', 88.4, 1.4, 9, 0),
       ('Magikarp', 10.0, 0.9, 1, 0),
       ('Gyarados', 235.0, 6.5, 4, 1),
       ('Lapras', 220.0, 2.5, 15, 0),
       ('Ditto', 4.0, 0.3, 9, 0),
       ('Eevee', 6.5, 0.3, 9, 0),
       ('Vaporeon', 29.0, 1.0, 1, 1),
       ('Jolteon', 24.5, 0.8, 4, 1),
       ('Flareon', 25.0, 0.9, 6, 1),
       ('Porygon', 36.5, 0.8, 9, 0),
       ('Omanyte', 7.5, 0.4, 12, 0),
       ('Omastar', 35.0, 1.0, 12, 1),
       ('Kabuto', 11.5, 0.5, 12, 0),
       ('Kabutops', 40.5, 1.3, 12, 1),
       ('Aerodactyl', 59.0, 1.8, 15, 0),
       ('Snorlax', 460.0, 2.1, 9, 0),
       ('Articuno', 55.4, 1.7, 7, 0),
       ('Zapdos', 52.6, 1.6, 4, 0),
       ('Moltres', 60.0, 2.0, 6, 0),
       ('Dratini', 3.3, 1.8, 3, 0),
       ('Dragonair', 16.5, 4.0, 3, 1),
       ('Dragonite', 210.0, 2.2, 3, 1),
       ('Mewtwo', 122.0, 2.0, 11, 0),
       ('Mew', 4.0, 0.4, 11, 0);





INSERT INTO Tipos (nombre) VALUES ('Agua');
INSERT INTO Tipos (nombre) VALUES ('Bicho');
INSERT INTO Tipos (nombre) VALUES ('Dragón');
INSERT INTO Tipos (nombre) VALUES ('Eléctrico');
INSERT INTO Tipos (nombre) VALUES ('Fantasma');
INSERT INTO Tipos (nombre) VALUES ('Fuego');
INSERT INTO Tipos (nombre) VALUES ('Hielo');
INSERT INTO Tipos (nombre) VALUES ('Lucha');
INSERT INTO Tipos (nombre) VALUES ('Normal');
INSERT INTO Tipos (nombre) VALUES ('Planta');
INSERT INTO Tipos (nombre) VALUES ('Psíquico');
INSERT INTO Tipos (nombre) VALUES ('Roca');
INSERT INTO Tipos (nombre) VALUES ('Tierra');
INSERT INTO Tipos (nombre) VALUES ('Veneno');
INSERT INTO Tipos (nombre) VALUES ('Volador');
