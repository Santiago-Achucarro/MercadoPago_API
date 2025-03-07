
-- tesConciliacionDatos 1, '20210331','HS414', 1
DROP PROCEDURE tesConciliacionDatos
GO
CREATE PROCEDURE tesConciliacionDatos
(
	@Empresa_Id Int,
	@FechaHasta DateTime,
	@Cartera_Id VarChar(5),
	@NumeroConc Int
	
)
as
IF Exists(Select 1 from tesConciliacion INNER JOIN tesIdentifica ON 
		tesConciliacion.tesIdentifica = tesIdentifica.tesIdentifica
where
		tesIdentifica.Cartera_Id = @Cartera_Id and 
		tesConciliacion.NumeroConc = @NumeroConc and
		tesConciliacion.Empresa_Id = @Empresa_Id )


Begin

SELECT tesConciliacion.Empresa_Id, tesConciliacion.FechaConciliacion FechaHasta, tesIdentifica.Cartera_id ,
	tesIdentifica.Descripcion as Descripcion , tesConciliacion.NumeroConc, 
		' ' ArchivoXls
From tesConciliacion INNER JOIN tesIdentifica ON 
		tesConciliacion.tesIdentifica = tesIdentifica.tesIdentifica
		Where
		tesIdentifica.Cartera_Id = @Cartera_Id and 
		tesConciliacion.NumeroConc = @NumeroConc and 
		tesConciliacion.Empresa_Id = @Empresa_Id 
end

ELSE
begin

	SELECT @Empresa_Id Empresa_Id, @FechaHasta FechaHasta, tesIdentifica.Cartera_id ,
		tesIdentifica.Descripcion as Descripcion , @NumeroConc NumeroConc,
		' ' ArchivoXls
	From tesIdentifica 
		Where
		tesIdentifica.Cartera_Id = @Cartera_Id 
		

END
		


SELECT 
	dbo.Segmento(genAsiSegmentos.Segmento_Id, 
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N) as Segmento_Str, 
	conAsientos.Fecha,
	tesMovimientos.tesMovimientos, tesRengMovi.conRenglon, 
	tesMovimientos.tesMovimientos*1000 + tesRengMovi.conRenglon as Renglon,
	tesSubTiposMov.SubTipo_Id, 
	tesSubTiposMov.Descripcion as DescripcionSubTipo, 
	case when conMovCont.TipoMov= 1 then 
	conMovCont.ImporteMonedaOriginal else 0 end Debe,
	case when conMovCont.TipoMov= 2 then 
	conMovCont.ImporteMonedaOriginal else 0 end Haber,
	conMovCont.ImporteMonedaOriginal * (-2*conMovCont.TipoMov+3) as Monto, 
	tesRengConciliac.Saldo * (-2*conMovCont.TipoMov+3) as Saldo, 
		tesCheqProp.Chequera_Id, tesCheqProp.numCheque, 
		tesCheqProp.FechaVencimiento, tesChequeras.TipoChequera, 
		conAsientos.Observaciones, tesCheqProp.aLaOrden, 
			cast(case when tesRengConcilEsp.NumeroConc is null then 0 else 1 end as bit) Marca, 
			cast( CASE WHEN (SELECT count(1) from tesCheqTerceros inner join tesCTlink ON
						tesCheqTerceros.tesCheqTerceros = tesCTlink.tesCheqTerceros and
						tesCTlink.tesMovimientos = tesMovimientos.tesMovimientos 
						LEFT JOIN tesIdentifica ON 
						tesIdentifica.tesIdentifica = tesCheqTerceros.BancoConc
						Where
						(ISNULL(tesIdentifica.Cartera_Id, ' ') !=   @Cartera_Id OR
					     ISNULL(tesCheqTerceros.NumeroConc, ' ') !=   @NumeroConc)) > 0  AND 
						 (SELECT count(1) from tesCheqTerceros inner join tesCTlink ON
						tesCheqTerceros.tesCheqTerceros = tesCTlink.tesCheqTerceros and
						tesCTlink.tesMovimientos = tesMovimientos.tesMovimientos 
						inner JOIN tesIdentifica ON 
						tesIdentifica.tesIdentifica = tesCheqTerceros.BancoConc
						Where
						tesIdentifica.Cartera_Id =   @Cartera_Id and 
						 tesCheqTerceros.Empresa_Id = @Empresa_Id and 
					     tesCheqTerceros.NumeroConc =   @NumeroConc )> 0 THEN 1 ELSE 0 END as bit) PorCheque , 
						 @Cartera_Id as Cartera_Id
						 
	From tesRengMovi 
	inner join tesMovimientos ON tesRengMovi.tesMovimientos = tesMovimientos.tesMovimientos
	inner join tesRengConciliac ON tesRengConciliac.tesMovimientos = tesRengMovi.tesMovimientos AND tesRengConciliac.conRenglon = tesRengMovi.conRenglon
	inner join conAsientos ON conAsientos.conAsientos = tesMovimientos.tesMovimientos
	INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
	INNER JOIN tesSubTiposMov ON tesSubTiposMov.tesSubTiposMov =tesMovimientos.SubTipo_Id
	INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos and conMovCont.Renglon = tesRengMovi.conRenglon
	INNER JOIN conCuentas on conMovCont.Cuenta_Id = conCuentas.conCuentas
	INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica = tesRengMovi.Cartera_Id
	LEFT JOIN (tesBPlink INNER JOIN tesCheqProp ON
		tesBPlink.tesCheqProp = tesCheqProp.tesCheqProp
		inner join tesChequeras ON
		tesChequeras.Cartera_Id = tesCheqProp.Cartera_Id and
		tesChequeras.Chequera_Id = tesCheqProp.Chequera_Id And tesChequeras.Empresa_Id = @Empresa_Id) ON
		tesBPlink.tesMovimientos = tesRengMovi.tesMovimientos AND 
		tesBPlink.conRenglon = tesRengMovi.conRenglon
	LEFT join tesRengConcilEsp ON
		tesRengConcilEsp.tesMovimientos = tesRengMovi.tesMovimientos and
		tesRengConcilEsp.conRenglon = tesRengMovi.conRenglon


