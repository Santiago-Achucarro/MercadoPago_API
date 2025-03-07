--SELECT * FROM vstkProductosCostoCierre


-- stockInicioCierre '20180430','20180331', 1
-- stockMovimientosCierre '20180531','20180630',1
-- SELECT * FROM stkmovicuerpo where stkmovicabe =20497
-- SELECT * FROM vconmovcont where conasientos =20497
-- stockMovCuerpoCierre 20497
-- stockActuAsientoCierre 20497
---select * from vconMovCont where conAsientos = 20497 
-- select * from stkMoviReva



DROP Procedure StockCerrar
GO
CREATE Procedure StockCerrar
(
@Empresa_Id Int
)
as

SELECT FechaCierreStock as UltimoCierre, 
conPeriodos.Fecha_Hasta as ProximoCierre,
FechaCalculoStock
FROM genEmpresas 
INNER JOIN conPeriodos on
genEmpresas.genEmpresas = conPeriodos.Empresa_Id and 
DATEADD(dd,1,FechaCierreStock) between conPeriodos.Fecha_Desde And conPeriodos.Fecha_Hasta
Where
	genEmpresas.genEmpresas = @Empresa_Id

GO


DROP PROCEDURE stkAsiCierreDatosCierre
GO
CREATE PROCEDURE stkAsiCierreDatosCierre
(
@pFecha DateTime, 
@Empresa_Id Int
)
AS
SET NOCOUNT ON 

SELECT @pFecha as Fecha 



SELECT conAsientos.conAsientos Asiento_Id , conAsientos.Empresa_Id, conAsientos.Fecha, 
	conAsientos.Anulado, genMonedas.Moneda_Id, 
	genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N,
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
	genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
	genSucursalesEmpr.Sucursal, disFormularios.Formulario_Id
FROM conAsientos INNER JOIN genMonedas  ON 
genMonedas.genMonedas = conAsientos.Moneda_Id
inner join genAsiSegmentos ON
genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
inner join genSegmentos ON
genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
INNER JOIN genSucursalesEmpr ON 
genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
inner join disFormularios ON 
disFormularios.disFormularios = conAsientos.Formulario_Id

WHERE conAsientos.Fecha= @pFecha  and 
conAsientos.Formulario_Id = dbo.FuncFKdisFormularios('frmStockCerrar') and
conAsientos.Anulado = 0 and 
conAsientos.Empresa_Id = @Empresa_Id

 
RETURN @@Error 

GO

DROP PROCEDURE stockInicioCierre
GO

CREATE PROCEDURE stockInicioCierre(@FechaCierre Datetime, 
	@FechaCierreAnt DateTime, @Empresa_Id INT)
AS

-- BORRO EL CIERRE ACTUAL

DELETE FROM stkProductosCostoCierre where Fecha = @FechaCierre  AND Empresa_Id = @Empresa_Id
DELETE FROM stkProductosCostoCierreSucursal where Fecha = @FechaCierre  AND Empresa_Id = @Empresa_Id

Update conAsientos set Anulado = 1
Where
Exists(select 1 From stkMoviCabe , stkMoviCRevaluo, conAsientos conAsientos1
Where
	stkMoviCabe.stkMoviCabe = conAsientos.conAsientos and 
	stkMoviCRevaluo.stkMoviCabeReva = stkMoviCabe.stkMoviCabe and 
	conAsientos1.conasientos = stkMoviCRevaluo.conAsientos and 
	conAsientos1.Anulado = 1) and 
	conAsientos.Anulado = 0 



insert into stkProductosCostoCierre(Producto_Id, Empresa_Id, Fecha, Costo)
Select Producto_Id, Empresa_Id, @FechaCierre, Costo 
from stkProductosCostoCierre
Where
	stkProductosCostoCierre.Empresa_Id =@Empresa_Id and 
	stkProductosCostoCierre.Fecha = @FechaCierreAnt

-- SI NO ESTA EN ESTA TABLA ES PORQUE EL PRODUCTO ES NUEVO CALCULO EL MOVIMIENTO Y COMPLETO

