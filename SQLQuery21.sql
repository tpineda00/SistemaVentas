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