Where

	conAsientos.Anulado = 0  and 
	conAsientos.Posteado = 1 and
	genAsiSegmentos.Empresa_Id = @Empresa_Id and 
	tesIdentifica.Cartera_Id = @Cartera_Id and 
	case when tesCheqProp.FechaVencimiento IS NULL THEN  conAsientos.Fecha  ELSE tesCheqProp.FechaVencimiento END <= @FechaHasta and
	(tesRengConcilEsp.NumeroConc IS NOT NULL OR tesRengConciliac.Saldo != 0 ) and
	ISNULL(tesRengConcilEsp.NumeroConc, @NumeroConc)  = @NumeroConc
	and conCuentas.conCuentas = tesIdentifica.Cuenta_Id
	order by 2,1
	
-- PARA DEPOSITOS TRAIGO LOS CHEQUES INCLUIDOS

SELECT tesRengMovi.tesMovimientos, tesRengMovi.conRenglon, 
	tesRengMovi1.tesMovimientos*1000+tesRengMovi1.conRenglon as Renglon, 
	tesCheqTerceros.tesCheqTerceros, 
		tesCheqTerceros.numCheque, tesCheqTerceros.FechaVencimiento,
		tesCheqTerceros.cuentaBanco, conMovCont.ImporteMonedaOriginal as Monto, 
		CASE WHEN tesCheqTerceros.NumeroConc IS NULL THEN conMovCont.ImporteMonedaOriginal ELSE	0 END AS Saldo, 
		venClientes.Cliente_Id, venClientes.RazonSocial,
		cast(case when tesCheqTerceros.NumeroConc is null then 0 else 1 end as bit) Marca
FROM tesCheqTerceros 
INNER JOIN tesCTlink ON tesCheqTerceros.tesCheqTerceros =tesCTlink.tesCheqTerceros
INNER JOIN tesRengMovi ON tesRengMovi.tesMovimientos = tesCTlink.tesMovimientos and 
	tesRengMovi.conRenglon = tesCTlink.conRenglon
INNER JOIN conMovCont ON conMovCont.conAsientos = tesRengMovi.tesMovimientos AND 
	conMovCont.Renglon = tesRengMovi.conRenglon
INNER JOIN conCuentas on conMovCont.Cuenta_Id = conCuentas.conCuentas	
INNER JOIN conAsientos ON conAsientos.conAsientos = tesRengMovi.tesMovimientos
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
inner join tesMovimientos ON tesMovimientos.tesMovimientos = tesRengMovi.tesMovimientos
INNER JOIN tesSubTiposMov ON tesSubTiposMov.tesSubTiposMov = tesMovimientos.SubTipo_Id
INNER JOIN tesRengMovi as tesRengMovi1 ON tesRengMovi1.tesMovimientos = tesRengMovi.tesMovimientos And tesRengMovi1.TipomovCont = 1
INNER JOIN tesIdentifica ON tesIdentifica.tesIdentifica = tesRengMovi1.Cartera_Id 
LEFT JOIN tesRengConcilEsp ON tesRengConcilEsp.tesMovimientos = tesRengMovi1.tesMovimientos and
	tesRengConcilEsp.conRenglon = tesRengMovi1.conRenglon
LEFT JOIN venClientes ON venClientes.genEntidades = tesCheqTerceros.Cliente_Id
Where
		tesIdentifica.Cartera_Id = @Cartera_Id  AND 
		conAsientos.Anulado = 0  and 
		conAsientos.Posteado = 1 and
		genAsiSegmentos.Empresa_Id = @Empresa_Id And
		tesSubTiposMov.SubTipo_Id In ('DE3', 'AIB') and
		ISNULL(tesRengConcilEsp.NumeroConc, @NumeroConc) = @NumeroConc and 
		conAsientos.Fecha <= @FechaHasta -- AND conCuentas.Tipo_Id ='BANCO'