insert into stkProductosCostoCierre(Producto_Id, Empresa_Id, Fecha, Costo)
SELECT stkproductos.stkProductos, @Empresa_Id, @FechaCierre, 
	(SUM(stkMoviCuerpo.Cantidad * stkMoviCuerpo.CostoUnitario* stkMoviCabe.Signo) +
	ISNULL((select sum(stkmovicuerpoReva.importeAjuste) 
		from stkmovicuerpoReva inner join conAsientos ON
			stkmovicuerpoReva.stkMoviCabe = conAsientos.conAsientos AND 
			stkmovicuerpoReva.Producto_Id = stkProductos.stkProductos
			Where
			conAsientos.Empresa_Id = @Empresa_Id and 
			conAsientos.Anulado = 0 and 
			conAsientos.Fecha <= @FechaCierreAnt ),0))
	/ SUM(stkMoviCuerpo.Cantidad * stkMoviCabe.Signo) as COSTO

FROM stkMoviCabe INNER JOIN stkMoviCuerpo ON
stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe 
INNER JOIN conAsientos ON 
stkMoviCabe.stkMoviCabe = conAsientos.conAsientos
INNER JOIN stkProductos ON
stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
inner join stkDepositos ON
stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id

Where
	stkDepositos.Consignacion = 0 and 
	stkProductos.Clase in ('-','E') AND
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Anulado = 0 and 
	conAsientos.Fecha <= @FechaCierreAnt and 
	not exists(Select 1 from stkProductosCostoCierre Where
		stkProductosCostoCierre.Empresa_Id = @Empresa_Id and 
		stkProductosCostoCierre.Fecha = @FechaCierreAnt and 
		stkProductosCostoCierre.Producto_Id = stkProductos.stkProductos)
GROUP BY stkproductos.stkProductos
having SUM(stkMoviCuerpo.Cantidad * stkMoviCabe.Signo)<> 0

insert into stkProductosCostoCierreSucursal(Sucursal, Producto_Id, Empresa_Id, Fecha, Costo)
Select Sucursal, Producto_Id, Empresa_Id, @FechaCierre, Costo 
from stkProductosCostoCierreSucursal
Where
	stkProductosCostoCierreSucursal.Empresa_Id =@Empresa_Id and 
	stkProductosCostoCierreSucursal.Fecha = @FechaCierreAnt




insert into stkProductosCostoCierreSucursal(Sucursal, Producto_Id, Empresa_Id, Fecha, Costo)
SELECT conAsientos.Sucursal, stkproductos.stkProductos, @Empresa_Id, @FechaCierre, 
	(SUM(stkMoviCuerpo.Cantidad * stkMoviCuerpo.CostoUnitario* stkMoviCabe.Signo) +
	ISNULL((select sum(stkmovicuerpoReva.importeAjuste) 
		from stkmovicuerpoReva inner join conAsientos ON
			stkmovicuerpoReva.stkMoviCabe = conAsientos.conAsientos AND 
			stkmovicuerpoReva.Producto_Id = stkProductos.stkProductos
			Where
			conAsientos.Empresa_Id = @Empresa_Id and 
			conAsientos.Anulado = 0 and 
			conAsientos.Fecha <= @FechaCierreAnt ),0))
	/ SUM(stkMoviCuerpo.Cantidad * stkMoviCabe.Signo) as COSTO

FROM stkMoviCabe INNER JOIN stkMoviCuerpo ON
stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe 
INNER JOIN conAsientos ON 
stkMoviCabe.stkMoviCabe = conAsientos.conAsientos
INNER JOIN stkProductos ON
stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
inner join stkDepositos ON
stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
Where
	stkDepositos.Consignacion = 0 and 
	stkProductos.Clase in ('-','E') AND
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Anulado = 0 and 
	conAsientos.Fecha <= @FechaCierreAnt and 
	not exists(Select 1 from stkProductosCostoCierreSucursal Where
		stkProductosCostoCierreSucursal.Sucursal = conAsientos.Sucursal and
		stkProductosCostoCierreSucursal.Empresa_Id = @Empresa_Id and 
		stkProductosCostoCierreSucursal.Fecha = @FechaCierreAnt and 
		stkProductosCostoCierreSucursal.Producto_Id = stkProductos.stkProductos)
