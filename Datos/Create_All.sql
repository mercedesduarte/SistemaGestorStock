CREATE TABLE Provincia(
    Id_Provincia INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Provincia NVARCHAR(50) NOT NULL
);

CREATE TABLE Partido(
    Id_Partido INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Partido NVARCHAR(50) NOT NULL,
    Id_Provincia INT NOT NULL,
    FOREIGN KEY (Id_Provincia) REFERENCES Provincia(Id_Provincia)
);

CREATE TABLE Localidad(
    Id_Localidad INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Localidad NVARCHAR(50) NOT NULL,
    Codigo_Telefonico NVARCHAR(10) NOT NULL,
    Id_Partido INT NOT NULL,
    FOREIGN KEY (Id_Partido) REFERENCES Partido(Id_Partido)
);

CREATE TABLE Ubicacion(
    Id_Ubicacion INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Id_Provincia INT NOT NULL,
    Id_Partido INT NOT NULL,
    Id_Localidad INT NOT NULL,
    FOREIGN KEY (Id_Provincia) REFERENCES Provincia(Id_Provincia),
    FOREIGN KEY (Id_Partido) REFERENCES Partido(Id_Partido),
    FOREIGN KEY (Id_Localidad) REFERENCES Localidad(Id_Localidad)
);



--DATOS PERSONALES

CREATE TABLE Genero(
    Id_Genero INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Genero NVARCHAR(10) NOT NULL
);

CREATE TABLE Personas(
    Id_Persona INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Nro_legajo AS 'LEG' + RIGHT('0000' + CAST(Id_Persona AS VARCHAR(4)), 4),
    Nombre NVARCHAR(50) NOT NULL,
    Apellido NVARCHAR(50) NOT NULL,
    Tipo_Documento NVARCHAR(8) NOT NULL,
    Num_Documento NVARCHAR(20) NOT NULL,
	CUIL NVARCHAR(20) NOT NULL,
    Calle NVARCHAR(50) NOT NULL,
    Altura NVARCHAR(6) NOT NULL,
	Piso NVARCHAR(10),
	Departamento NVARCHAR(10),
    Codigo_Postal NVARCHAR(6) NOT NULL,
    Id_Ubicacion INT NOT NULL,
    Id_Genero INT NOT NULL,
    Sexo BIT,
    Email NVARCHAR(50) UNIQUE,
	FechaAlta DATETIME,

    FOREIGN KEY (Id_Ubicacion) REFERENCES Ubicacion(Id_Ubicacion),
    FOREIGN KEY (Id_Genero) REFERENCES Genero(Id_Genero)
);
 



--USUARIOS

CREATE TABLE Roles(
    Id_Rol INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Rol NVARCHAR(15)
);

CREATE TABLE Permisos(
    Id_Permiso INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Permiso NVARCHAR(30),
    Descripcion NVARCHAR(100)
);

CREATE TABLE Usuarios(
    Id_Usuario INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Id_Persona INT,
    Usuario NVARCHAR(12) NOT NULL UNIQUE,
    Contraseña NVARCHAR(20) NOT NULL,
    Bloqueado BIT,
    Fecha_Bloqueo DATETIME,
    CambioContra INT,
    FechaCambioContra DATETIME,
    Id_Rol INT NOT NULL,
    FOREIGN KEY(Id_Rol) REFERENCES Roles(Id_Rol),
	FOREIGN KEY(Id_Persona) REFERENCES Personas(Id_Persona)
);

CREATE TABLE HistorialContraseñas(
    Id_Historial INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Id_Usuario INT NOT NULL,
    FechaCambio DATETIME,
    Contraseña NVARCHAR(MAX),
    FOREIGN KEY(Id_Usuario) REFERENCES Usuarios(Id_Usuario)
);

CREATE TABLE Roles_Permisos(
    Id_Rol INT NOT NULL,
    Id_Permiso INT NOT NULL,
    PRIMARY KEY (Id_Rol, Id_Permiso),
    FOREIGN KEY(Id_Rol) REFERENCES Roles(Id_Rol),
    FOREIGN KEY(Id_Permiso) REFERENCES Permisos(Id_Permiso)
);

CREATE TABLE Permisos_Usuarios(
    Id_Usuario INT NOT NULL,
    Id_Permiso INT NOT NULL,
    Fecha_Limite DATETIME,
    PRIMARY KEY (Id_Usuario, Id_Permiso),
    FOREIGN KEY(Id_Usuario) REFERENCES Usuarios(Id_Usuario),
    FOREIGN KEY(Id_Permiso) REFERENCES Permisos(Id_Permiso)
);


