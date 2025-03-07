-- comFacturasConOrdenDeCompraDatos 1, 'FPRO',1020,0,0,0,' ','R','0110',' ', 'OC',1318,0,0,0,'CCG',' ',' ',' '


DROP PROCEDURE comFacturasConOrdenDeCompraDatos
GO
CREATE PROCEDURE comFacturasConOrdenDeCompraDatos
(
@pEmpresa_Id int, 
@pSegmento_Id VarChar(10), 
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C VarChar(20),
@pSegmento2C VarChar(20),
@pSegmento3C VarChar(20),
@pSegmento4C VarChar(20),
@pSegmento_Id_OC VarChar(10), 
@pSegmento1N_OC int,
@pSegmento2N_OC int,
@pSegmento3N_OC int,
@pSegmento4N_OC int,
@pSegmento1C_OC VarChar(20),
@pSegmento2C_OC VarChar(20),
@pSegmento3C_OC VarChar(20),
@pSegmento4C_OC VarChar(20)

)


AS
SET NOCOUNT ON 

DECLARE @pComMovProv bigint

SET @pComMovProv = (
SELECT Asiento_id from genAsiSegmentos where
	Empresa_Id = @pEmpresa_id and 
	Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_id) and
	Segmento1N =@pSegmento1N and
	Segmento2N = @pSegmento2N and
	Segmento3N = @pSegmento3N and
	Segmento4N = @pSegmento4N and
	Segmento1C = @pSegmento1C and
	Segmento2C = @pSegmento2C and 
	Segmento3C = @pSegmento3C and 
	Segmento4C = @pSegmento4C )
	
	
exec comMovprovDatos @pComMovProv

--- Averiguo si es Nota de Credito
Declare @EsNC INT = 0
DECLARE @pOrigen int = 0

SELECT @pOrigen = Origen1C FROM genSegmentos where Segmento_Id = @pSegmento_Id
if (@pOrigen = 8 and @pSegmento1C= 'R')
	SET @EsNC = 1
SELECT @pOrigen = Origen2C FROM genSegmentos where Segmento_Id = @pSegmento_Id
if (@pOrigen = 8 and @pSegmento2C= 'R')
	SET @EsNC = 1
SELECT @pOrigen = Origen3C FROM genSegmentos where Segmento_Id = @pSegmento_Id
if (@pOrigen = 8 and @pSegmento3C= 'R')
	SET @EsNC = 1
SELECT @pOrigen = Origen4C FROM genSegmentos where Segmento_Id = @pSegmento_Id
if (@pOrigen = 8 and @pSegmento4C= 'R')
	SET @EsNC = 1


