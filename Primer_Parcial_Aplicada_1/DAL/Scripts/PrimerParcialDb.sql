CREATE DATABASE PrimerParcialDb
GO
USE PrimerParcialDb
GO
CREATE TABLE Grupos
(
	GrupoId int primary key identity,
	Fecha DateTime,
	Descripcion Varchar(max),
	Cantidad Decimal,
	Cantidad_Grupos Decimal,
	Integrantes Varchar(15)
	
);