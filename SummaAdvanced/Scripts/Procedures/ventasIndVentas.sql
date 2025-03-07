-- EXEC ventasIndVentasDatos '20200801','20200831',' ','ZZZ',' ','ZZZ',' ','ZZZ',' ','ZZ',' ','ZZ',1,' ','ZZ'
-- EXEC venGraTortaClienteDatos '20200801','20200831',' ','ZZZ',' ','ZZZ',1,' ','ZZZ'
-- EXEC venGraTortaFamiliaDatos '20200801','20200831',' ','ZZZ',' ','ZZZ',1,' ','ZZZ'
-- EXEC venGraTortaProductoDatos '20200801','20200831',' ','ZZZ',' ','zzz',' ','zzz',1,' ','ZZZ'
DROP PROCEDURE ventasIndVentasDatos
GO

CREATE PROCEDURE ventasIndVentasDatos
(

	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@VendedorDesde VarChar(5),
	@VendedorHasta VarChar(5),
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@FamiliaDesde VarChar(15),
	@FamiliaHasta VarChar(15),
	@GrupoDesde VarChar(15),
	@GrupoHasta VarChar(15),
	@ProductoDesde VarChar(25),
	@ProductoHasta VarChar(25),
	@Empresa_Id Int,
	@SucursalDesde varchar(4),
	@SucursalHasta varchar(4)
)
as
SELECT @FechaDesde as FechaDesde, @FechaHasta as FechaHasta, 
	@VendedorDesde as VendedorDesde, @VendedorHasta VendedorHasta,
	@ClienteDesde ClienteDesde,  @ClienteHasta ClienteHasta,
	@FamiliaDesde FamiliaDesde, @FamiliaHasta FamiliaHasta,
	@GrupoDesde GrupoDesde, @GrupoHasta GrupoHasta,
	@ProductoDesde ProductoDesde, @ProductoHasta ProductoHasta,
	@Empresa_Id  Empresa_Id , CONVERT(Numeric(18,2),0) as  VentaTotal, 
	CONVERT(Numeric(18,2),0) as  VentaMismoPerAnioAnt,
	CONVERT(Numeric(18,2),0) as  VentaPerAnterior,
	@SucursalDesde SucursalDesde,@SucursalHasta SucursalHasta

SELECT 
Convert(Numeric(18,2),isnull(SUM(MONTO),0)) AS Monto
from (
SELECT SUM(venMovConStockCr.CantFacturada *venMovConStockCr.PrecioVenta * 
	conAsientos.Cambio * venTipoMov.Signo) AS Monto

from venMovimientos 
	INNER JOIN venMovConStockCr on venMovimientos.venMovimientos = venMovConStockCr.venMovimientos
	INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
	INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN stkProductos ON stkProductos.stkProductos = venMovConStockCr.Producto_Id
	LEFT JOIN stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
	LEFT JOIN stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id	
	INNER JOIN venVendedores ON  venVendedores.venVendedores  = venMovimientos.Vendedor_Id
	INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id
	INNER Join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE	
	venSubTipoMov.AfectaEstadistica = 1 and
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Anulado = 0 and
	conAsientos.Posteado = 1 AND 
	conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta and 
	venVendedores.Vendedor_Id Between @VendedorDesde and @VendedorHasta and 
	venClientes.Cliente_Id Between @ClienteDesde and @ClienteHasta and 
	ISNULL(stkFamilias.Familia_Id,' ') Between @FamiliaDesde and @FamiliaHasta and 
	genSucursalesEmpr.Sucursal  Between @SucursalDesde and @SucursalHasta and 
	ISNULL(stkGrupos.Grupo_Id,' ') Between @GrupoDesde and @GrupoHasta and 
	stkProductos.Producto_Id  Between @ProductoDesde and @ProductoHasta
Union all
SELECT SUM(venMovDetalle.Cantidad  *  venMovDetalle.ImporteUnitario *
	conAsientos.Cambio * venTipoMov.Signo) as Monto

from venMovimientos 
	INNER JOIN venMovDetalle on venMovimientos.venMovimientos = venMovDetalle.venMovimientos
	INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
	INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN venVendedores ON  venVendedores.venVendedores  = venMovimientos.Vendedor_Id
	INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id
	INNER Join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE	
	venSubTipoMov.AfectaEstadistica = 1 and
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Anulado = 0 and
	conAsientos.Posteado = 1 AND 
	conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta and
	venVendedores.Vendedor_Id Between @VendedorDesde and @VendedorHasta and 
	venClientes.Cliente_Id Between @ClienteDesde and @ClienteHasta and 
	genSucursalesEmpr.Sucursal  Between @SucursalDesde and @SucursalHasta and 
	@FamiliaDesde = ' ' and 
	@GrupoDesde = ' ' and 
	@ProductoDesde = ' ') as XXXX

	
