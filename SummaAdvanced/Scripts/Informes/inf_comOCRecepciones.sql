-- exec inf_comOCRecepcionesCabe 1, 'REOC',16,0,0,0,'FGZ',' ',' ',' '
-- exec inf_comOCRecepcionesCuerpo 1, 'REOC',16,0,0,0,'FGZ',' ',' ',' '
Drop Procedure inf_comOCRecepcionesCabe
GO

Create Procedure inf_comOCRecepcionesCabe(
	@Empresa_Id int, 
	@Segmento_Id VarChar(10), 
	@Segmento1N int,
	@Segmento2N int,
	@Segmento3N int,
	@Segmento4N int,
	@Segmento1C VarChar(20),
	@Segmento2C VarChar(20),
	@Segmento3C VarChar(20),
	@Segmento4C VarChar(20)
)
as

SELECT conAsientos.conAsientos, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, 
		genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,
		genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, 
		genAsiSegmentos.Segmento4N) AS Comprobante, 
		conAsientos.Fecha, genUsuarios.Usuario_Id,
		dbo.Segmento(comOCSegmentos.Segmento_Id, comOCSegmentos.Segmento1C,
		comOCSegmentos.Segmento2C, comOCSegmentos.Segmento3C, 
		comOCSegmentos.Segmento4C, comOCSegmentos.Segmento1N,
		comOCSegmentos.Segmento2N, comOCSegmentos.Segmento3N, 
		comOCSegmentos.Segmento4N) AS OrdenCompra, 
		comOrdenComp.Fecha as FechaOC,
		comProveedores.Proveed_Id, comProveedores.RazonSocial, 
		genMonedas.Moneda_Id, conAsientos.Cambio, 
		ISNULL(conCuentas.Cuenta_Id,' ') as Cuenta_Id, 
		ISNULL(conCuentas.Descripcion,' ') as DescripcionCuenta
from conAsientos 
	inner join genAsiSegmentos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
	inner join genSegmentos ON  genSegmentos.genSegmentos =genAsiSegmentos.Segmento_Id
	Inner join genUsuarios ON  genUsuarios.genUsuarios = conAsientos.Usuario_Id
	INNER JOIN (select Distinct comOrdenComp, comOcRecepcion from  comOcReceCuerpo) as comOcRecepcion on 
		comOcRecepcion.comOcRecepcion = conAsientos.conAsientos
	INNER JOIN comOrdenComp ON  comOrdenComp.comOrdenComp = comOcRecepcion.comOrdenComp
	INNER JOIN comProveedores ON  comProveedores.genEntidades = comOrdenComp.Proveed_Id
	INNER JOIN genMonedas ON genMonedas.genMonedas = conAsientos.Moneda_Id
	INNER JOIN comOCSegmentos ON comOCSegmentos.comOrdenComp = comOrdenComp.comOrdenComp
	LEFT JOIN conCuentas ON  conCuentas.conCuentas = genMonedas.CtaFactaRecibir
	WHERE
		genSegmentos.Segmento_Id = @Segmento_Id and 
		genAsiSegmentos.Segmento1C = @Segmento1C AND
		genAsiSegmentos.Segmento2C = @Segmento2C AND
		genAsiSegmentos.Segmento3C = @Segmento3C AND
		genAsiSegmentos.Segmento4C = @Segmento4C AND
		genAsiSegmentos.Segmento1N = @Segmento1N AND
		genAsiSegmentos.Segmento2N = @Segmento2N AND
		genAsiSegmentos.Segmento3N = @Segmento3N AND
		genAsiSegmentos.Segmento4N = @Segmento4N 

		
GO


Drop Procedure inf_comOCRecepcionesCuerpo
GO

Create Procedure inf_comOCRecepcionesCuerpo(
	@Empresa_Id int, 
	@Segmento_Id VarChar(10), 
	@Segmento1N int,
	@Segmento2N int,
	@Segmento3N int,
	@Segmento4N int,
	@Segmento1C VarChar(20),
	@Segmento2C VarChar(20),
	@Segmento3C VarChar(20),
	@Segmento4C VarChar(20)
)
as

SELECT conAsientos.conAsientos, comOcReceCuerpo.Renglon_OC, 
	comOCMemo.Detalle, comOcReceCuerpo.Cantidad, comocCuerpo.Precio, 
		round(comOcReceCuerpo.Cantidad * comocCuerpo.Precio * conAsientos.Cambio,2) as Monto,
	conCuentas.Cuenta_Id, 
		conCuentas.Descripcion, ISNULL(conCentro1.Centro1_Id,' ') AS Centro1_Id, 
		ISNULL(conCentro2.Centro2_Id,' ') as Centro2_Id
	
from conAsientos 
	inner join genAsiSegmentos ON conAsientos.conAsientos = genAsiSegmentos.Asiento_Id
	inner join genSegmentos ON  genSegmentos.genSegmentos =genAsiSegmentos.Segmento_Id
	INNER JOIN comOcReceCuerpo on 
		comOcReceCuerpo.comOcRecepcion = conAsientos.conAsientos
	INNER JOIN comOCMemo ON  comOCMemo.comOrdenComp = comOcReceCuerpo.comOrdenComp AND 
		comOCMemo.Renglon_OC = comOcReceCuerpo.Renglon_OC
	inner join conCuentas ON conCuentas.conCuentas = comOCMemo.Cuenta_Id
	inner join comOCCuerpo ON comOCMemo.comOrdenComp = comOCCuerpo.comOrdenComp AND 
		comOCMemo.Renglon_OC = comOCCuerpo.Renglon_OC
	LEFT JOIN conCentro1 ON conCentro1.conCentro1 = comOCCuerpo.Centro1_Id
	LEFT JOIN conCentro2 ON conCentro2.conCentro2 = comOCCuerpo.Centro2_Id

	WHERE
		genSegmentos.Segmento_Id = @Segmento_Id and 
		genAsiSegmentos.Segmento1C = @Segmento1C AND
		genAsiSegmentos.Segmento2C = @Segmento2C AND
		genAsiSegmentos.Segmento3C = @Segmento3C AND
		genAsiSegmentos.Segmento4C = @Segmento4C AND
		genAsiSegmentos.Segmento1N = @Segmento1N AND
		genAsiSegmentos.Segmento2N = @Segmento2N AND
		genAsiSegmentos.Segmento3N = @Segmento3N AND
		genAsiSegmentos.Segmento4N = @Segmento4N 

GO