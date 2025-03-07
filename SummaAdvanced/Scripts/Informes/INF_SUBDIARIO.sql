-- INF_SUBDIARIO '20201101','20211031', 1, 'es'
-- INF_SUBDIARIO '20201101','20211031', 1, 'en'
DROP PROCEDURE INF_SUBDIARIO 
GO
CREATE PROCEDURE INF_SUBDIARIO (
@FechaDesde DATETIME, 
@FechaHasta DATETIME, 
@Empresa int ,@Cultura VarChar(5)=null)
as

Declare @EnOtro bit 
set @EnOtro = (Select dbo.EnOtroLenguaje(@Cultura))

 
SELECT  conAsientos.conAsientos, 
 dbo.Segmento(genAsiSegmentos.Segmento_Id,
	genAsiSegmentos.Segmento1C, genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, 
	genAsiSegmentos.Segmento4C, genAsiSegmentos.Segmento1N,  
	genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N,   
	genAsiSegmentos.Segmento4N) as Segmento,
	conAsientos.Fecha, conAsientos.Posteado, conAsientos.Observaciones, 
	genMonedas.Moneda_id, genMonedas.Descripcion as DescripcionMoneda,
	genUsuarios.Usuario_id, conAsientos.FechaRegistro, 
	disFormularios.Formulario_Id, disFormularios.Descripcion as DescripcionFormulario, 
	conCuentas.Cuenta_Id, 
	CASE WHEN @EnOtro=1 THEN conCuentas.Description ELSE conCuentas.Descripcion END as DescripcionCuenta,
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2,
	conMovCont.LeyendaLibroMayor, 
	case when conMovCont.Tipomov = 1 then conMovCont.Importe else 0 end as Debe,
	case when conMovCont.Tipomov = 2 then conMovCont.Importe else 0 end as Haber,
	case when conMovCont.Tipomov = 1 then conMovCont.ImporteMonedaOriginal else 0 end as DebeOriginal,
	case when conMovCont.Tipomov = 2 then conMovCont.ImporteMonedaOriginal else 0 end as HaberOriginal
	
FROM genAsiSegmentos INNER JOIN conAsientos ON	
	genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	left outer JOIN disFormularios ON 
	disFormularios.disFormularios = conAsientos.Formulario_Id
	LEFT OUTER JOIN genMonedas ON
	genMonedas.genMonedas = conAsientos.Moneda_id
	INNER JOIN genUsuarios ON
	genUsuarios.genUsuarios= conAsientos.Usuario_Id
	INNER JOIN conMovCont ON
	conMovCont.conAsientos = conAsientos.conAsientos
	INNER JOIN conCuentas ON
	conCuentas.conCuentas = conMovCont.Cuenta_id
	LEFT OUTER JOIN conCentro1 ON
	conCentro1.conCentro1 = conMovCont.Centro1_Id
	LEFT OUTER JOIN conCentro2 ON
	conCentro2.conCentro2 = conMovCont.Centro2_Id
	inner join genEmpresas ON  genEmpresas.genEmpresas = conAsientos.Empresa_Id
	left join conAsientosCon ON conAsientosCon.conAsientos = conAsientos.conAsientos
WHERE
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado =1 and 
	conAsientos.Fecha between @FechaDesde and @FechaHasta AND 
	conAsientos.Empresa_Id = @Empresa and 
	(conAsientos.Fecha >= genEmpresas.FechaInicioSumma or conAsientosCon.conAsientos IS Not NULL)
ORDER BY conAsientos.Fecha,conAsientos.Conasientos	



GO		