GO

DROP PROCEDURE venGraTortaVendedorDatos
go
CREATE PROCEDURE venGraTortaVendedorDatos
(
	
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@VendedorDesde VarChar(5),
	@VendedorHasta VarChar(5),
	@Empresa_Id Int,
	@SucursalDesde varchar(4),
	@SucursalHasta varchar(4)
)
as

SELECT @FechaDesde as FechaDesde, @FechaHasta as FechaHasta, 
	@VendedorDesde as VendedorDesde, @VendedorHasta VendedorHasta,
	@Empresa_Id  Empresa_Id,	@SucursalDesde SucursalDesde,@SucursalHasta SucursalHasta

SELECT RTRIM(left(Nombre,20)) as Serie, Vendedor_Id,
Convert(Numeric(18,2),isnull(SUM(MONTO),0)) AS Monto,Nombre
from (
SELECT venVendedores.Vendedor_Id, venVendedores.Nombre,
SUM(venMovConStockCr.CantFacturada *venMovConStockCr.PrecioVenta * 
	conAsientos.Cambio * venTipoMov.Signo) AS Monto

from venMovimientos 
	INNER JOIN venMovConStockCr on venMovimientos.venMovimientos = venMovConStockCr.venMovimientos
	INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
	INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN stkProductos ON stkProductos.stkProductos = venMovConStockCr.Producto_Id
	LEFT JOIN stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
	LEFT JOIN stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
	INNER JOIN venVendedores ON  venVendedores.venVendedores  = venMovimientos.Vendedor_Id
	INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id
	INNER Join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE	
	venSubTipoMov.AfectaEstadistica = 1 and
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Anulado = 0 and
	conAsientos.Posteado = 1 AND 
	conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta and
	venVendedores.Vendedor_Id Between @VendedorDesde and @VendedorHasta and 
	genSucursalesEmpr.Sucursal  Between @SucursalDesde and @SucursalHasta

GROUP BY venVendedores.Vendedor_Id, venVendedores.Nombre
Union all
SELECT venVendedores.Vendedor_Id,
venVendedores.Nombre, SUM(venMovDetalle.Cantidad  *  venMovDetalle.ImporteUnitario *
	conAsientos.Cambio * venTipoMov.Signo) as Monto

from venMovimientos 
	INNER JOIN venMovDetalle on venMovimientos.venMovimientos = venMovDetalle.venMovimientos
	INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
	INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN venVendedores ON  venVendedores.venVendedores  = venMovimientos.Vendedor_Id
	INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id
	INNER Join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE	
	venSubTipoMov.AfectaEstadistica = 1 and
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Anulado = 0 and
	conAsientos.Posteado = 1 AND 
	conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta and
	genSucursalesEmpr.Sucursal  Between @SucursalDesde and @SucursalHasta and 
	venVendedores.Vendedor_Id Between @VendedorDesde and @VendedorHasta 
	GROUP BY venVendedores.Nombre, venVendedores.Vendedor_Id
) as XXXX
GROUP BY Nombre, Vendedor_Id ORDER BY 3 DESC
GO

DROP PROCEDURE venGraTortaClienteDatos
go
CREATE PROCEDURE venGraTortaClienteDatos
(
	
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@VendedorDesde VarChar(5),
	@VendedorHasta VarChar(5),
	@Empresa_Id Int,
	@SucursalDesde varchar(4),
	@SucursalHasta varchar(4)
)
as

SELECT @FechaDesde as FechaDesde, @FechaHasta as FechaHasta, 
	@ClienteDesde as ClienteDesde, @ClienteHasta ClienteHasta,
	@Empresa_Id  Empresa_Id, @VendedorDesde VendedorDesde,
	@VendedorHasta VendedorHasta,
	@SucursalDesde SucursalDesde,@SucursalHasta SucursalHasta