GROUP BY stkproductos.stkProductos, conAsientos.Sucursal
having SUM(stkMoviCuerpo.Cantidad * stkMoviCabe.Signo)<> 0



GO


DROP PROCEDURE stockMovimientosCierre
GO
-- stockMovimientosCierre '20190101','20190131',1

CREATE PROCEDURE stockMovimientosCierre(
@FechaCierreAnt Datetime,
@FechaCierre Datetime,
 @Empresa_Id INT)
AS

SELECT conAsientos.Fecha, conAsientos.FechaRegistro,
	stkMoviCabe.stkMoviCabe, stkMoviCabe.SubTipoMov_Id,
	stkMoviCabe.ModificaCosto, genMonedas.Moneda_Id, 
	conAsientos.Cambio,conAsientos.CambioMonedaOriginal,
	stkmovicrevaluo.stkmoviCabeReva, genSucursalesEmpr.Sucursal, 
	disFormularios.Formulario_Id
FROM stkMoviCabe INNER JOIN conAsientos ON 
stkMoviCabe.stkMoviCabe = conAsientos.conAsientos
INNER JOIN genMonedas ON
genMonedas.genMonedas = conAsientos.Moneda_Id
LEFT JOIN stkmovicrevaluo ON
stkmovicrevaluo.conAsientos = stkMoviCabe.stkMoviCabe
INNER JOIN genSucursalesEmpr ON
genSucursalesEmpr.genSucursalesEmpr = conAsientos.Sucursal
INNER JOIN disFormularios ON
disFormularios.disFormularios = conAsientos.Formulario_Id
Where
	stkMoviCabe.SubTipoMov_Id != 'RV' AND  
	conAsientos.Empresa_Id = @Empresa_Id and 
	conAsientos.Anulado = 0 and 
	conAsientos.Fecha between @FechaCierreAnt and @FechaCierre
order by 1,2,3

GO
-- stockMovCuerpoCierre 19369
DROP PROCEDURE stockMovCuerpoCierre
GO

CREATE PROCEDURE stockMovCuerpoCierre(@StkMoviCabe bigint)
AS

SELECT stkMoviCuerpo.Renglon, stkMoviCuerpo.Producto_Id as stkProductos,  
	stkProductos.Producto_Id, 
	stkMoviCuerpo.CostoUnitario , stkMoviCuerpo.Cantidad* stkMoviCabe.Signo AS Cantidad, 
	stkMoviCuerpo.PrecioOriginal,
	stkMoviCuerpo.conRenglonDebe, stkMoviCuerpo.conRenglonHaber, 
	conCuentas.Cuenta_Id as CtaAjuInventario, 
	CtaCompra.Cuenta_Id as CtaCompra, 
	stkDepositos.Deposito_Id, conCentro1.Centro1_Id, conCentro2.Centro2_Id
FROM stkMoviCuerpo INNER JOIN stkProductos ON 
stkMoviCuerpo.Producto_Id = stkProductos.stkProductos
INNER JOIN stkMoviCabe ON  stkMoviCabe.stkMoviCabe = stkMoviCuerpo.stkMoviCabe
LEFT JOIN concuentas ON 
concuentas.concuentas = stkProductos.CtaAjuInventario
inner join  conCuentas as CtaCompra ON 
CtaCompra.conCuentas = stkProductos.CtaCompra
LEFT JOIN stkDepositos ON stkDepositos.stkDepositos = stkMoviCuerpo.Deposito_Id
LEFT JOIN conCentro1 ON conCentro1.conCentro1 = stkDepositos.Centro1_Id
LEFT JOIN conCentro2 ON conCentro2.conCentro2 = stkDepositos.Centro2_Id
Where
	stkMoviCuerpo.stkMoviCabe = @StkMoviCabe
order by 1

GO


DROP PROCEDURE stockActuAsientoCierre
GO

CREATE PROCEDURE stockActuAsientoCierre(@StkMoviCabe bigint)
AS
SET NOCOUNT ON

