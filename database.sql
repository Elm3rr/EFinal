-- Script alternativo (si no se usan las migraciones de EF Core)
CREATE DATABASE EFinal;
GO
USE EFinal;
GO
CREATE TABLE tbVehiculo (
    id     INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    placa  NVARCHAR(MAX) NOT NULL,
    marca  NVARCHAR(MAX) NOT NULL,
    modelo NVARCHAR(MAX) NOT NULL,
    anio   INT NOT NULL,
    color  NVARCHAR(MAX) NOT NULL,
    estado BIT NOT NULL DEFAULT 1   -- 1 = Activo, 0 = Inactivo
);
GO
