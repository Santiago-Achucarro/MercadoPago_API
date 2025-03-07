-- FM 13/04/2023 13653 Que sea coherente con el resto de los informes y tome el TC del dia siguiente --

-- INF_SaldosProv  '20200831', '0722','0722',' ', 0,1

DROP procedure INF_SaldosProv 
GO
create procedure INF_SaldosProv 
(
	@FechaHasta DateTime, 
	@ProveedDesde VarChar(15),
	@ProveedHasta VarChar(15),
	@Moneda_Id VarChar(5), 
	@SoloEstaMoneda Bit, 
	@Empresa Int
)
AS

SET NOCOUNT ON
Declare @MonedaBase int = (SELECT  Moneda_id from genEmpresas where genEmpresas= @Empresa)

DECLARE @pMoneda_id AS INT
SET @pMoneda_id = dbo.FuncFKgenMonedas(@Moneda_Id)


IF (RTRIM(@Moneda_Id) = '')

select Proveed_Id, RazonSocial, Moneda_Id, SUM(Monto) as Monto
from (

SELECT comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	GenMonedas.Moneda_Id, 
	SUM(commovprov.Importe * commovtipos.Signo) as Monto
From comMovprov 
INNER JOIN conAsientos ON comMovprov.comMovprov = conAsientos.conAsientos
inner join comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_id
inner join commovtipos on commovtipos.TipoMov = comMovProv.Tipomov 
inner join GenMonedas ON GenMonedas.GenMonedas = conAsientos.Moneda_id
Left Join tesRengMovicomMovProv On tesRengMovicomMovProv.comMovProv = comMovProv.comMovProv
Where
commovprov.FacturaTesoreria = 0 and 
conAsientos.Anulado = 0 And 
conAsientos.Posteado = 1 and 
tesRengMovicomMovProv.tesMovimientos Is Null And
conAsientos.Empresa_Id = @Empresa and 
comProveedores.Proveed_id Between @ProveedDesde and @ProveedHasta and 
conAsientos.Fecha <= @FechaHasta 
GROUP BY comProveedores.Proveed_Id, comProveedores.RazonSocial,		
	GenMonedas.Moneda_Id
Having SUM(commovprov.Importe * commovtipos.Signo) <> 0
UNION ALL -- APLICACION DE IMPORTACIONES
SELECT comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	GenMonedas.Moneda_Id, 
	SUM(-genCancMov.Importe_AP * commovtipos.Signo) as Monto 

FROM 
	genCancMov INNER JOIN comMovprov ON 
	genCancMov.Asiento_Id_Ap = comMovprov.comMovProv
	INNER JOIN conAsientos ON conAsientos.conAsientos = comMovProv.comMovProv
	INNER JOIN conAsientos conasientos1 ON conAsientos1.conAsientos = genCancMov.Asiento_Id_Ap
	INNER JOIN GenMonedas ON GenMonedas.GenMonedas = conAsientos.Moneda_id
	inner join commovtipos on commovtipos.TipoMov = comMovProv.Tipomov 
	inner join comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_id
	where 
			conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and 
		conAsientos1.Anulado = 0 and 
		conAsientos1.Posteado = 1 and 
		genCancMov.Importacion = 1 AND
		genCancMov.Importacion = 1 AND
		conAsientos.Empresa_Id = @Empresa and 
		comProveedores.Proveed_id Between @ProveedDesde and @ProveedHasta and 
		conAsientos.Fecha <= @FechaHasta and 
		conAsientos1.Fecha   <= @FechaHasta AND
		genCancMov.FechaAplicacion <= @FechaHasta
GROUP BY comProveedores.Proveed_Id, comProveedores.RazonSocial,		
	GenMonedas.Moneda_Id
Having SUM(-genCancMov.Importe * commovtipos.Signo) <> 0

UNION ALL -- APLICACION DE IMPORTACIONES
SELECT comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	GenMonedas.Moneda_Id, 
	SUM(-genCancMov.Importe * commovtipos.Signo) as Monto 

FROM 
	genCancMov INNER JOIN comMovprov ON 
	genCancMov.Asiento_Id = comMovprov.comMovProv
	INNER JOIN conAsientos ON conAsientos.conAsientos = comMovProv.comMovProv

	INNER JOIN conAsientos conasientos1 ON conAsientos1.conAsientos = genCancMov.Asiento_Id_Ap
	INNER JOIN GenMonedas ON GenMonedas.GenMonedas = conAsientos.Moneda_id
	inner join commovtipos on commovtipos.TipoMov = comMovProv.Tipomov 
	inner join comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_id
	where 
		conAsientos.Anulado = 0 and 
		conAsientos.Posteado = 1 and 
		conAsientos1.Anulado = 0 and 
		conAsientos1.Posteado = 1 and 
		genCancMov.Importacion = 1 AND
		conAsientos.Empresa_Id = @Empresa and 
		comProveedores.Proveed_id Between @ProveedDesde and @ProveedHasta and 
		conAsientos.Fecha <= @FechaHasta and 
		conAsientos1.Fecha   <= @FechaHasta AND
		genCancMov.FechaAplicacion <= @FechaHasta
GROUP BY comProveedores.Proveed_Id, comProveedores.RazonSocial,		
	GenMonedas.Moneda_Id
Having SUM(-genCancMov.Importe * commovtipos.Signo) <> 0) as XXX
GROUP BY Proveed_Id, RazonSocial, Moneda_Id
having sum(Monto) <>0
Order by 3,2

ELSE
BEGIN

Create Table #_TiposCambio
(Moneda_Id int Not Null,
Cambio Numeric(17,4) Not Null)


