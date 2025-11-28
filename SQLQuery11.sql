--procedimiento  para categorira

create PROC SP_RegistrarCategoria(
@Descripcion varchar(50),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
begin 
    SET @Resultado = 0
	IF NOT EXISTS (SELECT * FROM CATEGORIA WHERE Descripcion = @Descripcion)
	begin
	   insert into CATEGORIA(Descripcion,Estado) values (@Descripcion,@Estado)
	   set @Resultado = SCOPE_IDENTITY()
    end
	ELSE
	   set @Mensaje = 'No se puede repetir la descripcion de una categoria'
end

go


-- PROCEDIMIENTO PARA EDITAR CATEGORIA
create procedure sp_EditarCategoria(
@IdCategoria int,
@Descripcion varchar(50),
@Estado bit,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
   begin
       SET @Resultado = 1
       IF NOT EXISTS (SELECT * FROM CATEGORIA WHERE Descripcion =@Descripcion and IdCategoria != @IdCategoria)
          update CATEGORIA set
          Descripcion = @Descripcion,
		  Estado = @Estado
          where IdCategoria = @IdCategoria
      ELSE
      begin
          SET @Resultado = 0
          set @Mensaje = 'No se puede repetir la descripcion de una categoria'

       end

end

go

-- PROCEDIMIENTO PARA Eliminar CATEGORIA
create procedure sp_ElminarCategoria(
@IdCategoria int,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
     SET @Resultado = 1
     IF NOT EXISTS (
       select * from CATEGORIA c
       inner join PRODUCTO p on p. IdCategoria = c.IdCategoria
       where c.IdCategoria = @IdCategoria
     )
    begin
       delete top(1) from CATEGORIA where IdCategoria = @IdCategoria
    end
    ELSE
    begin
      SET @Resultado = 0
      set @Mensaje = 'La categoria se encuentara relacionada a un producto'

     end

end

go

/* ---- precedimiento producto---*/

create PROC sp_RegistrarProducto(
@Codigo varchar(20),
@Nombre varchar(30),
@Descripcion varchar(30),
@IdCategoria int,
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
    begin
           SET @Resultado = 0
           IF NOT EXISTS (SELECT * FROM producto WHERE Codigo = @Codigo)
           begin
               insert into producto(Codigo, Nombre,Descripcion, IdCategoria,Estado) values (@Codigo,@Nombre,@Descripcion,@IdCategoria,@Estado)
               set @Resultado = SCOPE_IDENTITY()
           end
           ELSE
             SET @Mensaje = 'Ya existe un producto con el mismo codigo'

end

go
/* ---- precedimiento Modificar producto---*/

create procedure sp_ModificarProducto(
@IdProducto int,
@Codigo varchar(20),
@Nombre varchar(30),
@Descripcion varchar(30),
@IdCategoria int,
@Estado bit,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
        SET @Resultado = 1
        IF NOT EXISTS (SELECT * FROM PRODUCTO WHERE codigo = @Codigo and IdProducto != @IdProducto)

          update PRODUCTO set
          codigo = @Codigo,
          Nombre = @Nombre,
          Descripcion = @Descripcion,
          IdCategoria = @IdCategoria,
          Estado = @Estado
          where IdProducto = @IdProducto
   ELSE
     begin
        SET @Resultado = 0
        SET @Mensaje = 'Ya existe un producto con el mismo codigo'

     end

end

go

/* ---- precedimiento Eliminar producto---*/


create PROC SP_EliminarProducto(
@IdProducto int,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
      set @Respuesta = 0
      set @Mensaje = ''
      declare @pasoreglas bit = 1

      IF EXISTS (SELECT * FROM DETALLE_COMPRA dc
      INNER JOIN PRODUCTO p ON p. IdProducto = dc. IdProducto
      WHERE p.IdProducto = @IdProducto
     )
      BEGIN
          set @pasoreglas = 0
          set @Respuesta = 0
          set @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una COMPRA\n'
      END

      IF EXISTS (SELECT * FROM DETALLE_VENTA dv
      INNER JOIN PRODUCTO p ON p.IdProducto = dv.IdProducto
      WHERE p.IdProducto = @IdProducto
      )
     BEGIN
        set @pasoreglas = 0
        set @Respuesta = 0
        set @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una VENTA\n'
     END

      if(@pasoreglas = 1)
     begin
        delete from PRODUCTO where IdProducto = @IdProducto
        set @Respuesta = 1
     end

end


/*-----------Procedimiento Cliente---------*/

create PROC sp_RegistrarCliente(
@Documento varchar(50),
@NombreCompleto varchar(50),
@Correo varchar(50),
@Telefono varchar(50),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
   begin
      SET @Resultado = 0
      DECLARE @IDPERSONA INT
      IF NOT EXISTS (SELECT * FROM CLIENTE WHERE Documento = @Documento)
      begin
          insert into CLIENTE(Documento, NombreCompleto, Correo, Telefono, Estado) values (
          @Documento,@NombreCompleto,@Correo,@Telefono,@Estado)

         set @Resultado = SCOPE_IDENTITY()
      end
    else
        set @Mensaje = 'El numero de documento ya existe'

end


go


create PROC sp_ModificarCliente(
@IdCliente int,
@Documento varchar(50),
@NombreCompleto varchar(50),
@Correo varchar(50),
@Telefono varchar(50),
@Estado bit,
@Resultado bit output,
@Mensaje varchar(500) output
)as
     begin
        SET @Resultado = 1
        DECLARE @IDPERSONA INT
        IF NOT EXISTS (SELECT * FROM CLIENTE WHERE Documento = @Documento and IdCliente != @IdCliente)
     begin
        update CLIENTE set
        Documento = @Documento,
        NombreCompleto = @NombreCompleto,
        Correo = @Correo,
        Telefono = @Telefono,
        Estado = @Estado
        where IdCliente = @IdCliente
     end
     else
     begin
       SET @Resultado = 0
       set @Mensaje = 'El numero de documento ya existe'
      end
end

/*------Procedimiento Proveedor---*/

create PROC sp_RegistrarProveedor(
@Documento varchar(50),
@RazonSocial varchar(50),
@Correo varchar(50),
@Telefono varchar(50),
@Estado bit,
@Resultado int output,
@Mensaje varchar(500) output
)as
  begin
      SET @Resultado = 0
      DECLARE @IDPERSONA INT
      IF NOT EXISTS (SELECT * FROM PROVEEDOR WHERE Documento = @Documento)
      begin
       insert into PROVEEDOR (Documento,RazonSocial,Correo,Telefono,Estado) values (
       @Documento,@RazonSocial,@Correo,@Telefono,@Estado)

         set @Resultado = SCOPE_IDENTITY()
      end
   else
      set @Mensaje = 'El numero de documento ya existe'
   end
GO

create PROC sp_ModificarProveedor(
@IdProveedor int,
@Documento varchar(50),
@RazonSocial varchar(50),
@Correo varchar(50),
@Telefono varchar(50),
@Estado bit,
@Resultado bit output,
@Mensaje varchar(500) output
)as
begin
     SET @Resultado = 1
     DECLARE @IDPERSONA INT
     IF NOT EXISTS (SELECT * FROM PROVEEDOR WHERE Documento = @Documento and IdProveedor != @IdProveedor)
     begin
       update PROVEEDOR set
       Documento = @Documento,
       RazonSocial = @RazonSocial,
       Correo = @Correo,
       Telefono = @Telefono,
       Estado = @Estado
       where IdProveedor = @IdProveedor
	 end
     else
     begin
       SET @Resultado = 0
       set @Mensaje = 'El numero de documento ya existe'
     end
end

go


create procedure sp_EliminarProveedor(
@IdProveedor int,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin
     SET @Resultado = 1
     IF NOT EXISTS (
         select * from PROVEEDOR P
         inner join COMPRA c on p.IdProveedor = c. IdProveedor
         where p.IdProveedor = @IdProveedor
     )
      begin
        delete top(1) from PROVEEDOR where IdProveedor = @IdProveedor
      end
   ELSE
      begin
        SET @Resultado = 0
        set @Mensaje = 'El proveedor se encuentara relacionado a una compra'
      end

end
