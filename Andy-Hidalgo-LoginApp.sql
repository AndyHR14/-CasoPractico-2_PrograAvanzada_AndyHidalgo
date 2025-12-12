CREATE DATABASE biblioteca;
USE biblioteca; 

CREATE TABLE usuario (
    Id INT PRIMARY KEY AUTO_INCREMENT, 
    Username VARCHAR(50) UNIQUE NOT NULL, 
    Password VARCHAR(255) NOT NULL, 
    Nombre VARCHAR(100) NOT NULL
);

INSERT INTO usuario (username, password, nombre)
VALUES
('andy', 'andy1234', 'Andy Hidalgo'),
('andyhr4', 'andy1234', 'Andy Hidalgo'),
('pipo132', 'pipo1234', 'Carlos Barrantes');