--SELECT * FROM genAsiSegmentos
--- comFacturasConOrdenDeEmbarque 1, 'FPRO',11,0,0,0,'MX','R','Q001',' ','EMB',119,0,0,0,'0001',' ',' ',' ','E048'
DROP PROCEDURE comFacturasConOrdenDeEmbarque
GO
CREATE PROCEDURE comFacturasConOrdenDeEmbarque
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
@pSegmento_Id_EMB VarChar(10), 
@pSegmento1N_EMB int,
@pSegmento2N_EMB int,
@pSegmento3N_EMB int,
@pSegmento4N_EMB int,
@pSegmento1C_EMB VarChar(20),
@pSegmento2C_EMB VarChar(20),
@pSegmento3C_EMB VarChar(20),
@pSegmento4C_EMB VarChar(20),
@pProveed_id VarChar(15)=NULL
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

if @pComMovProv is null
BEGIN
-- Tiene que traer lo pendiente porque es la carga de una nueva factura --

	SELECT genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
		genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		comEmbarques.FechaArribo,	comEmbarques.comEmbarques
	From genAsiSegmentos
	INNER JOIN comEmbarques on genAsiSegmentos.Asiento_Id = comEmbarques.comEmbarques


	INNER JOIN genSegmentos	ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	left join comConPago on comConPago.comConPago = (select MAX(comOrdenComp.CondPago_Id) FROM comEmbCuerpo, comOrdenComp WHERE
				comOrdenComp.comOrdenComp = comEmbCuerpo.comOrdenComp and 
				comEmbCuerpo.comEmbarques = comEmbarques.comEmbarques)
	WHERE 	
		genAsiSegmentos.Empresa_Id =@pEmpresa_id and 
		genSegmentos.Segmento_Id = @pSegmento_id_EMB and
		genAsiSegmentos.Segmento1N =@pSegmento1N_EMB and
		genAsiSegmentos.Segmento2N = @pSegmento2N_EMB and
		genAsiSegmentos.Segmento3N = @pSegmento3N_EMB and
		genAsiSegmentos.Segmento4N = @pSegmento4N_EMB and
		genAsiSegmentos.Segmento1C = @pSegmento1C_EMB and
		genAsiSegmentos.Segmento2C = @pSegmento2C_EMB and 
		genAsiSegmentos.Segmento3C = @pSegmento3C_EMB and 
		genAsiSegmentos.Segmento4C = @pSegmento4C_EMB 
	ORDER BY 2




	
	SELECT Convert(bigint, 0) AS comMovProv, comOCCuerpo.Renglon_OC Renglon, 0 RenglonReferencia, 	
		stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
		stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, 
		comOCArticulo.Factor, comOCCuerpo.Cantidad*0 as Cantidad,
		comOCCuerpo.Cantidad*0 as CantidadForm, comOCArticulo.PrecioOriginal as CostoUnitario, 
		comOCArticulo.PrecioOriginal, 0 as conRenglonDebe, 
		comOCArticulo.CantidadOriginal as CantidadOC, case when @pSegmento1C='R' then  comEmbCuerpo.CantidadFacturada-comEmbCuerpo.Cantidad else comEmbCuerpo.Cantidad - comEmbCuerpo.CantidadFacturada end as CantidadPendiente, --TODO Verificar si el Segmento1C es el TipoMov
		comOcCuerpo.Precio, comOCCuerpo.Renglon_OC,comOCCuerpo.comOrdenComp
	FROM genAsiSegmentos
	INNER JOIN comEmbCuerpo ON genAsiSegmentos.Asiento_Id = comEmbCuerpo.comEmbarques
	INNER JOIN comOcCuerpo ON comEmbCuerpo.comOrdenComp = comOCCuerpo.comOrdenComp AND comEmbCuerpo.Renglon_OC = comOCCuerpo.Renglon_OC
	INNER JOIN comOcArticulo ON comOcCuerpo.comOrdenComp = comOcArticulo.comOrdenComp and comOcCuerpo.Renglon_OC = comOcArticulo.Renglon_OC
	INNER JOIN stkProductos  ON (stkProductos.stkProductos = comOcArticulo.Producto_Id)
	INNER JOIN stkUniMed  ON (stkUniMed.stkUniMed = comOcCuerpo.Medida_Id)
	INNER JOIN comOrdenComp on comEmbCuerpo.comOrdenComp = comOrdenComp.comOrdenComp
	WHERE 
		case when @pSegmento2C='R' then  comEmbCuerpo.CantidadFacturada-comEmbCuerpo.CantidadRecibida else comEmbCuerpo.Cantidad - comEmbCuerpo.CantidadFacturada end > 0 and 
		genAsiSegmentos.Empresa_Id =@pEmpresa_id and 
		genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_id_EMB) and
		genAsiSegmentos.Segmento1N =@pSegmento1N_EMB and
		genAsiSegmentos.Segmento2N = @pSegmento2N_EMB and
		genAsiSegmentos.Segmento3N = @pSegmento3N_EMB and
		genAsiSegmentos.Segmento4N = @pSegmento4N_EMB and
		genAsiSegmentos.Segmento1C = @pSegmento1C_EMB and
		genAsiSegmentos.Segmento2C = @pSegmento2C_EMB and 
		genAsiSegmentos.Segmento3C = @pSegmento3C_EMB and 
		genAsiSegmentos.Segmento4C = @pSegmento4C_EMB AND 
		comOrdenComp.Proveed_Id = dbo.FuncFKcomProveedores(@pProveed_id)

	-- Gastos

	SELECT comEmbGastos.Renglon, comEmbGastos.Detalle, comEmbGastos.ImporteOriginal, 
		genMonedas.Moneda_Id, comEmbGastos.ImporteOriginal*0 AS Monto, 
		comEmbGastos.Renglon as comRenglon
	FROM comEmbGastos 
	inner join genMonedas ON comEmbGastos.Moneda_Id = genMonedas.genMonedas
	INNER JOIN genAsiSegmentos ON 	genAsiSegmentos.Asiento_Id = comEmbGastos.comEmbarques
	Where
		genAsiSegmentos.Empresa_Id = @pEmpresa_id and 
		genAsiSegmentos.Segmento_Id = dbo.FuncFKgenSegmentos(@pSegmento_id_EMB) and
		genAsiSegmentos.Segmento1N = @pSegmento1N_EMB and
		genAsiSegmentos.Segmento2N = @pSegmento2N_EMB and
		genAsiSegmentos.Segmento3N = @pSegmento3N_EMB and
		genAsiSegmentos.Segmento4N = @pSegmento4N_EMB and
		genAsiSegmentos.Segmento1C = @pSegmento1C_EMB and
		genAsiSegmentos.Segmento2C = @pSegmento2C_EMB and 
		genAsiSegmentos.Segmento3C = @pSegmento3C_EMB and 
		genAsiSegmentos.Segmento4C = @pSegmento4C_EMB 
		ORDER BY 1
