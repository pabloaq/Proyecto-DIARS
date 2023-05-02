----------------------------------------MANTENEDOR PRODUCTO
CREATE PROCEDURE spListarProducto AS
BEGIN
	select * from Producto
END

CREATE PROCEDURE spInsertarProducto
(
@IdCategoriaProducto varchar(6),
@Nombre varchar(50),
@Stock int,
@PrecioUnitario float, 
@FechaCaducidad date
)
AS
BEGIN
	Declare @num_Producto int
	set @num_Producto = (select coalesce(Cast(max(SUBSTRING(IdProducto,3,6)) AS INT),0)+1 from Producto);
	INSERT INTO Producto VALUES('PR'+(SELECT RIGHT(REPLICATE('0', 3) + Cast(@num_Producto AS varchar), 4)),@IdCategoriaProducto,@Nombre,@Stock,@PrecioUnitario,@FechaCaducidad);
END

CREATE PROCEDURE spModificarProducto
(
@IdProducto varchar(6),
@IdCategoriaProducto varchar(6),
@Nombre varchar(50),
@Stock int,
@PrecioUnitario float, 
@FechaCaducidad date
) AS
BEGIN
	update Producto set
	IdCategoriaProducto = @IdCategoriaProducto,
	Nombre = @Nombre,
	Stock = @Stock,
	PrecioUnitario = @PrecioUnitario,
	FechaCaducidad = @FechaCaducidad
	where IdProducto = @IdProducto
END

CREATE PROCEDURE spEliminarProducto
(
@IdProducto varchar(6)
)
AS
BEGIN
	delete from Producto where IdProducto = @IdProducto
END
--------------------------------------------------------------------------------------------
----------------------------------------PEDIDO
CREATE PROCEDURE spListarPedido AS
BEGIN
	select * from Pedido
END

CREATE PROCEDURE spInsertarPedido
(
@NombreCliente varchar(50),
@IdTipoPedido varchar(6),
@Direccion varchar(50)
)
AS
BEGIN
	--'R'->Registrado
	--'P'->Preparado
	--'E'->Enviado
	Declare @num_Pedido int
	Declare @Direccion_isNull varchar(50)
	set @num_Pedido = (select coalesce(Cast(max(SUBSTRING(IdPedido,3,6)) AS INT),0)+1 from Pedido);

	IF @Direccion = 'null'
	BEGIN
		set @Direccion = NULL
	END

	INSERT INTO Pedido VALUES('PE'+(SELECT RIGHT(REPLICATE('0', 3) + Cast(@num_Pedido AS varchar), 4)),@NombreCliente,@IdTipoPedido,@Direccion,GETDATE(),'R');
END

CREATE PROCEDURE spModificarEstadoPedido
(
@IdPedido varchar(6),
@Estado char(1)
) AS
BEGIN
	update Pedido set
	Estado = @Estado
	where IdPedido = @IdPedido
END

--CREATE PROCEDURE spMostrarUltimoPedido
--AS
--BEGIN
--	select top 1 * from Pedido
--	order by IdPedido desc
--END
--------------------------------------------------------------------------------------------
----------------------------------------DETALLE PEDIDO
CREATE PROCEDURE spInsertarDetallePedido
(
@IdProducto varchar(6),
@IdPedido varchar(6),
@cantidad int
)
AS
BEGIN
	insert into DetallePedido values(@IdProducto, @IdPedido, @cantidad)
END