if @pComMovProv is null
BEGIN
-- Tiene que traer lo pendiente porque es la carga de una nueva factura --

	SELECT comOCSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
		comOCSegmentos.Segmento1N, comOCSegmentos.Segmento2N,
		comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N,
		comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C,
		comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,
		comOrdenComp.Fecha, comProveedores.Proveed_Id, comProveedores.RazonSocial, 
		genMonedas.Moneda_Id,comconpago.CondPago_Id, comConPago.Descripcion as DescripcionConPago
	From comOCSegmentos 
	INNER JOIN comOrdenComp on comOCSegmentos.comOrdenComp = comOrdenComp.comOrdenComp
	INNER JOIN comProveedores ON comProveedores.genEntidades = comOrdenComp.Proveed_id
	INNER JOIN genMonedas ON genMonedas.genMonedas = comOrdenComp.Moneda_Id
	INNER JOIN genSegmentos	ON genSegmentos.genSegmentos = comOCSegmentos.Segmento_Id
	inner join comConPago on comOrdenComp.CondPago_Id=comConPago.comConPago
	WHERE 	
		comOCSegmentos.Empresa_Id = @pEmpresa_id and 
		comOCSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_id_OC) and
		comOCSegmentos.Segmento1N = @pSegmento1N_OC and
		comOCSegmentos.Segmento2N = @pSegmento2N_OC and
		comOCSegmentos.Segmento3N = @pSegmento3N_OC and
		comOCSegmentos.Segmento4N = @pSegmento4N_OC and
		comOCSegmentos.Segmento1C = @pSegmento1C_OC and
		comOCSegmentos.Segmento2C = @pSegmento2C_OC and 
		comOCSegmentos.Segmento3C = @pSegmento3C_OC and 
		comOCSegmentos.Segmento4C = @pSegmento4C_OC 
	ORDER BY 2

	/* No se usa
	DECLARE @pComOrdenComp as Int
	SET @pComOrdenComp = (SELECT comOrdenComp 
		FROM comOCSegmentos WHERE 
		(Empresa_Id = @pEmpresa_Id) AND 
		(Segmento_Id = dbo.FuncFkgenSegmentos(@pSegmento_Id)) AND 
		(Segmento1N = @pSegmento1N) AND 
		(Segmento2N = @pSegmento2N) AND 
		(Segmento3N = @pSegmento3N) AND 
		(Segmento4N = @pSegmento4N) AND 
		(Segmento1C = @pSegmento1C) AND 
		(Segmento2C = @pSegmento2C) AND 
		(Segmento3C = @pSegmento3C) AND 
		(Segmento4C = @pSegmento4C))
	*/
	

	
	SELECT Convert(bigint, 0) AS comMovProv, comOCCuerpo.Renglon_OC Renglon, 0 RenglonReferencia, 	
		stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
		stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, 
		comOCArticulo.Factor, comOCCuerpo.Cantidad*0 as Cantidad,
		comOCCuerpo.Cantidad*0 as CantidadForm, comOcArticulo.PrecioOriginal as CostoUnitario, 
		comOCArticulo.PrecioOriginal, 0 as conRenglonDebe, 
		comOcArticulo.CantidadOriginal as CantidadOC, comOcCuerpo.Cantidad_Recibida - comOCCuerpo.Cantidad_Facturada + comOCCuerpo.Cantidad_Creditos as CantidadPendiente,
		comOcCuerpo.Precio, comOCCuerpo.Renglon_OC, comOCCuerpo.comOrdenComp, 'P' ProdMemo
	FROM comOCSegmentos 
	INNER JOIN comOcCuerpo ON comOCSegmentos.comOrdenComp = comOcCuerpo.comOrdenComp
	INNER JOIN comOcArticulo ON comOcCuerpo.comOrdenComp = comOcArticulo.comOrdenComp and comOcCuerpo.Renglon_OC = comOcArticulo.Renglon_OC
	INNER JOIN stkProductos  ON (stkProductos.stkProductos = comOcArticulo.Producto_Id)
	INNER JOIN stkUniMed  ON (stkUniMed.stkUniMed = comOcCuerpo.Medida_Id)

	WHERE 
	(@EsNC =1 OR
	comOcCuerpo.Cantidad_Recibida - comOCCuerpo.Cantidad_Facturada + comOCCuerpo.Cantidad_Creditos > 0) and 
		comOCSegmentos.Empresa_Id = @pEmpresa_id and 
		comOCSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_id_OC) and
		comOCSegmentos.Segmento1N = @pSegmento1N_OC and
		comOCSegmentos.Segmento2N = @pSegmento2N_OC and
		comOCSegmentos.Segmento3N = @pSegmento3N_OC and
		comOCSegmentos.Segmento4N = @pSegmento4N_OC and
		comOCSegmentos.Segmento1C = @pSegmento1C_OC and
		comOCSegmentos.Segmento2C = @pSegmento2C_OC and 
		comOCSegmentos.Segmento3C = @pSegmento3C_OC and 
		comOCSegmentos.Segmento4C = @pSegmento4C_OC 
	union all
	SELECT Convert(bigint, 0) AS comMovProv, comOCCuerpo.Renglon_OC Renglon, 0 RenglonReferencia, 	
		' ' Producto_Id, comOCMemo.Detalle as DescripcionProductos,
		stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, 
		1 Factor, comOCCuerpo.Cantidad*0 as Cantidad,
		comOCCuerpo.Cantidad*0 as CantidadForm, comOcCuerpo.Precio as CostoUnitario, 
		comOcCuerpo.Precio PrecioOriginal, 0 as conRenglonDebe, 
		comOcCuerpo.Cantidad as CantidadOC, comOcCuerpo.Cantidad_Recibida - comOCCuerpo.Cantidad_Facturada + comOCCuerpo.Cantidad_Creditos as CantidadPendiente,
		comOcCuerpo.Precio, comOCCuerpo.Renglon_OC, comOCCuerpo.comOrdenComp, 'M' ProdMemo
	FROM comOCSegmentos 
	INNER JOIN comOcCuerpo ON comOCSegmentos.comOrdenComp = comOcCuerpo.comOrdenComp
	INNER JOIN comOCMemo ON comOCCuerpo.comOrdenComp = comOCMemo.comOrdenComp and comOcCuerpo.Renglon_OC = comOCMemo.Renglon_OC
	INNER JOIN stkUniMed  ON (stkUniMed.stkUniMed = comOcCuerpo.Medida_Id)
	WHERE 
	(@EsNC = 1 OR  comOcCuerpo.Cantidad_Recibida - comOCCuerpo.Cantidad_Facturada + comOCCuerpo.Cantidad_Creditos > 0) and 
		comOCSegmentos.Empresa_Id = @pEmpresa_id and 
		comOCSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_id_OC) and
		comOCSegmentos.Segmento1N = @pSegmento1N_OC and
		comOCSegmentos.Segmento2N = @pSegmento2N_OC and
		comOCSegmentos.Segmento3N = @pSegmento3N_OC and
		comOCSegmentos.Segmento4N = @pSegmento4N_OC and
		comOCSegmentos.Segmento1C = @pSegmento1C_OC and
		comOCSegmentos.Segmento2C = @pSegmento2C_OC and 
		comOCSegmentos.Segmento3C = @pSegmento3C_OC and 
		comOCSegmentos.Segmento4C = @pSegmento4C_OC 

 