SELECT RTRIM(LEFT(RazonSocial,20)) as Serie, 
Convert(Numeric(18,2),isnull(SUM(MONTO),0)) AS Monto, Cliente_Id, 
RazonSocial 
from (
SELECT venClientes.Cliente_Id,
venClientes.RazonSocial,
SUM(venMovConStockCr.CantFacturada *venMovConStockCr.PrecioVenta * 
	conAsientos.Cambio * venTipoMov.Signo) AS Monto

from venMovimientos 
	INNER JOIN venMovConStockCr on venMovimientos.venMovimientos = venMovConStockCr.venMovimientos
	INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
	INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN stkProductos ON stkProductos.stkProductos = venMovConStockCr.Producto_Id
	LEFT JOIN stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
	LEFT JOIN stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
	INNER JOIN venVendedores ON  venVendedores.venVendedores  = venMovimientos.Vendedor_Id
	INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id
	INNER Join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE	
	venSubTipoMov.AfectaEstadistica = 1 and
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Anulado = 0 and
	conAsientos.Posteado = 1 AND 
	conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta and
	venClientes.Cliente_Id Between @ClienteDesde and @ClienteHasta  and 
	venVendedores.Vendedor_Id  Between @VendedorDesde and @VendedorHasta and 
	genSucursalesEmpr.Sucursal  Between @SucursalDesde and @SucursalHasta 

GROUP BY venClientes.Cliente_Id, venClientes.RazonSocial
Union all
SELECT venClientes.Cliente_Id,
venClientes.RazonSocial, SUM(venMovDetalle.Cantidad  *  venMovDetalle.ImporteUnitario *
	conAsientos.Cambio * venTipoMov.Signo) as Monto

from venMovimientos 
	INNER JOIN venMovDetalle on venMovimientos.venMovimientos = venMovDetalle.venMovimientos
	INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
	INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN venVendedores ON  venVendedores.venVendedores  = venMovimientos.Vendedor_Id
	INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id
		INNER Join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE	
	venSubTipoMov.AfectaEstadistica = 1 and
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Anulado = 0 and
	conAsientos.Posteado = 1 AND 
	conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta and
	venClientes.Cliente_Id Between @ClienteDesde and @ClienteHasta and
	genSucursalesEmpr.Sucursal  Between @SucursalDesde and @SucursalHasta  and
	venVendedores.Vendedor_Id  Between @VendedorDesde and @VendedorHasta
GROUP BY venClientes.Cliente_Id, venClientes.RazonSocial
) as XXXX
GROUP BY RazonSocial, Cliente_Id ORDER BY 2 DESC

GO


DROP PROCEDURE venGraTortaFamiliaDatos
go
CREATE PROCEDURE venGraTortaFamiliaDatos
(
	
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@FamiliaDesde VarChar(5),
	@FamiliaHasta VarChar(5),
	@ClienteDesde VarChar(15),
	@ClienteHasta VarChar(15),
	@Empresa_Id Int,
	@SucursalDesde varchar(4),
	@SucursalHasta varchar(4)
)
as

SELECT @FechaDesde as FechaDesde, @FechaHasta as FechaHasta, 
	@FamiliaDesde as FamiliaDesde, @FamiliaHasta FamiliaHasta,
	@ClienteDesde ClienteDesde, @ClienteHasta  ClienteHasta,
	@Empresa_Id  Empresa_Id ,@SucursalDesde SucursalDesde,@SucursalHasta SucursalHasta