UPDATE conMovCont Set Importe =isnull((select SUM(ROUND(stkmoviCuerpo.Cantidad*stkMoviCuerpo.CostoUnitario,2))
	from stkMoviCuerpo 
		inner join stkProductos ON stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
		WHERE
			stkProductos.Clase IN ('E','-') AND 
			stkMoviCuerpo.stkMoviCabe = conMovCont.conAsientos AND 
			stkMoviCuerpo.conRenglonDebe =conMovCont.Renglon),0), 
	ImporteMonedaOriginal = isnull((select SUM(ROUND(stkmoviCuerpo.Cantidad*stkMoviCuerpo.CostoUnitario,2))
	from stkMoviCuerpo 
		inner join stkProductos ON stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
		WHERE
			stkProductos.Clase IN ('E','-') AND 
			stkMoviCuerpo.stkMoviCabe = conMovCont.conAsientos AND 
			stkMoviCuerpo.conRenglonDebe =conMovCont.Renglon),0)
Where
	exists(select 1 from stkMoviCuerpo where
			stkMoviCuerpo.stkMoviCabe = conMovCont.conAsientos AND 
			stkMoviCuerpo.conRenglonDebe =conMovCont.Renglon) and 
conMovCont.conAsientos = @StkMoviCabe

UPDATE conMovCont Set Importe = isnull((select SUM(ROUND(stkmoviCuerpo.Cantidad*stkMoviCuerpo.CostoUnitario,2))
	from stkMoviCuerpo 
		inner join stkProductos ON stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
		WHERE
			stkProductos.Clase IN ('E','-') AND 
			stkMoviCuerpo.stkMoviCabe = conMovCont.conAsientos AND 
			stkMoviCuerpo.conRenglonHaber =conMovCont.Renglon),0), 
	ImporteMonedaOriginal = isnull((select SUM(ROUND(stkmoviCuerpo.Cantidad*stkMoviCuerpo.CostoUnitario,2))
	from stkMoviCuerpo 
	inner join stkProductos ON stkProductos.stkProductos = stkMoviCuerpo.Producto_Id
		WHERE
			stkProductos.Clase IN ('E','-') AND 
			stkMoviCuerpo.stkMoviCabe = conMovCont.conAsientos AND 
			stkMoviCuerpo.conRenglonHaber =conMovCont.Renglon),0)
Where
	exists(select 1 from stkMoviCuerpo where
			stkMoviCuerpo.stkMoviCabe = conMovCont.conAsientos AND 
			stkMoviCuerpo.conRenglonHaber =conMovCont.Renglon) and 
conMovCont.conAsientos = @StkMoviCabe

GO


DROP PROCEDURE stockActuCostoCierre
GO

CREATE PROCEDURE stockActuCostoCierre(@StkMoviCabe bigint, @FechaCierre DateTime, @Empresa_id Int)
AS
SET NOCOUNT ON

UPDATE stkMoviCuerpo Set CostoUnitario = stkProductosCostoCierre.Costo
From stkProductosCostoCierre
Where
	stkProductosCostoCierre.Producto_Id = stkMoviCuerpo.Producto_Id AND 
	stkProductosCostoCierre.Empresa_Id = @Empresa_id AND
	stkProductosCostoCierre.Fecha = @FechaCierre AND
	stkMoviCuerpo.stkMoviCabe =@StkMoviCabe
GO


DROP PROCEDURE stockActuCostoCierreSucursal
GO

CREATE PROCEDURE stockActuCostoCierreSucursal(@StkMoviCabe bigint, @FechaCierre DateTime, @Empresa_id Int)
AS
SET NOCOUNT ON

UPDATE stkMoviCuerpo Set CostoUnitario = stkProductosCostoCierreSucursal.Costo
From stkProductosCostoCierreSucursal, conAsientos
Where
	conAsientos.conAsientos = stkMoviCuerpo.stkMoviCabe and
	stkProductosCostoCierreSucursal.Producto_Id = stkMoviCuerpo.Producto_Id AND 
	stkProductosCostoCierreSucursal.Empresa_Id = @Empresa_id AND
	stkProductosCostoCierreSucursal.Fecha = @FechaCierre AND
	stkProductosCostoCierreSucursal.Sucursal = conAsientos.Sucursal and 
	stkMoviCuerpo.stkMoviCabe =@StkMoviCabe

