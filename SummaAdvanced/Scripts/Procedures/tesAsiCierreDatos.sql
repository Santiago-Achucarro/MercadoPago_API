DROP PROCEDURE tesAsiCierreDatosCierre
GO
CREATE PROCEDURE tesAsiCierreDatosCierre
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
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C
FROM conAsientos INNER JOIN genMonedas  ON 
genMonedas.genMonedas = conAsientos.Moneda_Id
inner join genAsiSegmentos ON
genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
inner join genSegmentos ON
genSegmentos.genSegmentos = genAsiSegmentos.Segmento_Id
WHERE conAsientos.Fecha= @pFecha  and 
conAsientos.Formulario_Id = dbo.FuncFKdisFormularios('frmtesoreriaCerrar') and
conAsientos.Anulado = 0 and 
conAsientos.Empresa_Id = @Empresa_Id

 
RETURN @@Error 

GO
