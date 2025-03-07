-- SELECT * FROM vvenMovimientos where ventipomov = 'R' AND SALDO >0
-- venAplicacionCobranzaDatos 'FC',356,0,0,0,'R','0001',' ',' ',1
DROP PROCEDURE venAplicacionCobranzaDatos
GO
CREATE PROCEDURE venAplicacionCobranzaDatos
(
	@Segmento_Id VarChar(10),
	@Segmento1N INT,
	@Segmento2N INT,
	@Segmento3N INT,
	@Segmento4N INT,
	@Segmento1C VarChar(25),
	@Segmento2C VarChar(25),
	@Segmento3C VarChar(25),
	@Segmento4C VarChar(25),
	@Empresa_Id Int

)
AS
DECLARE @Cliente Int
Declare @Signo Int
Declare @Moneda Int

SELECT genSegmentos.Segmento_Id,   genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C,
genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
venTipomov.Signo, venMovimientos.venMovimientos, venMovimientos.Saldo
	FROM genAsiSegmentos 
		INNER JOIN genSegmentos ON genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
		INNER JOIN venMovimientos ON venMovimientos.venMovimientos = genAsiSegmentos.Asiento_Id
		INNER JOIN venTipomov ON venMovimientos.venTipomov =  venTipomov.venTipomov
	WHERE
		genSegmentos.Segmento_Id = @Segmento_Id and
		genAsiSegmentos.Segmento1N = @Segmento1N and 
		genAsiSegmentos.Segmento2N = @Segmento2N and 
		genAsiSegmentos.Segmento3N = @Segmento3N and 
		genAsiSegmentos.Segmento4N = @Segmento4N and 
		genAsiSegmentos.Segmento1C = @Segmento1C and 
		genAsiSegmentos.Segmento2C = @Segmento2C and 
		genAsiSegmentos.Segmento3C = @Segmento3C and 
		genAsiSegmentos.Segmento4C = @Segmento4C and 
		genAsiSegmentos.Empresa_Id = @Empresa_Id

SELECT @Cliente = venMovimientos.Cliente_Id , @Signo = venTipoMov.Signo, 
	@Moneda = conAsientos.Moneda_Id
	FROM genAsiSegmentos 
		INNER JOIN genSegmentos ON genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
		INNER JOIN venMovimientos ON venMovimientos.venMovimientos = genAsiSegmentos.Asiento_Id
		INNER JOIN venTipoMov ON  venTipoMov.venTipoMov = venMovimientos.venTipoMov
		INNER JOIN conAsientos ON conAsientos.conAsientos = venMovimientos.venMovimientos
	WHERE
		genSegmentos.Segmento_Id = @Segmento_Id and
		genAsiSegmentos.Segmento1N = @Segmento1N and 
		genAsiSegmentos.Segmento2N = @Segmento2N and 
		genAsiSegmentos.Segmento3N = @Segmento3N and 
		genAsiSegmentos.Segmento4N = @Segmento4N and 
		genAsiSegmentos.Segmento1C = @Segmento1C and 
		genAsiSegmentos.Segmento2C = @Segmento2C and 
		genAsiSegmentos.Segmento3C = @Segmento3C and 
		genAsiSegmentos.Segmento4C = @Segmento4C and 
		genAsiSegmentos.Empresa_Id = @Empresa_Id



SELECT genMovCuotas.FechaVencimiento, conAsientos.Fecha, 
genSegmentos.Segmento_Id,   genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C,
genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
dbo.Segmento(genAsiSegmentos.Segmento_Id,   genAsiSegmentos.Segmento1C,
genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C, 
genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) SegmentoStr, 
venMovimientos.venMovimientos,
genMovCuotas.CuotaNro, genMovCuotas.Importe, genMovCuotas.Saldo, genMovCuotas.Saldo*0 as Aplicar
	FROM genAsiSegmentos 
		INNER JOIN genSegmentos ON genAsiSegmentos.Segmento_Id = genSegmentos.genSegmentos
		INNER JOIN venMovimientos ON venMovimientos.venMovimientos = genAsiSegmentos.Asiento_Id
		INNER JOIN venTipoMov ON venTipoMov.venTipoMov = venMovimientos.venTipoMov
		INNER JOIN genMovCuotas ON genMovCuotas.Asiento_Id = venMovimientos.venMovimientos
		INNER JOIN conAsientos ON  conAsientos.conAsientos = venMovimientos.venMovimientos
	WHERE
		venTipoMov.Signo  = -@Signo and 
		venMovimientos.Cliente_Id = @Cliente and 
		conAsientos.Anulado= 0 AND 
		conAsientos.Posteado = 1 and 
		genAsiSegmentos.Empresa_Id = @Empresa_Id and 
		conAsientos.Moneda_Id = @Moneda AND 
		genMovCuotas.Saldo > 0 
		ORDER BY 1,2

GO