-- SI no existe lo toma de stkProductosCostosSucursal
UPDATE stkMoviCuerpo Set CostoUnitario = stkProductosCostosSucursal.CostoPromPond
From stkProductosCostosSucursal, conAsientos
Where
	conAsientos.conAsientos = stkMoviCuerpo.stkMoviCabe and
	stkProductosCostosSucursal.Producto_Id = stkMoviCuerpo.Producto_Id AND 
	stkProductosCostosSucursal.Empresa_Id = @Empresa_id AND
	stkProductosCostosSucursal.Sucursal = conAsientos.Sucursal and 
	stkMoviCuerpo.stkMoviCabe =@StkMoviCabe and 
	not exists(select 1 from stkProductosCostoCierreSucursal where
		stkProductosCostoCierreSucursal.Producto_Id = stkMoviCuerpo.Producto_Id AND 
		stkProductosCostoCierreSucursal.Empresa_Id = @Empresa_id AND
		stkProductosCostoCierreSucursal.Fecha = @FechaCierre AND
		stkProductosCostoCierreSucursal.Sucursal = conAsientos.Sucursal )

-- SI no existe lo toma de StkProductos
UPDATE stkMoviCuerpo Set CostoUnitario = stkProductos.CostoPromPond
From stkProductos, conAsientos
Where
	conAsientos.conAsientos = stkMoviCuerpo.stkMoviCabe and
	stkProductos.stkProductos = stkMoviCuerpo.Producto_Id and 
	stkMoviCuerpo.stkMoviCabe = @StkMoviCabe AND 
	not exists(select 1 from stkProductosCostoCierreSucursal where
		stkProductosCostoCierreSucursal.Producto_Id = stkMoviCuerpo.Producto_Id AND 
		stkProductosCostoCierreSucursal.Empresa_Id = @Empresa_id AND
		stkProductosCostoCierreSucursal.Fecha = @FechaCierre AND
		stkProductosCostoCierreSucursal.Sucursal = conAsientos.Sucursal ) and
	not exists(select 1 from stkProductosCostosSucursal
		WHERE
		stkProductosCostosSucursal.Producto_Id = stkMoviCuerpo.Producto_Id AND 
		stkProductosCostosSucursal.Empresa_Id = @Empresa_id AND
		stkProductosCostosSucursal.Sucursal = conAsientos.Sucursal and 
		stkMoviCuerpo.stkMoviCabe =@StkMoviCabe )

GO


DROP PROCEDURE stkProductosCostoCierreGuardar
GO
CREATE PROCEDURE stkProductosCostoCierreGuardar
(
@pProducto_Id VarChar(25),
@pEmpresa_Id int,
@pFecha datetime,
@pCosto numeric(19,8)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM stkProductosCostoCierre WHERE (Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id)) AND 
		(Empresa_Id = @pEmpresa_Id) AND (Fecha = @pFecha)))
BEGIN 
	UPDATE stkProductosCostoCierre
		SET	Costo = @pCosto
	WHERE (Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id)) AND (Empresa_Id = @pEmpresa_Id) AND (Fecha = @pFecha)
END 
ELSE 
BEGIN 
	INSERT INTO stkProductosCostoCierre
	(
		Producto_Id,
		Empresa_Id,
		Fecha,
		Costo
	)
	VALUES 
	(
		dbo.FuncFKstkProductos(@pProducto_Id),
		@pEmpresa_Id,
		@pFecha,
		@pCosto
	)
END 

GO

DROP PROCEDURE stkProductosCostoCierreDatos
GO
CREATE PROCEDURE stkProductosCostoCierreDatos
(
@pProducto_Id VarChar(25),
@pEmpresa_Id int,
@pFecha datetime
)
AS
SET NOCOUNT ON 