END

ELSE
-- Cuerpo
-- Es una consulta de una factura existente --
BEGIN
	--segmento
	if exists(select 1 from comMovProvEmb where comMovProv=@pComMovProv)
	begin
	SELECT genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
		genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		comEmbarques.FechaArribo, comEmbarques.comEmbarques
	From genAsiSegmentos 
	INNER JOIN comEmbarques on comEmbarques.comEmbarques = genAsiSegmentos.Asiento_Id
	inner join comMovProvEmb on comMovProvEmb.comEmbarques = comEmbarques.comEmbarques
	inner join comMovProv ON  comMovProv.comMovProv = comMovProvEmb.comMovProv
	INNER JOIN comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_id
	Inner join conAsientos ON conAsientos.conAsientos = comMovProv.comMovProv 
	INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN genSegmentos	ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	WHERE 
			comMovProv.comMovProv = @pComMovProv 
	ORDER BY 2
end
else
BEGIN
SELECT genAsiSegmentos.Empresa_Id, genSegmentos.Segmento_Id, 
		genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N,
		genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N,
		genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C,
		genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		comEmbarques.FechaArribo, comEmbarques.comEmbarques
	From genAsiSegmentos 
	INNER JOIN comEmbarques on comEmbarques.comEmbarques = genAsiSegmentos.Asiento_Id
	inner join comEmbGastoMovProv on comEmbGastoMovProv.comEmbarques = comEmbarques.comEmbarques
	inner join comMovProv ON  comMovProv.comMovProv = comEmbGastoMovProv.comMovProv
	INNER JOIN comProveedores ON comProveedores.genEntidades = comMovProv.Proveed_id
	Inner join conAsientos ON conAsientos.conAsientos = comMovProv.comMovProv 
	INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN genSegmentos	ON genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
	WHERE 
			comMovProv.comMovProv = @pComMovProv 
	ORDER BY 2
