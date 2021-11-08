DROP DATABASE IF EXISTS Diez;
CREATE DATABASE Diez;

USE Diez;

CREATE TABLE Jugador (
    usuario VARCHAR(60),
    contraseña VARCHAR(60),
    IDJugador INT PRIMARY KEY NOT NULL
)ENGINE=InnoDB;

CREATE TABLE Partida (
    ganador VARCHAR(60),
    fecha VARCHAR(60),
    IDPartida INT PRIMARY KEY NOT NULL
)ENGINE=InnoDB;


CREATE TABLE Participacion (
    IDJ INT NOT NULL,
    IDP INT NOT NULL,
    sumaCreditos INT NOT NULL,
    FOREIGN KEY (IDJ) REFERENCES Jugador(IDJugador),
    FOREIGN KEY (IDP) REFERENCES Partida(IDPartida)  
)ENGINE=InnoDB;

INSERT INTO Jugador VALUES ('Eloi', 'porros', 1);
INSERT INTO Jugador VALUES ('Alba', 'lusvui', 2);
INSERT INTO Jugador VALUES ('Marc', 'pingpong', 3);

INSERT INTO Partida VALUES ('Marc', '10/10/2021', 1);

INSERT INTO Participacion VALUES (1, 1, 500);
INSERT INTO Participacion VALUES (2, 1, 200);
INSERT INTO Participacion VALUES (3, 1, 1000);