Insert Into #_TiposCambio
Select genMonedas, dbo.func_TipoCambioCompra(genMonedas, DATEADD(dd,1,@FechaHasta), @Empresa) From genMonedas
select Proveed_Id, RazonSocial, Moneda_Id, SUM(Monto) as Monto
from (
SELECT comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	GenMonedas.Moneda_Id, 
	SUM(commovprov.Importe * Cambio.Cambio / CambioMR.Cambio * commovtipos.Signo) as Monto
From comMovprov 
INNER JOIN conAsientos ON comMovprov.comMovprov = conAsientos.conAsientos
inner join comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_id
inner join commovtipos on commovtipos.TipoMov = comMovProv.Tipomov 
INNER JOIN #_TiposCambio AS CambioMR ON CambioMR.Moneda_id = @pMoneda_id
inner join GenMonedas ON GenMonedas.GenMonedas = @pMoneda_id
inner join genMonedas genMonedas1 on genMonedas1.genMonedas = conAsientos.Moneda_Id
INNER JOIN #_TiposCambio AS Cambio ON Cambio.Moneda_id = conAsientos.Moneda_Id
Left Join tesRengMovicomMovProv On tesRengMovicomMovProv.comMovProv = comMovProv.comMovProv
Where
commovprov.FacturaTesoreria = 0 and 
conAsientos.Anulado = 0 And tesRengMovicomMovProv.tesMovimientos Is Null And
conAsientos.Empresa_Id = @Empresa and
comProveedores.Proveed_id Between @ProveedDesde and @ProveedHasta and 
conAsientos.Fecha <= @FechaHasta and 
(GenMonedas1.Moneda_id = @Moneda_id or @SoloEstaMoneda=0)

GROUP BY comProveedores.Proveed_Id, comProveedores.RazonSocial,		
	GenMonedas.Moneda_Id
Having SUM(commovprov.Importe * commovtipos.Signo) <> 0
UNION ALL -- APLICACION DE IMPORTACIONES
SELECT comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	GenMonedas.Moneda_Id, 
	SUM(-genCancMov.Importe_AP * commovtipos.Signo *   Cambio.Cambio / CambioMR.Cambio) as Monto 

FROM 
	genCancMov INNER JOIN comMovprov ON 
	genCancMov.Asiento_Id_Ap = comMovprov.comMovProv
	INNER JOIN conAsientos ON conAsientos.conAsientos = comMovProv.comMovProv
	inner join GenMonedas ON GenMonedas.GenMonedas = @pMoneda_id
	INNER JOIN GenMonedas GenMonedas1 ON GenMonedas1.GenMonedas = conAsientos.Moneda_id
	inner join commovtipos on commovtipos.TipoMov = comMovProv.Tipomov 
	inner join comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_id
	INNER JOIN #_TiposCambio AS CambioMR ON CambioMR.Moneda_id = @pMoneda_id
	INNER JOIN #_TiposCambio AS Cambio ON Cambio.Moneda_id = conAsientos.Moneda_Id
	where 
		genCancMov.Importacion = 1 AND
		(GenMonedas1.Moneda_id = @Moneda_id or @SoloEstaMoneda=0) and 
		conAsientos.Empresa_Id = @Empresa and 
		comProveedores.Proveed_id Between @ProveedDesde and @ProveedHasta and 
		conAsientos.Fecha <= @FechaHasta 
GROUP BY comProveedores.Proveed_Id, comProveedores.RazonSocial,		
	GenMonedas.Moneda_Id
Having SUM(-genCancMov.Importe * commovtipos.Signo) <> 0
UNION ALL -- APLICACION DE IMPORTACIONES
SELECT comProveedores.Proveed_Id, comProveedores.RazonSocial, 
	GenMonedas.Moneda_Id, 
	SUM(-genCancMov.Importe * commovtipos.Signo *   Cambio.Cambio / CambioMR.Cambio) as Monto 

FROM 
	genCancMov INNER JOIN comMovprov ON 
	genCancMov.Asiento_Id = comMovprov.comMovProv
	INNER JOIN conAsientos ON conAsientos.conAsientos = comMovProv.comMovProv
	INNER JOIN conAsientos conasientos1 ON conAsientos1.conAsientos = genCancMov.AsientoApli_Id
	inner join GenMonedas ON GenMonedas.GenMonedas = @pMoneda_id
	INNER JOIN GenMonedas GenMonedas1 ON GenMonedas1.GenMonedas = conAsientos.Moneda_id
	inner join commovtipos on commovtipos.TipoMov = comMovProv.Tipomov 
	inner join comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_id
	INNER JOIN #_TiposCambio AS CambioMR ON CambioMR.Moneda_id = @pMoneda_id
	INNER JOIN #_TiposCambio AS Cambio ON Cambio.Moneda_id = conAsientos.Moneda_Id
	where 
		genCancMov.Importacion = 1 AND
		(GenMonedas1.Moneda_id = @Moneda_id or @SoloEstaMoneda=0) and 
		conAsientos.Empresa_Id = @Empresa and 
		comProveedores.Proveed_id Between @ProveedDesde and @ProveedHasta and 
		conAsientos.Fecha <= @FechaHasta and 
		conAsientos1.Fecha   <= @FechaHasta AND
		genCancMov.FechaAplicacion <= @FechaHasta
GROUP BY comProveedores.Proveed_Id, comProveedores.RazonSocial,		
	GenMonedas.Moneda_Id
Having SUM(-genCancMov.Importe * commovtipos.Signo) <> 0
) as XXX
GROUP BY Proveed_Id, RazonSocial, Moneda_Id
having round(sum(Monto),2) <>0
Order by 3,2


END
GO
			
	
			
	