CREATE TABLE Videojuegos (
    Id_Juego INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL
);


INSERT INTO Videojuegos (Nombre, Precio)
VALUES
('Grand Theft Auto V', 59.99),
('FIFA 24', 49.99),
('The Legend of Zelda: Breath of the Wild', 69.99),
('Call of Duty: Modern Warfare 3', 79.99),
('Minecraft', 29.99);


select * from Videojuegos

select * from Departamento
select * from Tabla_Empleados