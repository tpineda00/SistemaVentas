/*select 
CONVERT(char(10),c.FechaRegistro,103)[FechaRegistro],c.TipoDocumento,c.NumeroDocumento,c.MontoTotal,
u.NombreCompleto[UsuarioRegistro],
pr.Documento[DocumentoProveedor],pr.RazonSocial,
p.Codigo[CodigoProducto],p.Nombre[NombreProducto],ca.Descripcion[Categoria],dc.PrecioCompra,dc.PrecioVenta,dc.Cantidad,dc.MontoTotal[SubTotal]

from COMPRA c
inner join USUARIO u on u.IDusuario = c.IdUsuario
inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor
inner join DETALLE_COMPRA DC on dc.IdCompra = c.IdCompra
inner join PRODUCTO p on p.IdProducto = dc.IdProducto
inner join CATEGORIA ca on ca.IdCategoria = p.IdCategoria
where CONVERT(date, c.FechaRegistro) between CONVERT(date,'26/11/2025',103)
          and CONVERT(date,'27/11/2025',103)
and pr.IdProveedor = 3*/


create PROC sp_ReporteCompras(
@fechainicio varchar(10),
@fechafin varchar(10),
@idproveedor int
)
as
begin

SET DATEFORMAT dmy;

select 
CONVERT(char(10),c.FechaRegistro,103)[FechaRegistro],c.TipoDocumento,c.NumeroDocumento,c.MontoTotal,
u.NombreCompleto[UsuarioRegistro],
pr.Documento[DocumentoProveedor],pr.RazonSocial,
p.Codigo[CodigoProducto],p.Nombre[NombreProducto],ca.Descripcion[Categoria],dc.PrecioCompra,dc.PrecioVenta,dc.Cantidad,dc.MontoTotal[SubTotal]

from COMPRA c
inner join USUARIO u on u.IDusuario = c.IdUsuario
inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor
inner join DETALLE_COMPRA DC on dc.IdCompra = c.IdCompra
inner join PRODUCTO p on p.IdProducto = dc.IdProducto
inner join CATEGORIA ca on ca.IdCategoria = p.IdCategoria
where CONVERT(date, c.FechaRegistro) between @fechainicio and @fechafin
and pr.IdProveedor = IIF(@idproveedor=0,pr.IdProveedor,@idproveedor)

end;

create PROC sp_ReporteVentas(
@fechainicio varchar(10),
@fechafin varchar(10),
@idproveedor int
)
as
begin

SET DATEFORMAT dmy;

select 
CONVERT(char(10),v.FechaRegistro,103)[FechaRegistro],v.TipoDocumento,v.NumeroDocumento,v.MontoTotal,
u.NombreCompleto[UsuarioRegistro],
v.DocumentoCliente,v.NombreCliente,
p.Codigo[CodigoProducto],p.Nombre[NombreProducto],ca.Descripcion[Categoria],dv.PrecioVenta,dv.PrecioVenta,dv.Cantidad,dv.SubTotal[SubTotal]

from VENTA v
inner join USUARIO u on u.IDusuario = v.IdUsuario
inner join DETALLE_VENTA DV on DV.IdVenta = V.IdVenta
inner join PRODUCTO p on p.IdProducto = dv.IdProducto
inner join CATEGORIA ca on ca.IdCategoria = p.IdCategoria
where CONVERT(date, v.FechaRegistro) between @fechainicio and @fechafin

end;


exec sp_ReporteCompras '26/11/2025','27/11/2025',3