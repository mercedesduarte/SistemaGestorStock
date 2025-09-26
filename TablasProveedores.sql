CREATE TABLE Proveedores (
    IdProveedor INT IDENTITY(1,1) PRIMARY KEY,
    Codigo NVARCHAR(50) NOT NULL UNIQUE,
    RazonSocial NVARCHAR(150) NOT NULL,
    Cuit NVARCHAR(20) NOT NULL UNIQUE,
    Email NVARCHAR(150),
    FormaPago NVARCHAR(100),
    TiempoEntrega INT, -- días hábiles
    Descuento DECIMAL(5,2),
    Activo BIT DEFAULT 1
);

-- Teléfonos múltiples
CREATE TABLE ProveedorTelefonos (
    IdTelefono INT IDENTITY(1,1) PRIMARY KEY,
    IdProveedor INT FOREIGN KEY REFERENCES Proveedores(IdProveedor),
    Telefono NVARCHAR(30) NOT NULL,
    Contacto NVARCHAR(100),
    Sector NVARCHAR(100),
    Horario NVARCHAR(50),
    EmailContacto NVARCHAR(150),
    Activo BIT DEFAULT 1
);

-- Direcciones múltiples
CREATE TABLE ProveedorDirecciones (
    IdDireccion INT IDENTITY(1,1) PRIMARY KEY,
    IdProveedor INT FOREIGN KEY REFERENCES Proveedores(IdProveedor),
    Direccion NVARCHAR(250) NOT NULL,
    Localidad NVARCHAR(100),
    Provincia NVARCHAR(100),
    Activo BIT DEFAULT 1
);

-- Relación Producto-Proveedor
CREATE TABLE ProductoProveedor (
    IdProductoProveedor INT IDENTITY(1,1) PRIMARY KEY,
    IdProducto INT FOREIGN KEY REFERENCES Productos(IdProducto),
    IdProveedor INT FOREIGN KEY REFERENCES Proveedores(IdProveedor),
    PrecioCompra DECIMAL(12,2),
    Catalogo NVARCHAR(250), -- link o descripción
    Activo BIT DEFAULT 1
);

