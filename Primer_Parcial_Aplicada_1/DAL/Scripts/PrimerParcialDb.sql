CREATE DATABASE PrimerParcialDb
GO
USE PrimerParcialDb
GO
CREATE TABLE Grupos
(
	GrupoId int primary key identity,
	Fecha Date,
	Descripcion Varchar(max),
	Cantidad Decimal(15),
	Cantidad_Grupos Decimal(15),
	Integrantes Varchar(15)
	
);

select * from Grupos