SELECT stkProductos.Producto_Id, stkProductosCostoCierre.Empresa_Id, stkProductosCostoCierre.Fecha, stkProductosCostoCierre.Costo
	FROM stkProductosCostoCierre INNER JOIN stkProductos ON
		stkProductosCostoCierre.Producto_Id = stkProductos.stkProductos
		WHERE 
			stkProductos.Producto_Id = @pProducto_Id
	AND stkProductosCostoCierre.Empresa_Id = @pEmpresa_Id
	AND stkProductosCostoCierre.Fecha = @pFecha
 
RETURN @@Error 

GO

DROP PROCEDURE stkProductosCostoCierreEliminar
GO
CREATE PROCEDURE stkProductosCostoCierreEliminar
(
@pProducto_Id VarChar(25),
@pEmpresa_Id int ,
@pFecha datetime 
)
AS
SET NOCOUNT ON 

DELETE FROM stkProductosCostoCierre 
WHERE 
Producto_Id = dbo.FuncFKstkProductos(@pProducto_Id)
AND Empresa_Id = @pEmpresa_Id
AND Fecha = @pFecha
 
RETURN @@Error 

GO


DROP PROCEDURE stkProductosCierreTransito
go
CREATE PROCEDURE stkProductosCierreTransito
(
	@pStkMoviCabeEntr bigint
)
as

Update stkMoviCuerpo SET CostoUnitario = 
	(SELECT stkSalida.CostoUnitario
	from stkMoviCuerpo stkSalida, stkEnTransito 
	Where
		stkSalida.stkMoviCabe = stkEnTransito.stkMoviCabe and 
		stkEnTransito.stkMoviCabeEntr = stkMoviCuerpo.stkMoviCabe and
		stkSalida.Renglon = stkMoviCuerpo.Renglon)
WHERE
	stkMoviCuerpo.stkMoviCabe = @pStkMoviCabeEntr AND 
	EXISTS(SELECT stkSalida.CostoUnitario
	from stkMoviCuerpo stkSalida, stkEnTransito 
	Where
		stkSalida.stkMoviCabe = stkEnTransito.stkMoviCabe and 
		stkEnTransito.stkMoviCabeEntr = stkMoviCuerpo.stkMoviCabe and
		stkSalida.Renglon = stkMoviCuerpo.Renglon)

	-- y el asiento

	Update conMovCont 
		SET Importe = (SELECT SUM(
		ROUND(stkMoviCuerpo.Cantidad * stkMoviCuerpo.CostoUnitario,2))
		from stkMoviCuerpo
			where
				stkMoviCuerpo.stkMoviCabe = conMovCont.conAsientos AND 
				stkMoviCuerpo.conRenglonDebe = conMovCont.Renglon),

		ImporteMonedaOriginal =(SELECT SUM(
		ROUND(stkMoviCuerpo.Cantidad * stkMoviCuerpo.CostoUnitario,2))
		from stkMoviCuerpo
			where
				stkMoviCuerpo.stkMoviCabe = conMovCont.conAsientos AND 
				stkMoviCuerpo.conRenglonDebe = conMovCont.Renglon)
		where
			conMovCont.TipoMov = 1 and
			conMovCont.conAsientos = @pStkMoviCabeEntr

	Update conMovCont 
		SET Importe = (SELECT SUM(
		ROUND(stkMoviCuerpo.Cantidad * stkMoviCuerpo.CostoUnitario,2))
		from stkMoviCuerpo
			where
				stkMoviCuerpo.stkMoviCabe = conMovCont.conAsientos AND 
				stkMoviCuerpo.conRenglonHaber = conMovCont.Renglon), 
		ImporteMonedaOriginal = (SELECT SUM(
		ROUND(stkMoviCuerpo.Cantidad * stkMoviCuerpo.CostoUnitario,2))
		from stkMoviCuerpo
			where
				stkMoviCuerpo.stkMoviCabe = conMovCont.conAsientos AND 
				stkMoviCuerpo.conRenglonHaber = conMovCont.Renglon)
				where
				conMovCont.TipoMov = 2 and
			conMovCont.conAsientos = @pStkMoviCabeEntr

GO


