CREATE TABLE Productos
(
    ID_Producto int Primary Key IDENTITY(1,1),
    Nombre_Producto nvarchar(40) NOT NULL,
	ID_Marca int NOT NULL,
	Descripcion nvarchar(300) NOT NULL,
    ID_Categoria_Producto int NOT NULL,
	Stock int NOT NULL,
    ID_Proveedor int NOT NULL,
    Precio int NOT NULL, -- Precio al que se vendera la unidad
);

CREATE TABLE Categoria_Producto
(
    ID_Categoria_Producto INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50) NOT NULL
);

CREATE TABLE Marcas
(
    ID_Marca INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50) NOT NULL
);

