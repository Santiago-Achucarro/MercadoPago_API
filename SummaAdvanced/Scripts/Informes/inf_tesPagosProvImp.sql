-- EXEC inf_tesPagosProvImp 1, 'TES',30796,0,0,0,'E','MXL','',''
DROP PROCEDURE inf_tesPagosProvImp
GO
CREATE PROCEDURE inf_tesPagosProvImp
(
	@Empresa_Id int, 
	@Segmento_Id VarChar(10),
	@Segmento1N Int,
	@Segmento2N Int,
	@Segmento3N Int,
	@Segmento4N Int,
	@Segmento1C VarChar(20),
	@Segmento2C VarChar(20),
	@Segmento3C VarChar(20),
	@Segmento4C VarChar(20)

)
AS
SET NOCOUNT ON 

SELECT comImpuestos.Impuesto_Id, comImpuestos.Descripcion,
	ROUND(SUM(comMovImpuestos.Importe_Impuesto *  genCancMov.Importe / Pago.Importe *  genCancMov.Importe / comMovProv.Importe ),2) AS Monto
from  genAsiSegmentos 
	inner join genSegmentos ON genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
	inner join genCancMov ON genCancMov.Asiento_Id = genAsiSegmentos.Asiento_Id
	inner join comMovProv on comMovProv.comMovProv =genCancMov.Asiento_Id_Ap
	inner join comMovProv as Pago on Pago.comMovProv = genAsiSegmentos.Asiento_Id
	inner join comMovImpuestos ON comMovImpuestos.comMovProv = comMovProv.comMovProv
	INNER JOIN comImpuestos on  comImpuestos.comImpuestos = comMovImpuestos.Impuesto_Id
where
	genSegmentos.Segmento_Id = @Segmento_Id and 
	genAsiSegmentos.Empresa_Id = @Empresa_id and 
	genAsiSegmentos.Segmento1N = @Segmento1N and 
	genAsiSegmentos.Segmento2N = @Segmento2N and 
	genAsiSegmentos.Segmento3N = @Segmento3N and 
	genAsiSegmentos.Segmento4N = @Segmento4N and 
	genAsiSegmentos.Segmento1C = @Segmento1C and 
	genAsiSegmentos.Segmento2C = @Segmento2C and 
	genAsiSegmentos.Segmento3C = @Segmento3C and 
	genAsiSegmentos.Segmento4C = @Segmento4C 
GROUP BY comImpuestos.Impuesto_Id, comImpuestos.Descripcion
ORDER BY 1