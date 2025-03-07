DROP PROCEDURE comTraePendientes 
GO
CREATE PROCEDURE comTraePendientes (
	@Proveed_Id VarChar(15), 
	@Moneda_Id VarChar(3), 
	@Signo Int,
	@Empresa_Id Int)

AS
select Cast(0 as bigint) as comMovProv, 0.00 as Importe, @Moneda_Id as Moneda_Id, @Proveed_Id as Proveee_id, @Signo as Signo

SELECT genMovCuotas.FechaVencimiento as Fecha, comMovProv.comMovProv, 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
		genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
		genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,
		genAsiSegmentos.Segmento4N) SegmentoStr, genMovCuotas.CuotaNro, 
		genMovCuotas.Importe,
		genMovCuotas.Saldo, genMovCuotas.Saldo*0 as ImporteAplicado
From comMovProv
inner join genMovCuotas ON comMovProv.comMovProv = genMovCuotas.Asiento_Id
INNER join comProveedores ON comProveedores.genEntidades = comMovprov.Proveed_Id
INNER JOIN conAsientos ON conAsientos.conAsientos = comMovProv.comMovProv
inner join genMonedas ON genMonedas.genMonedas =  conAsientos.Moneda_Id
inner join comMovTipos ON comMovTipos.TipoMov = comMovprov.TipoMov
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = comMovProv.comMovProv
Where
	commovprov.FacturaTesoreria = 0 and 
	genMovCuotas.Saldo > 0 And conAsientos.Anulado = 0 And conAsientos.Posteado = 1 And
	comMovTipos.Signo = @Signo and 
	comProveedores.Proveed_Id = @Proveed_Id and 
	genMonedas.Moneda_Id = @Moneda_Id And
	conAsientos.Empresa_Id = @Empresa_Id
order by 1, 2
GO
