-- =============================================
-- CREACIÓN DE TABLAS BÁSICAS PARA EL MÓDULO PRODUCTOS / STOCK
-- =============================================

-- Categorías de productos
CREATE TABLE Categorias (
    IdCategoria INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(255) NULL,
    Activo BIT NOT NULL DEFAULT 1
);

-- Marcas
CREATE TABLE Marcas (
    IdMarca INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Activo BIT NOT NULL DEFAULT 1

);

-- Productos
CREATE TABLE Productos (
    IdProducto INT IDENTITY(1,1) PRIMARY KEY,
    Codigo NVARCHAR(50) NOT NULL UNIQUE,
    Nombre NVARCHAR(150) NOT NULL,
    Descripcion NVARCHAR(500) NULL,
    IdCategoria INT FOREIGN KEY REFERENCES Categorias(IdCategoria),
    IdMarca INT FOREIGN KEY REFERENCES Marcas(IdMarca),
    Lote NVARCHAR(50) NULL,
    FechaVencimiento DATE NULL,
    DiasAvisoVencimiento INT NULL, -- para RF-02 "próximo a vencer"
    PrecioCompra DECIMAL(18,2) NOT NULL,
    PrecioVenta DECIMAL(18,2) NOT NULL,
    StockActual INT NOT NULL DEFAULT 0,
    StockMinimo INT NOT NULL DEFAULT 0,
    StockIdeal INT NOT NULL DEFAULT 0,
    StockMaximo INT NOT NULL DEFAULT 0,
    TipoStock NVARCHAR(20) NOT NULL CHECK (TipoStock IN ('Existencia','JIT')),
    Activo BIT NOT NULL DEFAULT 1
);

-- Movimientos de Stock (entradas / salidas / scrap)
CREATE TABLE MovimientosStock (
    IdMovimiento INT IDENTITY(1,1) PRIMARY KEY,
    IdProducto INT NOT NULL FOREIGN KEY REFERENCES Productos(IdProducto),
    Fecha DATETIME NOT NULL DEFAULT GETDATE(),
    TipoMovimiento NVARCHAR(20) NOT NULL CHECK (TipoMovimiento IN ('Entrada','Salida','Scrap')),
    Cantidad INT NOT NULL,
    Usuario NVARCHAR(100) NULL,
    Motivo NVARCHAR(255) NULL
);