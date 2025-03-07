DROP PROCEDURE FechaBaseDatos
GO
CREATE PROCEDURE FechaBaseDatos
as
select dbo.FechaActual() as Fecha
GO

DROP PROCEDURE FechaBaseDatosSucursal
GO
CREATE PROCEDURE FechaBaseDatosSucursal
@Sucursal VarChar(4)
as
select dbo.FechaSucursal(@Sucursal) as Fecha
GO