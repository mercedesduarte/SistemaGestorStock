CREATE TABLE Clientes (
    IdCliente INT IDENTITY(1,1) PRIMARY KEY,
    Codigo NVARCHAR(20) NOT NULL UNIQUE,
    RazonSocial NVARCHAR(150) NOT NULL,
    Email NVARCHAR(150),
    FormaPago NVARCHAR(100),
    Descuento DECIMAL(5,2) DEFAULT 0,
    LimiteCredito DECIMAL(12,2) DEFAULT 0,
    Activo BIT DEFAULT 1
);
GO


CREATE TABLE ClienteTelefonos (
    IdClienteTelefono INT IDENTITY(1,1) PRIMARY KEY,
    IdCliente INT NOT NULL,
    Telefono NVARCHAR(50) NOT NULL,
    Contacto NVARCHAR(100),
    Sector NVARCHAR(100),
    Horario NVARCHAR(100),
    EmailContacto NVARCHAR(150),
    Activo BIT DEFAULT 1,
    FOREIGN KEY (IdCliente) REFERENCES Clientes(IdCliente)
);
GO


CREATE TABLE dbo.ClienteDirecciones (
    IdClienteDireccion INT IDENTITY(1,1) PRIMARY KEY,
    IdCliente INT NOT NULL,
    Direccion NVARCHAR(250) NOT NULL,
    Localidad NVARCHAR(150),
    Provincia NVARCHAR(150),
    Activo BIT DEFAULT 1,
    FOREIGN KEY (IdCliente) REFERENCES Clientes(IdCliente)
);
GO


