select * from CATEGORIA

INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Analgésicos', 1);
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Antibióticos', 1);
INSERT INTO CATEGORIA (Descripcion, Estado) VALUES ('Vitaminas y Suplementos', 1);


select * from PRODUCTO

INSERT INTO Producto
(Codigo, Nombre, Descripcion, IdCategoria, Estado)
VALUES
('AN001', 'Paracetamol 500mg', 'Analgésico y antipirético', 1, 1),

('AT001', 'Amoxicilina 500mg', 'Antibiótico de amplio espectro', 2, 1),

('VS001', 'Vitamina C 1000mg', 'Suplemento para fortalecer el sistema inmunológico', 3, 1);


select Idcliente,Documento,NombreCompleto,Correo,Telefono,Estado from CLIENTE

INSERT INTO Proveedor (Documento, RazonSocial, Correo, Telefono, Estado) VALUES
('0801199912345', 'Distribuidora FarmaHonduras', 'ventas@farmahonduras.com', '9876-1234', 1),

('0801199823456', 'Laboratorios Centroamericanos', 'contacto@labcentro.com', '9988-4455', 1),

('0801199734567', 'Importadora Médica San José', 'info@imsanjose.com', '9911-7788', 1),

('0801199645678', 'Droguería Nacional', 'droguerianacional@gmail.com', '9722-8899', 1),

('0801199556789', 'Distribuidora Vida y Salud', 'ventas@vidaysalud.com', '9633-5566', 1);


select * from NEGOCIO
use DBSISTEMA_VENTA

create table NEGOCIO(
IdNegocio int primary key,
Nombre varchar(60),
RUC varchar(60),
Direccion varchar(60),
Logo varbinary(max) NULL
)

insert into NEGOCIO (IdNegocio, Nombre, RUC, Direccion) values (1,'Grupo 5 Knime,UNAH-VS','000000','21102 San Pedro Sula, Cortés')