END

ELSE
-- Cuerpo
-- Es una consulta de una factura existente --
BEGIN

	SELECT comOCSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
		comOCSegmentos.Segmento1N, comOCSegmentos.Segmento2N,
		comOCSegmentos.Segmento3N, comOCSegmentos.Segmento4N,
		comOCSegmentos.Segmento1C, comOCSegmentos.Segmento2C,
		comOCSegmentos.Segmento3C, comOCSegmentos.Segmento4C,
		comOrdenComp.Fecha, comProveedores.Proveed_Id, comProveedores.RazonSocial, 
		genMonedas.Moneda_Id,comconpago.CondPago_Id, comConPago.Descripcion as DescripcionConPago
	From comOCSegmentos 
	INNER JOIN comOrdenComp on comOCSegmentos.comOrdenComp = comOrdenComp.comOrdenComp
	INNER JOIN comProveedores ON comProveedores.genEntidades = comOrdenComp.Proveed_id
	INNER JOIN genMonedas ON genMonedas.genMonedas = comOrdenComp.Moneda_Id
	INNER JOIN genSegmentos	ON genSegmentos.genSegmentos = comOCSegmentos.Segmento_Id
	inner join comConPago on comConPago.comConPago=comOrdenComp.CondPago_Id
	WHERE 
		Exists(select 1 from comMovPOC where
			comMovPOC.comMovProv = @pComMovProv and 
			comMovPOC.comOrdenComp = comOrdenComp.comOrdenComp)
	ORDER BY 2

	
	SELECT comMovPOC.comMovProv, comMovPOC.Renglon_OC as Renglon, 0 RenglonReferencia, 	
		stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
		stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, 
		comOCArticulo.Factor, comMovPOC.Cantidad as Cantidad,
		comMovPOC.CantidadOriginal as CantidadForm, comOcCuerpo.Precio as CostoUnitario, 
		comOCArticulo.PrecioOriginal, 0 as conRenglonDebe, 
		comOCArticulo.CantidadOriginal as CantidadOC, comOcCuerpo.Cantidad_Recibida - comOCCuerpo.Cantidad_Facturada + comOCCuerpo.Cantidad_Creditos as CantidadPendiente,
		comOcCuerpo.Precio, comOCCuerpo.Renglon_OC,comOCCuerpo.comOrdenComp, 'P' ProdMemo
	FROM comMovPOC 
	Inner join comOCSegmentos on comMovPOC.comOrdenComp = comOCSegmentos.comOrdenComp
	INNER JOIN comOcCuerpo ON comMovPOC.comOrdenComp = comOcCuerpo.comOrdenComp and comMovPOC.Renglon_OC=comOCCuerpo.Renglon_OC
	INNER JOIN comOcArticulo ON comOcCuerpo.comOrdenComp = comOcArticulo.comOrdenComp and comOcCuerpo.Renglon_OC = comOcArticulo.Renglon_OC
	INNER JOIN stkProductos  ON (stkProductos.stkProductos = comOcArticulo.Producto_Id)
	INNER JOIN stkUniMed  ON (stkUniMed.stkUniMed = comOcCuerpo.Medida_Id)

	WHERE 
		comMovPOC.comMovProv = @pComMovProv
	UNION ALL
	SELECT comMovPOC.comMovProv, comMovPOC.Renglon_OC as Renglon, 0 RenglonReferencia, 	
		' ' Producto_Id, comOCMemo.Detalle as DescripcionProductos,
		stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, 
		1 Factor, comMovPOC.Cantidad as Cantidad,
		comMovPOC.CantidadOriginal as CantidadForm, comOcCuerpo.Precio as CostoUnitario, 
		comOCCuerpo.Precio AS PrecioOriginal, 0 as conRenglonDebe, 
		comOcCuerpo.Cantidad as CantidadOC, 
		comOcCuerpo.Cantidad_Recibida - comOCCuerpo.Cantidad_Facturada + comOCCuerpo.Cantidad_Creditos as CantidadPendiente,
		comOcCuerpo.Precio, comOCCuerpo.Renglon_OC,comOCCuerpo.comOrdenComp, 'M' ProdMemo
	FROM comMovPOC 
	Inner join comOCSegmentos on comMovPOC.comOrdenComp = comOCSegmentos.comOrdenComp
	INNER JOIN comOcCuerpo ON comMovPOC.comOrdenComp = comOcCuerpo.comOrdenComp and comMovPOC.Renglon_OC = comOCCuerpo.Renglon_OC
	INNER JOIN comOCMemo ON comOcCuerpo.comOrdenComp = comOCMemo.comOrdenComp and comOcCuerpo.Renglon_OC = comOCMemo.Renglon_OC
	INNER JOIN stkUniMed  ON (stkUniMed.stkUniMed = comOcCuerpo.Medida_Id)

	WHERE 

		comMovPOC.comMovProv = @pComMovProv
