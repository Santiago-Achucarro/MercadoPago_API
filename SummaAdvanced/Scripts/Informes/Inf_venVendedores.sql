-- Inf_venVendedores ' ','ZZZ', 1
DROP PROCEDURE Inf_venVendedores
GO
CREATE PROCEDURE Inf_venVendedores
(
	@VendedorDesde VarChar(5),
	@VendedorHasta VarChar(5),
	@Empresa Int
)

AS

SELECT venVendedores.Vendedor_Id, venVendedores.Nombre, 
	venVendedores.Comision, venVendedores.ComisionxSuperv, 
	venVendedores.PisoDeVentas, venVendedores.FacturaCobrada, 
	venVendedores.ConAnticipos, venVendedores.SinImpuestos, venVendedores.Inactivo, 
	genEntidades.Cuit, genEntidades.TipoDoc, genEntidades.IdFiscal, genEntidades.FechaAlta
	FROM venVendedores INNER JOIN genEntidades ON
	venVendedores.venVendedores = genEntidades.genEntidades
	WHERE 
	venVendedores.Vendedor_Id BETWEEN @VendedorDesde and @VendedorHasta and 
	@Empresa = ISNULL(venVendedores.Empresa_Id, @Empresa)
order by 1