-- tABLA PARA LOS QUE NO ESTAN

Select cast(0 as bit) Marca ,
	conAsientos.Fecha , conAsientos.Fecha as FechaValor, Cast(0 as Int) as Cheque, 
	conAsientos.Cambio as Importe, ' ' as RefBanco, ' ' as Referencia
From conAsientos where 1 = 2

GO


				

DROP PROCEDURE tesConciliacionGuardar
GO
CREATE PROCEDURE tesConciliacionGuardar
(
@pEmpresa_Id int,
@pCartera_Id VarChar(5),
@pNumeroConc int,
@pFechaConciliacion qFecha,
@pExtractoCierre qMonedaD2,
@pExtractoApertura qMonedaD2,
@pContableApertura qMonedaD2,
@pContableCierre qMonedaD2,
@pPosteado Sino,
@pUsuario_Id int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM tesConciliacion WHERE (Empresa_Id = @pEmpresa_Id) AND (tesIdentifica = dbo.FuncFKtesIdentifica(@pCartera_Id)) AND (NumeroConc = @pNumeroConc)))
BEGIN 
	UPDATE tesConciliacion
	SET		Empresa_Id = @pEmpresa_Id,
		FechaConciliacion = @pFechaConciliacion,
		ExtractoCierre = @pExtractoCierre,
		ExtractoApertura = @pExtractoApertura,
		ContableApertura = @pContableApertura,
		ContableCierre = @pContableCierre,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id
	WHERE (Empresa_Id = @pEmpresa_Id) AND (tesIdentifica = dbo.FuncFKtesIdentifica(@pCartera_Id)) AND (NumeroConc = @pNumeroConc)
END 
ELSE 
BEGIN 

	SET @pNumeroConc = ISNULL((SELECT MAX(NumeroConc) from tesConciliacion where
		Empresa_Id = @pEmpresa_Id AND 
		tesIdentifica = dbo.FuncFKtesIdentifica(@pCartera_Id)),0)+1

	INSERT INTO tesConciliacion
	(
		Empresa_Id,
		tesIdentifica,
		NumeroConc,
		FechaConciliacion,
		ExtractoCierre,
		ExtractoApertura,
		ContableApertura,
		ContableCierre,
		Posteado,
		Usuario_Id
	)
	VALUES 
	(
		@pEmpresa_Id,
		dbo.FuncFKtesIdentifica(@pCartera_Id),
		@pNumeroConc,
		@pFechaConciliacion,
		@pExtractoCierre,
		@pExtractoApertura,
		@pContableApertura,
		@pContableCierre,
		@pPosteado,
		@pUsuario_Id
	)


END 
SELECT @pNumeroConc as NumeroConc

GO

DROP PROCEDURE tesConciliacionEliminar
GO
CREATE PROCEDURE tesConciliacionEliminar
(
@pEmpresa_Id int,
@pCartera_Id varchar(5),
@pNumeroConc int 
)
AS
SET NOCOUNT ON 

DELETE FROM tesConciliacion 
WHERE Empresa_Id = @pEmpresa_Id
AND tesIdentifica = dbo.FuncFKtesIdentifica(@pCartera_Id)
AND NumeroConc = @pNumeroConc
 
 RETURN @@Error 

GO
DROP PROCEDURE tesConciliacionDesmarcar
GO
CREATE PROCEDURE tesConciliacionDesmarcar(
@pEmpresa_Id int,
@pCartera_Id varchar(5),
@pNumeroConc int 
)

AS

Update tesRengConciliac SET Saldo = Saldo + tesRengConcilEsp.Importe
from tesRengConcilEsp
Where  tesRengConcilEsp.tesMovimientos = tesRengConciliac.tesMovimientos and 
	tesRengConcilEsp.conRenglon = tesRengConciliac.conRenglon and 
	tesRengConcilEsp.tesIdentifica = dbo.FuncFKtesIdentifica(@pCartera_Id) and 
	tesRengConcilEsp.Empresa_Id = @pEmpresa_Id and
	tesRengConcilEsp.NumeroConc = @pNumeroConc


Update tesCheqTerceros SET NumeroConc = null, BancoConc = null , Empresa_Id = null
Where
	tesCheqTerceros.BancoConc = dbo.FuncFKtesIdentifica(@pCartera_Id) and 
	tesCheqTerceros.NumeroConc = @pNumeroConc and 
	tesCheqTerceros.Empresa_Id = @pEmpresa_Id
	

delete from tesRengConcilEsp Where
	tesRengConcilEsp.tesIdentifica = dbo.FuncFKtesIdentifica(@pCartera_Id) and 
	tesRengConcilEsp.Empresa_Id = @pEmpresa_Id and
	tesRengConcilEsp.NumeroConc = @pNumeroConc

GO