end
		--cuerpo
	SELECT comMovProvEmb.comMovProv, comOCCuerpo.Renglon_OC as Renglon, 0 RenglonReferencia, 	
		stkProductos.Producto_Id, stkProductos.Descripcion as DescripcionProductos,
		stkUniMed.Medida_Id, stkUniMed.Descripcion as DescripcionUniMed, 
		comOCArticulo.Factor, comMovPOC.Cantidad as Cantidad,
		comMovPOC.CantidadOriginal as CantidadForm, comOcCuerpo.Precio as CostoUnitario, 
		comOCArticulo.PrecioOriginal, 0 as conRenglonDebe, 
		comEmbCuerpo.Cantidad as CantidadOC, comEmbCuerpo.Cantidad - comEmbCuerpo.CantidadFacturada as CantidadPendiente,
		comOcCuerpo.Precio, comOCCuerpo.Renglon_OC,comOCCuerpo.comOrdenComp
	FROM comMovProvEmb
	INNER JOIN comMovPOC ON comMovPOC.comMovProv = comMovProvEmb.comMovProv 
	INNER JOIN  comOcCuerpo ON comMovPOC.comOrdenComp = comOcCuerpo.comOrdenComp and comMovPOC.Renglon_OC = comOCCuerpo.Renglon_OC	
	INNER JOIN comOcArticulo ON comOcCuerpo.comOrdenComp = comOcArticulo.comOrdenComp and comOcCuerpo.Renglon_OC = comOcArticulo.Renglon_OC
	INNER JOIN comEmbCuerpo ON comEmbCuerpo.comEmbarques = comMovProvEmb.comEmbarques and comEmbCuerpo.comOrdenComp = comOcArticulo.comOrdenComp and 
							  comEmbCuerpo.Renglon_OC = comOcArticulo.Renglon_OC
	INNER JOIN stkProductos ON (stkProductos.stkProductos = comOcArticulo.Producto_Id)
	INNER JOIN stkUniMed ON (stkUniMed.stkUniMed = comOcCuerpo.Medida_Id)

	WHERE 
		comMovProvEmb.comMovProv = @pComMovProv

	-- Gastos

	SELECT comEmbGastos.Renglon, comEmbGastos.Detalle, comEmbGastos.ImporteOriginal, 
		genMonedas.Moneda_Id, comMovDetalle.Importe AS Monto,
		comEmbGastoMovProv.comRenglon
	FROM comEmbGastos 
	Inner join genMonedas ON comEmbGastos.Moneda_Id = genMonedas.genMonedas
	INNER JOIN comEmbGastoMovProv ON comEmbGastoMovProv.comEmbarques = comEmbGastos.comEmbarques and 
		comEmbGastoMovProv.Renglon = comEmbGastos.Renglon
	INNER JOIN comMovDetalle ON comMovDetalle.comMovProv =  comEmbGastoMovProv.comMovProv and
		comMovDetalle.Renglon =comEmbGastoMovProv.comRenglon
	Where
		comEmbGastoMovProv.comMovProv = @pComMovProv
	ORDER BY 1

end

exec comMovImpuestosDatos @pComMovProv, null
Exec genAtributosGeneralesIdentityDatos @pComMovProv, 'comMovProv' 
Exec genMovCuotasDatos @pComMovProv, null

Exec genAdjuntosDatos 'comMovprov', @pComMovProv, 0
 
RETURN @@Error 

GO