SELECT RTRIM(LEFT( Descripcion,20)) as Serie, 
Convert(Numeric(18,2),isnull(SUM(MONTO),0)) AS Monto, Familia_Id, Descripcion
from (
SELECT stkFamilias.Familia_Id, stkFamilias.Descripcion,
SUM(venMovConStockCr.CantFacturada *venMovConStockCr.PrecioVenta * 
	conAsientos.Cambio * venTipoMov.Signo) AS Monto
from venMovimientos 
	INNER JOIN venMovConStockCr on venMovimientos.venMovimientos = venMovConStockCr.venMovimientos
	INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
	INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN stkProductos ON stkProductos.stkProductos = venMovConStockCr.Producto_Id
	LEFT JOIN stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
	LEFT JOIN stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
	INNER JOIN venVendedores ON  venVendedores.venVendedores  = venMovimientos.Vendedor_Id
	INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id
	INNER Join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE	
	venSubTipoMov.AfectaEstadistica = 1 and
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Anulado = 0 and
	conAsientos.Posteado = 1 AND 
	conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta and
	venClientes.Cliente_Id BETWEEN @ClienteDesde AND @ClienteHasta AND 
	isnull(stkFamilias.Familia_Id,' ') BETWEEN @FamiliaDesde AND @FamiliaHasta and
	genSucursalesEmpr.Sucursal  Between @SucursalDesde and @SucursalHasta 
GROUP BY stkFamilias.Familia_Id, stkFamilias.Descripcion
Union all
SELECT ' ' as Familia_Id, 'SIN FAMILIA', SUM(venMovDetalle.Cantidad  *  venMovDetalle.ImporteUnitario *
	conAsientos.Cambio * venTipoMov.Signo) as Monto

from venMovimientos 
	INNER JOIN venMovDetalle on venMovimientos.venMovimientos = venMovDetalle.venMovimientos
	INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
	INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN venVendedores ON  venVendedores.venVendedores  = venMovimientos.Vendedor_Id
	INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id
	INNER Join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE	
	venSubTipoMov.AfectaEstadistica = 1 and
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Anulado = 0 and
	conAsientos.Posteado = 1 AND 
	conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta and
	venClientes.Cliente_Id BETWEEN @ClienteDesde AND @ClienteHasta AND 
	@FamiliaDesde = ' ' and
	genSucursalesEmpr.Sucursal  Between @SucursalDesde and @SucursalHasta 
	
) as XXXX
GROUP BY Descripcion, Familia_Id ORDER BY 2 DESC
GO






DROP PROCEDURE venGraTortaGrupoDatos
go
CREATE PROCEDURE venGraTortaGrupoDatos
(
	
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@FamiliaDesde VarChar(15),
	@FamiliaHasta VarChar(15),
	@GrupoDesde VarChar(15),
	@GrupoHasta VarChar(15),
	@Empresa_Id Int,
	@SucursalDesde varchar(4),
	@SucursalHasta varchar(4)
)
as

SELECT @FechaDesde as FechaDesde, @FechaHasta as FechaHasta, 
	@FamiliaDesde as FamiliaDesde, @FamiliaHasta FamiliaHasta,
	@GrupoDesde  as GrupoDesde , @GrupoHasta as GrupoHasta, 
	@Empresa_Id  Empresa_Id,@SucursalDesde SucursalDesde,@SucursalHasta SucursalHasta

SELECT RTRIM(LEFT(Descripcion,20)) as Serie, 
Convert(Numeric(18,2),isnull(SUM(MONTO),0)) AS Monto, Grupo_Id,Descripcion
from (
SELECT stkGrupos.Grupo_Id, stkGrupos.Descripcion,
SUM(venMovConStockCr.CantFacturada *venMovConStockCr.PrecioVenta * 
	conAsientos.Cambio * venTipoMov.Signo) AS Monto
from venMovimientos 
	INNER JOIN venMovConStockCr on venMovimientos.venMovimientos = venMovConStockCr.venMovimientos
	INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
	INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN stkProductos ON stkProductos.stkProductos = venMovConStockCr.Producto_Id
	LEFT JOIN stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
	LEFT JOIN stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
	INNER JOIN venVendedores ON  venVendedores.venVendedores  = venMovimientos.Vendedor_Id
	INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id 
	INNER Join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE	
	venSubTipoMov.AfectaEstadistica = 1 and
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Anulado = 0 and
	conAsientos.Posteado = 1 AND 
	conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta and
	isnull(stkFamilias.Familia_Id,' ') BETWEEN @FamiliaDesde AND @FamiliaHasta and 
	ISNULL(stkGrupos.Grupo_Id,' ') Between @GrupoDesde and @GrupoHasta and
		genSucursalesEmpr.Sucursal  Between @SucursalDesde and @SucursalHasta 
GROUP BY stkGrupos.Grupo_Id, stkGrupos.Descripcion
Union all
SELECT ' ' as Grupo_Id, 'NO CODIFICADOS', SUM(venMovDetalle.Cantidad  *  venMovDetalle.ImporteUnitario *
	conAsientos.Cambio * venTipoMov.Signo) as Monto

from venMovimientos 
	INNER JOIN venMovDetalle on venMovimientos.venMovimientos = venMovDetalle.venMovimientos
	INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
	INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN venVendedores ON  venVendedores.venVendedores  = venMovimientos.Vendedor_Id
	INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id 
	INNER Join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE	
	venSubTipoMov.AfectaEstadistica = 1 and
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Anulado = 0 and
	conAsientos.Posteado = 1 AND 
	conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta and
	@FamiliaDesde = ' ' and @GrupoDesde = ' ' and
		genSucursalesEmpr.Sucursal  Between @SucursalDesde and @SucursalHasta 
	
) as XXXX
GROUP BY Descripcion, Grupo_Id ORDER BY 2 DESC
GO

