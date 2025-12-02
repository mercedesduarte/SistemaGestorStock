
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Facturas' AND xtype='U')
BEGIN
    CREATE TABLE Facturas (
        IdFactura INT IDENTITY(1,1) PRIMARY KEY,
        NumeroFactura NVARCHAR(50) UNIQUE NOT NULL,
        Fecha DATETIME NOT NULL,
        FechaVencimiento DATETIME NULL,
        IdCliente INT NOT NULL,
        IdPresupuestoOrigen INT NULL,
        SubTotal DECIMAL(18,2) NOT NULL DEFAULT 0,
        Descuento DECIMAL(18,2) NOT NULL DEFAULT 0,
        IVA DECIMAL(18,2) NOT NULL DEFAULT 0,
        Total DECIMAL(18,2) NOT NULL DEFAULT 0,
        Estado NVARCHAR(20) NOT NULL DEFAULT 'PENDIENTE',
        Observaciones NVARCHAR(MAX) NULL,
        Usuario NVARCHAR(100) NOT NULL,
        FechaCreacion DATETIME NOT NULL DEFAULT GETDATE(),
        FechaModificacion DATETIME NULL,
        FechaAnulacion DATETIME NULL,
        MotivoAnulacion NVARCHAR(500) NULL,
        Registrado BIT NOT NULL DEFAULT 1,
        
        CONSTRAINT FK_Facturas_Clientes FOREIGN KEY (IdCliente) 
            REFERENCES Clientes(IdCliente),
        CONSTRAINT FK_Facturas_Presupuestos FOREIGN KEY (IdPresupuestoOrigen) 
            REFERENCES PresupuestosVenta(IdPresupuesto),
        CONSTRAINT CHK_EstadoFactura CHECK (Estado IN ('PENDIENTE', 'PAGADA', 'ANULADA', 'CANCELADA'))
    );
    
    -- ayuda a buscar mas rapido el nro de factura
    CREATE INDEX IX_Facturas_Numero ON Facturas(NumeroFactura);
    CREATE INDEX IX_Facturas_Fecha ON Facturas(Fecha);
    CREATE INDEX IX_Facturas_Cliente ON Facturas(IdCliente);
    CREATE INDEX IX_Facturas_Estado ON Facturas(Estado);
    
    PRINT 'Tabla Facturas creada exitosamente.';
END
ELSE
BEGIN
    PRINT 'La tabla Facturas ya existe.';
END
GO


IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='DetallesFactura' AND xtype='U')
BEGIN
    CREATE TABLE DetallesFactura (
        IdDetalleFactura INT IDENTITY(1,1) PRIMARY KEY,
        IdFactura INT NOT NULL,
        IdProducto INT NOT NULL,
        CodigoProducto NVARCHAR(50) NULL,
        Descripcion NVARCHAR(200) NULL,
        Cantidad DECIMAL(18,4) NOT NULL DEFAULT 0,
        PrecioUnitario DECIMAL(18,2) NOT NULL DEFAULT 0,
        SubTotal DECIMAL(18,2) NOT NULL DEFAULT 0,
        FechaCreacion DATETIME NOT NULL DEFAULT GETDATE(),
        
        CONSTRAINT FK_DetallesFactura_Factura FOREIGN KEY (IdFactura) 
            REFERENCES Facturas(IdFactura) ON DELETE CASCADE,
        CONSTRAINT FK_DetallesFactura_Producto FOREIGN KEY (IdProducto) 
            REFERENCES Productos(IdProducto)
    );
    
    CREATE INDEX IX_DetallesFactura_Factura ON DetallesFactura(IdFactura);
    CREATE INDEX IX_DetallesFactura_Producto ON DetallesFactura(IdProducto);
    
    PRINT 'Tabla DetallesFactura creada exitosamente.';
END
ELSE
BEGIN
    PRINT 'La tabla DetallesFactura ya existe.';
END
GO

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='PagosFacturas' AND xtype='U')
BEGIN
    CREATE TABLE PagosFacturas (
        IdPago INT IDENTITY(1,1) PRIMARY KEY,
        IdFactura INT NOT NULL,
        FechaPago DATETIME NOT NULL,
        Monto DECIMAL(18,2) NOT NULL,
        FormaPago NVARCHAR(50) NOT NULL,
        Referencia NVARCHAR(100) NULL,
        Observaciones NVARCHAR(500) NULL,
        Usuario NVARCHAR(100) NOT NULL,
        FechaCreacion DATETIME NOT NULL DEFAULT GETDATE(),
        
        CONSTRAINT FK_PagosFacturas_Factura FOREIGN KEY (IdFactura) 
            REFERENCES Facturas(IdFactura)
    );
    
    CREATE INDEX IX_PagosFacturas_Factura ON PagosFacturas(IdFactura);
    
    PRINT 'Tabla PagosFacturas creada exitosamente.';
END
ELSE
BEGIN
    PRINT 'La tabla PagosFacturas ya existe.';
END
GO