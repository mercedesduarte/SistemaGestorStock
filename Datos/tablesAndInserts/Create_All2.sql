
CREATE TABLE Categoria (
    Id_Categoria INT IDENTITY(1,1) PRIMARY KEY,
    Categoria NVARCHAR(100) NOT NULL
);

CREATE TABLE Productos (
    Id_Producto INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(200),
    Id_Categoria INT NOT NULL,
    Precio_Compra DECIMAL(18,2) NOT NULL,
    Precio_Venta DECIMAL(18,2) NOT NULL,
    Stock_Min INT,
    Stock_Max INT,
    FOREIGN KEY (Id_Categoria) REFERENCES Categoria(Id_Categoria)
);

CREATE TABLE Clientes (
    Id_Cliente INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    CUIT NVARCHAR(20),
    Direccion NVARCHAR(150),
    Telefono NVARCHAR(50),
    Email NVARCHAR(100),
    Tipo_Cliente NVARCHAR(50)
);

CREATE TABLE MétodosPago (
    Id_FPago INT IDENTITY(1,1) PRIMARY KEY,
    Fpago NVARCHAR(100) NOT NULL
);

CREATE TABLE Proveedores (
    Id_Proveedor INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Direccion NVARCHAR(150),
    Telefono NVARCHAR(50),
    Email NVARCHAR(100),
    Id_FPago INT,
    FOREIGN KEY (Id_FPago) REFERENCES MétodosPago(Id_FPago)
);

CREATE TABLE Tipo_Almacen (
    Id_Tipo_Almacen INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100)
);

CREATE TABLE Almacen (
    Id_Almacen INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100),
    Id_Localidad INT,
    Id_Tipo_Almacen INT,
    FOREIGN KEY (Id_Tipo_Almacen) REFERENCES Tipo_Almacen(Id_Tipo_Almacen)
);

CREATE TABLE Lote (
    Id_Lote INT IDENTITY(1,1) PRIMARY KEY,
    Id_Producto INT NOT NULL,
    Id_Almacen INT NOT NULL,
    Codigo NVARCHAR(50),
    Cantidad INT,
    Fecha_Fabricacion DATE,
    Fecha_Vencimiento DATE,
    FOREIGN KEY (Id_Producto) REFERENCES Productos(Id_Producto),
    FOREIGN KEY (Id_Almacen) REFERENCES Almacen(Id_Almacen)
);

CREATE TABLE Compras (
    Id_Compra INT IDENTITY(1,1) PRIMARY KEY,
    Id_Proveedor INT NOT NULL,
    Id_Producto INT NOT NULL,
    Id_Lote INT NOT NULL,
    Id_FPago INT NOT NULL,
    Cantidad INT NOT NULL,
    Estado NVARCHAR(50),
    Fecha_Compra DATE,
    Precio_Unitario DECIMAL(18,2),
    Precio_Total DECIMAL(18,2),
    FOREIGN KEY (Id_Proveedor) REFERENCES Proveedores(Id_Proveedor),
    FOREIGN KEY (Id_Producto) REFERENCES Productos(Id_Producto),
    FOREIGN KEY (Id_Lote) REFERENCES Lote(Id_Lote),
    FOREIGN KEY (Id_FPago) REFERENCES MétodosPago(Id_FPago)
);

CREATE TABLE Ventas (
    Id_Venta INT IDENTITY(1,1) PRIMARY KEY,
    Id_Cliente INT NOT NULL,
    Id_Producto INT NOT NULL,
    Id_Lote INT NOT NULL,
    Id_FPago INT NOT NULL,
    Cantidad INT NOT NULL,
    Estado NVARCHAR(50),
    Fecha_Venta DATE,
    Precio_Unitario DECIMAL(18,2),
    Precio_Total DECIMAL(18,2),
    FOREIGN KEY (Id_Cliente) REFERENCES Clientes(Id_Cliente),
    FOREIGN KEY (Id_Producto) REFERENCES Productos(Id_Producto),
    FOREIGN KEY (Id_Lote) REFERENCES Lote(Id_Lote),
    FOREIGN KEY (Id_FPago) REFERENCES MétodosPago(Id_FPago)
);

CREATE TABLE Envíos (
    Id_Envio INT IDENTITY(1,1) PRIMARY KEY,
    Id_Venta INT NOT NULL,
    Id_Localidad INT,
    Estado NVARCHAR(50),
    Fecha_Envio DATE,
    Fecha_Entrega DATE,
    FOREIGN KEY (Id_Venta) REFERENCES Ventas(Id_Venta)
);

CREATE TABLE Devolución (
    Id_Devolucion INT IDENTITY(1,1) PRIMARY KEY,
    Id_Venta INT,
    Id_Compra INT,
    Id_Lote INT,
    Tipo NVARCHAR(50),
    Cantidad INT,
    Motivo NVARCHAR(200),
    Fecha_Devolucion DATE,
    FOREIGN KEY (Id_Venta) REFERENCES Ventas(Id_Venta),
    FOREIGN KEY (Id_Compra) REFERENCES Compras(Id_Compra),
    FOREIGN KEY (Id_Lote) REFERENCES Lote(Id_Lote)
);

