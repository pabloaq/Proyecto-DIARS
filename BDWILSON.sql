CREATE DATABASE BDWILSON

CREATE TABLE Rol(
	IdRol int primary key identity(1,1),
	rolname varchar(40) unique,
)

CREATE TABLE Usuario(
	IdUsuario varchar(7) primary key,
	username varchar(50) unique not null,
	contraseña varchar(50) not null,
	DNI int not null,
	Apellidos varchar(70) not null,
	Nombres varchar(70) not null,
	rol int foreign key references Rol(IdRol),
)

CREATE TABLE CategoriaProducto(
	IdCategoriaProducto varchar(6) primary key not null,
	categoriaNombre varchar(50)
)

CREATE TABLE Producto(
	IdProducto varchar(6) primary key not null,
	IdCategoriaProducto varchar(6),
	Nombre varchar(50) NOT NULL,
	Stock int NOT NULL,
	PrecioUnitario float NOT NULL, 
	FechaCaducidad date NULL,
	CONSTRAINT FK_Producto_categoria FOREIGN KEY (IdCategoriaProducto) REFERENCES CategoriaProducto (IdCategoriaProducto)
)

CREATE TABLE CategoriaMetodoPago (
	IdCategoriaMetodoPago varchar(6) primary key NOT NULL,
	nombre varchar(50) NOT NULL
)

CREATE TABLE TipoPedido(
	IdTipoPedido varchar(6) primary key,
	Nombre varchar(50)
)

CREATE TABLE Pedido(
	IdPedido varchar(6) primary key,
	NombreCliente varchar(50) null,
	IdTipoPedido varchar(6),
	Direccion varchar(50) null,
	FechaRegistro Date,
	Estado char,
	CONSTRAINT FK_pedido_tipopedido FOREIGN KEY (IdTipoPedido) REFERENCES TipoPedido (IdTipoPedido)
)

CREATE TABLE DetallePedido(
	IdProducto varchar(6),
	IdPedido varchar(6),
	cantidad int not null,
	CONSTRAINT PK_DETALLEPEDIDO PRIMARY KEY (IdProducto,IdPedido),
	CONSTRAINT FK_DETALLEPEDIDO_PRODUCTO FOREIGN KEY (IdProducto) REFERENCES Producto (IdProducto),
	CONSTRAINT FK_DETALLEPEDIDO_PEDIDO FOREIGN KEY (IdPedido) REFERENCES Pedido (IdPedido)
)

CREATE TABLE Comprobante(
	idComprobante varchar(6) Primary Key,
	IdLocal varchar(6) not null,
	IdPedido varchar(6) not null,
	IdMetodoPago varchar(6) not null,
	MontoTotal float not null,
	FechaRegistro Date not null,
	CONSTRAINT FK_Comprobante_Local FOREIGN KEY (IdLocal) REFERENCES  (IdLocal),
	CONSTRAINT FK_Comprobante_Pedido FOREIGN KEY (IdPedido) REFERENCES Pedido (IdPedido),
	CONSTRAINT FK_Comprobante_MetodoPago FOREIGN KEY (IdMetodoPago) REFERENCES MetodoPago (IdMetodoPago)
)


-- PROCEDIMIENTOS CATEGORIA METODO DE PAGO

--LISTAR--
CREATE OR ALTER PROCEDURE spListarCategoriaMetodoPago
AS
BEGIN 
	SELECT * FROM CategoriaMetodoPago;
END;

--INSERTAR--
CREATE OR ALTER PROCEDURE spInsertarCategoriaMetodoPago(
	@IdCategoriaMetodoPago VARCHAR(6),
	@Nombre VARCHAR(50)
)AS
BEGIN
	INSERT INTO CategoriaMetodoPago VALUES(@IdCategoriaMetodoPago, @Nombre);
END;

--MODIFICAR--
CREATE OR ALTER PROCEDURE spModificarCategoriaMetodoPago(
	@IdCategoriaMetodoPago VARCHAR(6),
	@Nombre VARCHAR(50)
)AS
BEGIN
	UPDATE CategoriaMetodoPago
	SET nombre =  @Nombre
	WHERE IdCategoriaMetodoPago = @IdCategoriaMetodoPago;
END;

--ELIMINAR--
CREATE OR ALTER PROCEDURE spEliminarCategoriaMetodoPago(
	@IdCategoriaMetodoPago VARCHAR(6)
)AS
BEGIN
	DELETE FROM CategoriaMetodoPago WHERE IdCategoriaMetodoPago = @IdCategoriaMetodoPago;
END;

-- PROCEDIMIENTOS METODO PAGO
CREATE PROCEDURE spListarMetodoPago
AS
BEGIN 
	SELECT * FROM Metodopago;
END;

CREATE PROCEDURE spInsertarMetodoPago(
	@IdMetodoPago VARCHAR(6),
	@IdCategoriaMetodoPago VARCHAR(6),
	@Nombre VARCHAR(50)
)AS
BEGIN
	INSERT INTO Metodopago VALUES(@IdMetodoPago, @IdCategoriaMetodoPago, @Nombre);
END;

CREATE PROCEDURE spModificarMetodoPago(
	@IdMetodoPago VARCHAR(6),
	@IdCategoriaMetodoPago VARCHAR(6),
	@Nombre VARCHAR(50)
)AS
BEGIN
	UPDATE MetodoPago
	SET nombre =  @Nombre,
		IdCategoriaMetodoPago = @IdCategoriaMetodoPago
	WHERE IdMetodoPago = @IdMetodoPago;
END;

CREATE PROCEDURE spEliminarMetodoPago(
	@IdMetodoPago VARCHAR(6)
)AS
BEGIN
	DELETE FROM Metodopago WHERE IdMetodoPago = @IdMetodoPago;
END;
