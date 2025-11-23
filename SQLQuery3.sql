use DBSISTEMA_VENTA

select * From Usuario

select u.IdUsuario, u.Documento, u.NombreCompleto, u.Correo, u.Clave, u.Estado,r.IdRol,r.Descripcion from usuario u
inner join rol r on r.IdRol = u.IdRol