CREATE TABLE Stock (
    Id_Stock INT IDENTITY(1,1) PRIMARY KEY,
    Id_Almacen INT,
    Id_Producto INT,
    Id_Lote INT,
    Id_Compra INT,
    Id_Venta INT,
    Cantidad INT,
    Fecha_Compra DATE,
    Fecha_Venta DATE,
    FOREIGN KEY (Id_Almacen) REFERENCES Almacen(Id_Almacen),
    FOREIGN KEY (Id_Producto) REFERENCES Productos(Id_Producto),
    FOREIGN KEY (Id_Lote) REFERENCES Lote(Id_Lote),
    FOREIGN KEY (Id_Compra) REFERENCES Compras(Id_Compra),
    FOREIGN KEY (Id_Venta) REFERENCES Ventas(Id_Venta)
);

CREATE TABLE Ingreso (
    Id_Ingreso INT IDENTITY(1,1) PRIMARY KEY,
    Id_Venta INT,
    Id_Compra INT,
    Tipo NVARCHAR(50),
    Fecha_Ingreso DATE,
    Motivo NVARCHAR(200),
    FOREIGN KEY (Id_Venta) REFERENCES Ventas(Id_Venta),
    FOREIGN KEY (Id_Compra) REFERENCES Compras(Id_Compra)
);

CREATE TABLE Egreso (
    Id_Egreso INT IDENTITY(1,1) PRIMARY KEY,
    Id_Venta INT,
    Id_Compra INT,
    Tipo NVARCHAR(50),
    Fecha_Egreso DATE,
    Motivo NVARCHAR(200),
    FOREIGN KEY (Id_Venta) REFERENCES Ventas(Id_Venta),
    FOREIGN KEY (Id_Compra) REFERENCES Compras(Id_Compra)
);

CREATE TABLE Historial_Compras (
    Id_HistorialC INT IDENTITY(1,1) PRIMARY KEY,
    Id_OrdenC INT,
    Id_Compra INT,
    Id_Devolucion INT,
    Fecha_Entrega DATE,
    FOREIGN KEY (Id_Compra) REFERENCES Compras(Id_Compra),
    FOREIGN KEY (Id_Devolucion) REFERENCES Devolución(Id_Devolucion)
);

CREATE TABLE Historial_Ventas (
    Id_HistorialV INT IDENTITY(1,1) PRIMARY KEY,
    Id_OrdenV INT,
    Id_Venta INT,
    Id_Devolucion INT,
    Id_Envio INT,
    FOREIGN KEY (Id_Venta) REFERENCES Ventas(Id_Venta),
    FOREIGN KEY (Id_Devolucion) REFERENCES Devolución(Id_Devolucion),
    FOREIGN KEY (Id_Envio) REFERENCES Envíos(Id_Envio)
);

CREATE TABLE OrdenVenta (
    Id_OrdenV INT IDENTITY(1,1) PRIMARY KEY,
    Id_Localidad INT,
    Estado NVARCHAR(50),
    Id_FPago INT,
    Id_Envio INT,
    FOREIGN KEY (Id_FPago) REFERENCES MétodosPago(Id_FPago),
    FOREIGN KEY (Id_Envio) REFERENCES Envíos(Id_Envio)
);

CREATE TABLE OrdenCompra (
    Id_OrdenC INT IDENTITY(1,1) PRIMARY KEY,
    Id_Localidad INT,
    Estado NVARCHAR(50),
    Id_FPago INT,
    Id_Envio INT,
    FOREIGN KEY (Id_FPago) REFERENCES MétodosPago(Id_FPago),
    FOREIGN KEY (Id_Envio) REFERENCES Envíos(Id_Envio)
);

CREATE TABLE Facturacion (
    Id_Factura INT IDENTITY(1,1) PRIMARY KEY,
    Id_Venta INT,
    Id_Cliente INT,
    Id_Envio INT,
    FOREIGN KEY (Id_Venta) REFERENCES Ventas(Id_Venta),
    FOREIGN KEY (Id_Cliente) REFERENCES Clientes(Id_Cliente),
    FOREIGN KEY (Id_Envio) REFERENCES Envíos(Id_Envio)
);

CREATE TABLE Remitos (
    Id_Remito INT IDENTITY(1,1) PRIMARY KEY,
    Id_Compra INT,
    Id_Cliente INT,
    Id_Envio INT,
    FOREIGN KEY (Id_Compra) REFERENCES Compras(Id_Compra),
    FOREIGN KEY (Id_Cliente) REFERENCES Clientes(Id_Cliente),
    FOREIGN KEY (Id_Envio) REFERENCES Envíos(Id_Envio)
);

CREATE TABLE Scrap (
    Id_Scrap INT IDENTITY(1,1) PRIMARY KEY,
    Id_Producto INT NOT NULL,
    Id_Lote INT NOT NULL,
    Cantidad INT NOT NULL,
    Motivo NVARCHAR(200),
    Fecha_Scrap DATE NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (Id_Producto) REFERENCES Productos(Id_Producto),
    FOREIGN KEY (Id_Lote) REFERENCES Lote(Id_Lote)
);