DROP PROCEDURE venGraTortaProductoDatos
go
CREATE PROCEDURE venGraTortaProductoDatos
(
	
	@FechaDesde DateTime, 
	@FechaHasta DateTime, 
	@FamiliaDesde VarChar(15),
	@FamiliaHasta VarChar(15),
	@GrupoDesde VarChar(15),
	@GrupoHasta VarChar(15),
	@ProductoDesde VarChar(25),
	@ProductoHasta VarChar(25),
	@Empresa_Id Int,
	@SucursalDesde varchar(4),
	@SucursalHasta varchar(4)
)
as

SELECT @FechaDesde as FechaDesde, @FechaHasta as FechaHasta, 
	@FamiliaDesde as FamiliaDesde, @FamiliaHasta FamiliaHasta,
	@GrupoDesde  as GrupoDesde , @GrupoHasta as GrupoHasta, 
	@ProductoDesde as ProductoDesde, @ProductoHasta AS ProductoHasta,
	@Empresa_Id  Empresa_Id,@SucursalDesde SucursalDesde,@SucursalHasta SucursalHasta

SELECT RTRIM(LEFT(Descripcion,20)) as Serie, 
Convert(Numeric(18,2),isnull(SUM(MONTO),0)) AS Monto, Producto_Id,Descripcion
from (
SELECT stkProductos.Producto_Id, stkProductos.Descripcion,
SUM(venMovConStockCr.CantFacturada *venMovConStockCr.PrecioVenta * 
	conAsientos.Cambio * venTipoMov.Signo) AS Monto
from venMovimientos 
	INNER JOIN venMovConStockCr on venMovimientos.venMovimientos = venMovConStockCr.venMovimientos
	INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
	INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN stkProductos ON stkProductos.stkProductos = venMovConStockCr.Producto_Id
	LEFT JOIN stkFamilias ON stkFamilias.stkFamilias = stkProductos.Familia_Id
	LEFT JOIN stkGrupos ON stkGrupos.stkGrupos = stkProductos.Grupo_Id
	INNER JOIN venVendedores ON  venVendedores.venVendedores  = venMovimientos.Vendedor_Id
	INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id 
	INNER Join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE	
	venSubTipoMov.AfectaEstadistica = 1 and
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Anulado = 0 and
	conAsientos.Posteado = 1 AND 
	conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta and
	isnull(stkFamilias.Familia_Id,' ') BETWEEN @FamiliaDesde AND @FamiliaHasta and 
	ISNULL(stkGrupos.Grupo_Id,' ') Between @GrupoDesde and @GrupoHasta and 
	stkProductos.Producto_Id  Between @ProductoDesde and @ProductoHasta and
		genSucursalesEmpr.Sucursal  Between @SucursalDesde and @SucursalHasta 
GROUP BY stkProductos.Producto_Id, stkProductos.Descripcion
Union all
SELECT ' ' as Familia_Id, 'NO CODIFICADOS', SUM(venMovDetalle.Cantidad  *  venMovDetalle.ImporteUnitario *
	conAsientos.Cambio * venTipoMov.Signo) as Monto

from venMovimientos 
	INNER JOIN venMovDetalle on venMovimientos.venMovimientos = venMovDetalle.venMovimientos
	INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
	INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
	INNER JOIN venSubTipoMov ON venSubTipoMov.venSubTipoMov = venMovimientos.venSubTipoMov_Id
	INNER JOIN venVendedores ON  venVendedores.venVendedores  = venMovimientos.Vendedor_Id
	INNER JOIN venClientes ON venClientes.genEntidades = venMovimientos.Cliente_Id 
	INNER Join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
WHERE	
	venSubTipoMov.AfectaEstadistica = 1 and
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Anulado = 0 and
	conAsientos.Posteado = 1 AND 
	conAsientos.Fecha BETWEEN @FechaDesde and @FechaHasta and
	@FamiliaDesde = ' ' and @GrupoDesde = ' ' and
	genSucursalesEmpr.Sucursal  Between @SucursalDesde and @SucursalHasta 
	
) as XXXX
GROUP BY Descripcion, Producto_Id ORDER BY 2 DESC
GO