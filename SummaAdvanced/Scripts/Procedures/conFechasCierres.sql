drop procedure conFechasCierres
go
create procedure conFechasCierres
(
@pEmpresa_Id int
)
as
-- FALTA PRODUCCION Y SUELDOS	
select FechaCierreCompras,FechaCierreImpuestos,FechaCierreTesoreria,
	FechaCierreStock,FechaCierreVentas , FechaCierreActivoFijo, FechaCierreSueldos
	From genEmpresas where genEmpresas=@pEmpresa_Id
go