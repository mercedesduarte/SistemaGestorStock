-- Buscar Clientes
CREATE PROCEDURE sp_BuscarClientes
    @Busqueda VARCHAR(100)
AS
BEGIN
    SELECT 
        IdCliente,
        Codigo,
        RazonSocial,
        Email,
        FormaPago,
        Descuento,
        LimiteCredito
    FROM Clientes 
    WHERE (RazonSocial LIKE '%' + @Busqueda + '%' OR Codigo LIKE '%' + @Busqueda + '%')
    AND Activo = 1
END
GO

-- Buscar Productos
CREATE PROCEDURE sp_BuscarProductos
    @Busqueda VARCHAR(100)
AS
BEGIN
    SELECT 
        p.IdProducto,
        p.Codigo,
        p.Nombre,
        p.Descripcion,
        p.PrecioVenta,
        p.StockActual,
        c.Nombre as Categoria,
        m.Nombre as Marca
    FROM Productos p
    LEFT JOIN Categorias c ON p.IdCategoria = c.IdCategoria
    LEFT JOIN Marcas m ON p.IdMarca = m.IdMarca
    WHERE (p.Nombre LIKE '%' + @Busqueda + '%' OR p.Codigo LIKE '%' + @Busqueda + '%')
    AND p.Activo = 1
END
GO

-- Insertar Presupuesto
CREATE PROCEDURE sp_InsertarPresupuesto
    @NumeroPresupuesto VARCHAR(20),
    @Fecha DATETIME,
    @IdCliente INT,
    @SubTotal DECIMAL(18,2),
    @Descuento DECIMAL(18,2),
    @Total DECIMAL(18,2),
    @Validez INT,
    @Usuario VARCHAR(50),
    @IdPresupuesto INT OUTPUT
AS
BEGIN
    INSERT INTO PresupuestosVenta (
        NumeroPresupuesto, Fecha, IdCliente, SubTotal, 
        Descuento, Total, Estado, Validez, Usuario, FechaCreacion
    )
    VALUES (
        @NumeroPresupuesto, @Fecha, @IdCliente, @SubTotal,
        @Descuento, @Total, 'ACTIVO', @Validez, @Usuario, GETDATE()
    )
    
    SET @IdPresupuesto = SCOPE_IDENTITY()
END
GO

-- Insertar Detalle Presupuesto
CREATE PROCEDURE sp_InsertarDetallePresupuesto
    @IdPresupuesto INT,
    @IdProducto INT,
    @Cantidad DECIMAL(18,2),
    @PrecioUnitario DECIMAL(18,2),
    @SubTotal DECIMAL(18,2)
AS
BEGIN
    INSERT INTO PresupuestosVentaDetalle (
        IdPresupuesto, IdProducto, Cantidad, PrecioUnitario, SubTotal
    )
    VALUES (
        @IdPresupuesto, @IdProducto, @Cantidad, @PrecioUnitario, @SubTotal
    )
END
GO

-- Obtener último número de presupuesto
CREATE PROCEDURE sp_ObtenerUltimoNumeroPresupuesto
AS
BEGIN
    SELECT TOP 1 NumeroPresupuesto 
    FROM PresupuestosVenta 
    ORDER BY IdPresupuesto DESC
END
GO