END


exec comMovImpuestosDatos @pComMovProv, null
Exec genAtributosGeneralesIdentityDatos @pComMovProv, 'comMovProv' 
Exec genMovCuotasDatos @pComMovProv, null
Exec comFactuReceOcDatos @pcomMovProv
Exec comFactuReceOcDatos @pcomMovProv

-- AJ Abr 19 Se agrega la posibilidad de Ajuste positivo o Negativo

Select commovprov.RenglonDtoFin , conCuentas.Cuenta_Id, 
	conCuentas.Descripcion as DescripcionCuenta, 
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, 
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, 
	conMovCont.Importe, conMovCont.ImporteMonedaOriginal, 
	conMovCont.LeyendaLibroMayor as Leyenda
from commovprov inner join conMovCont on 
commovprov.comMovProv = conMovcont.conAsientos and 
commovprov.RenglonDtoFin = conMovcont.Renglon
INNER JOIN conCuentas ON 
conCuentas.conCuentas = conmovCont.Cuenta_Id
LEFT JOIN conCentro1 ON
conCentro1.conCentro1 = conMovcont.Centro1_Id
LEFT JOIN conCentro2 ON 
conCentro2.conCentro2 = conMovcont.Centro2_Id
Where
	comMovProv.comMovProv = @pComMovProv

Exec genAdjuntosDatos 'comMovprov', @pComMovProv, 0

RETURN @@Error 

GO

