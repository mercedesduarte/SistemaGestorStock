-- Tabla de Presupuestos de Ventas
CREATE TABLE [dbo].[PresupuestosVenta](
    [IdPresupuesto] [int] IDENTITY(1,1) PRIMARY KEY,
    [NumeroPresupuesto] [varchar](50) NOT NULL UNIQUE,
    [Fecha] [datetime] NOT NULL,
    [IdCliente] [int] NOT NULL CONSTRAINT FK_PresupuestosVenta_Clientes FOREIGN KEY REFERENCES Clientes(IdCliente),
    [SubTotal] [decimal](18,2) NOT NULL,
    [Descuento] [decimal](18,2) NULL,
    [Total] [decimal](18,2) NOT NULL,
    [Estado] [varchar](20) NOT NULL DEFAULT 'PENDIENTE',
    [Validez] [int] NOT NULL,
    [Usuario] [varchar](100) NOT NULL,
    [FechaCreacion] [datetime] NOT NULL DEFAULT GETDATE()
);

-- Tabla de Detalles de Presupuestos
CREATE TABLE [dbo].[PresupuestosVentaDetalle](
    [IdDetalle] [int] IDENTITY(1,1) PRIMARY KEY,
    [IdPresupuesto] [int] NOT NULL CONSTRAINT FK_PresupuestosVentaDetalle_PresupuestosVenta FOREIGN KEY REFERENCES PresupuestosVenta(IdPresupuesto),
    [IdProducto] [int] NOT NULL CONSTRAINT FK_PresupuestosVentaDetalle_Productos FOREIGN KEY REFERENCES Productos(IdProducto),
    [Cantidad] [int] NOT NULL CHECK (Cantidad > 0),
    [PrecioUnitario] [decimal](18,2) NOT NULL CHECK (PrecioUnitario >= 0),
    [SubTotal] [decimal](18,2) NOT NULL CHECK (SubTotal >= 0)
);

-- Tabla de Notas de Pedido
CREATE TABLE [dbo].[NotasPedido](
    [IdNotaPedido] [int] IDENTITY(1,1) PRIMARY KEY,
    [NumeroPedido] [varchar](50) NOT NULL UNIQUE,
    [Fecha] [datetime] NOT NULL,
    [IdCliente] [int] NOT NULL CONSTRAINT FK_NotasPedido_Clientes FOREIGN KEY REFERENCES Clientes(IdCliente),
    [IdPresupuesto] [int] NULL CONSTRAINT FK_NotasPedido_PresupuestosVenta FOREIGN KEY REFERENCES PresupuestosVenta(IdPresupuesto),
    [SubTotal] [decimal](18,2) NOT NULL,
    [Descuento] [decimal](18,2) NULL,
    [Total] [decimal](18,2) NOT NULL,
    [Estado] [varchar](20) NOT NULL DEFAULT 'PENDIENTE' CHECK (Estado IN ('PENDIENTE', 'CONFIRMADO', 'ENTREGADO', 'CANCELADO')),
    [FechaEntrega] [datetime] NULL,
    [TiempoEntrega] [int] NOT NULL,
    [Usuario] [varchar](100) NOT NULL,
    [FechaCreacion] [datetime] NOT NULL DEFAULT GETDATE()
);

-- Tabla de Detalles de Notas de Pedido
CREATE TABLE [dbo].[NotasPedidoDetalle](
    [IdDetalle] [int] IDENTITY(1,1) PRIMARY KEY,
    [IdNotaPedido] [int] NOT NULL CONSTRAINT FK_NotasPedidoDetalle_NotasPedido FOREIGN KEY REFERENCES NotasPedido(IdNotaPedido),
    [IdProducto] [int] NOT NULL CONSTRAINT FK_NotasPedidoDetalle_Productos FOREIGN KEY REFERENCES Productos(IdProducto),
    [Cantidad] [int] NOT NULL CHECK (Cantidad > 0),
    [PrecioUnitario] [decimal](18,2) NOT NULL CHECK (PrecioUnitario >= 0),
    [SubTotal] [decimal](18,2) NOT NULL CHECK (SubTotal >= 0),
    [EstadoStock] [varchar](20) NOT NULL CHECK (EstadoStock IN ('DISPONIBLE', 'RESERVADO', 'JIT', 'INSUFICIENTE'))
);

-- Tabla de Productos Reservados
CREATE TABLE [dbo].[ProductosReservados](
    [IdReserva] [int] IDENTITY(1,1) PRIMARY KEY,
    [IdNotaPedido] [int] NOT NULL CONSTRAINT FK_ProductosReservados_NotasPedido FOREIGN KEY REFERENCES NotasPedido(IdNotaPedido),
    [IdProducto] [int] NOT NULL CONSTRAINT FK_ProductosReservados_Productos FOREIGN KEY REFERENCES Productos(IdProducto),
    [Cantidad] [int] NOT NULL CHECK (Cantidad > 0),
    [FechaReserva] [datetime] NOT NULL DEFAULT GETDATE(),
    [Estado] [varchar](20) NOT NULL DEFAULT 'RESERVADO' CHECK (Estado IN ('RESERVADO', 'CONFIRMADO', 'LIBERADO'))
);

-- Tabla de Notas de Crédito
CREATE TABLE [dbo].[NotasCredito](
    [IdNotaCredito] [int] IDENTITY(1,1) PRIMARY KEY,
    [NumeroNota] [varchar](50) NOT NULL UNIQUE,
    [Fecha] [datetime] NOT NULL,
    [IdCliente] [int] NOT NULL CONSTRAINT FK_NotasCredito_Clientes FOREIGN KEY REFERENCES Clientes(IdCliente),
    [IdNotaPedido] [int] NULL CONSTRAINT FK_NotasCredito_NotasPedido FOREIGN KEY REFERENCES NotasPedido(IdNotaPedido),
    [Motivo] [varchar](500) NOT NULL,
    [Total] [decimal](18,2) NOT NULL CHECK (Total >= 0),
    [Estado] [varchar](20) NOT NULL DEFAULT 'ACTIVA' CHECK (Estado IN ('ACTIVA', 'ANULADA')),
    [Usuario] [varchar](100) NOT NULL,
    [FechaCreacion] [datetime] NOT NULL DEFAULT GETDATE()
);

-- Tabla de Notas de Débito
CREATE TABLE [dbo].[NotasDebito](
    [IdNotaDebito] [int] IDENTITY(1,1) PRIMARY KEY,
    [NumeroNota] [varchar](50) NOT NULL UNIQUE,
    [Fecha] [datetime] NOT NULL,
    [IdCliente] [int] NOT NULL CONSTRAINT FK_NotasDebito_Clientes FOREIGN KEY REFERENCES Clientes(IdCliente),
    [IdNotaPedido] [int] NULL CONSTRAINT FK_NotasDebito_NotasPedido FOREIGN KEY REFERENCES NotasPedido(IdNotaPedido),
    [Motivo] [varchar](500) NOT NULL,
    [Total] [decimal](18,2) NOT NULL CHECK (Total >= 0),
    [Estado] [varchar](20) NOT NULL DEFAULT 'ACTIVA' CHECK (Estado IN ('ACTIVA', 'ANULADA')),
    [Usuario] [varchar](100) NOT NULL,
    [FechaCreacion] [datetime] NOT NULL DEFAULT GETDATE()
);