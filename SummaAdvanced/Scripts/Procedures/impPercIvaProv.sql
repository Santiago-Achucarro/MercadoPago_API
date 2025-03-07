Drop PROCEDURE impPercIvaProv
GO

CREATE PROCEDURE impPercIvaProv
(
@pEmpresa_Id INT,
@pFechaDesde DATETIME,
@pFechaHasta DATETIME
)
AS

SELECT @pEmpresa_Id Empresa_Id, @pFechaDesde FechaDesde, @pFechaHasta FechaHasta


select  genentidades.cuit, comImpuestos.descripcion,conMovcont.Importe,
		 genAsiSegmentos.Segmento1C Sucursal_CCP, genAsiSegmentos.Segmento1N Comprobante_CCP, 
		 comMovProv.TipoMov Tipomov_ccp, genAsiSegmentos.Segmento4C Letra_CCP, conAsientos.Fecha 
		 FROM comMovProv INNER JOIN conAsientos on 
		 conAsientos.conAsientos = comMovprov.comMovprov 
		 inner join 
		 comProveedores ON comMovProv.Proveed_id = comMovprov.Proveed_id
		  INNER JOIN genentidades on 
		  comProveedores.genentidades = genentidades.genentidades
		  inner join 
		 comMovImpuestos ON comMovImpuestos.comMovProv = conAsientos.conAsientos
		 inner join 
		 comImpuestos ON comMovImpuestos.Impuesto_id = comImpuestos.comImpuestos
		 inner join genAsisegmentos on 
		 genAsisegmentos.segmento_Id = 2 and 
		 genAsisegmentos.asiento_Id = conAsientos.conAsientos
		 inner join conMovcont on 
		 comMovimpuestos.comMovprov = conMovcont.conAsientos and
		 comMovimpuestos.conRenglon = conMovcont.Renglon
		 INNER JOIN impTipoImpuesto ON
		 impTipoImpuesto.TipoImpuesto = comImpuestos.TipoImpuesto and 
		 impTipoImpuesto.Referencia04 = 'PERC' AND impTipoImpuesto.Referencia02 IN ('IVA')
		  WHERE  
		  conAsientos.Fecha BETWEEN @pFechaDesde and @pFechaHasta AND 
		 conAsientos.Anulado = 0 AND conAsientos.Posteado = 1 AND
		conAsientos.Empresa_Id = @pEmpresa_Id 
Go
