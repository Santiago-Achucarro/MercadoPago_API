-- AfiBajasDatos '',1, 'ABAJ', ' ',' ',' ',' ',1,0,0,0

DROP PROCEDURE AfiBajasDatos
GO

CREATE PROCEDURE AfiBajasDatos(
	@pActivoFijo_Id VarChar(15),
	@pEmpresa_Id Int, 
	@pSegmento_Id VarChar(10),
	@pSegmento1C Varchar(25),
	@pSegmento2C Varchar(25),
	@pSegmento3C Varchar(25),
	@pSegmento4C Varchar(25),
	@pSegmento1N Int,
	@pSegmento2N Int,
	@pSegmento3N Int,
	@pSegmento4N Int
)
as
begin

DECLARE @pActivoFijo1_Id VarChar(15)

SET @pActivoFijo1_Id =
	(SELECT max(afiActivoFijo.ActivoFijo_Id)
	 FROM genAsiSegmentos INNER JOIN AfiBajas ON
		genAsiSegmentos.Asiento_Id = AfiBajas.conAsientos
		inner join genSegmentos ON
		genAsiSegmentos.Segmento_Id =  genSegmentos.genSegmentos
		INNER JOIN AfiMovimientos ON
		AfiMovimientos.conAsientos = AfiBajas.conAsientos
		inner join afiActivoFijo on 
		afiActivoFijo.AfiActivoFijo = AfiMovimientos.AfiActivoFijo
		
	Where
		genSegmentos.Segmento_Id = @pSegmento_Id and 
		genAsiSegmentos.Segmento1C = @pSegmento1C and
		genAsiSegmentos.Segmento2C = @pSegmento2C and
		genAsiSegmentos.Segmento3C = @pSegmento3C and
		genAsiSegmentos.Segmento4C = @pSegmento4C and
		genAsiSegmentos.Segmento1N = @pSegmento1N and
		genAsiSegmentos.Segmento2N = @pSegmento2N and
		genAsiSegmentos.Segmento3N = @pSegmento3N and
		genAsiSegmentos.Segmento4N = @pSegmento4N )

-- Existe
if @pActivoFijo1_Id IS NOT NULL
	SET @pActivoFijo_Id = @pActivoFijo1_Id


Exec afiActivoFijoDatos @pActivoFijo_Id, @pEmpresa_Id

SELECT AfiBajas.conAsientos, genSegmentos.Segmento_Id, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, genAsiSegmentos.Segmento3N, 
	genAsiSegmentos.Segmento4N ,	AfiBajas.Causa, AfiBajas.Cantidad, 
	AfiBajas.Monto, AfiBajas.MontoFiscal, AfiBajas.MontoDepreciacion
	 FROM genAsiSegmentos INNER JOIN AfiBajas ON
		genAsiSegmentos.Asiento_Id = AfiBajas.conAsientos
		inner join genSegmentos ON
		genAsiSegmentos.Segmento_Id =  genSegmentos.genSegmentos
	Where
		genSegmentos.Segmento_Id = @pSegmento_Id and 
		genAsiSegmentos.Segmento1C = @pSegmento1C and
		genAsiSegmentos.Segmento2C = @pSegmento2C and
		genAsiSegmentos.Segmento3C = @pSegmento3C and
		genAsiSegmentos.Segmento4C = @pSegmento4C and
		genAsiSegmentos.Segmento1N = @pSegmento1N and
		genAsiSegmentos.Segmento2N = @pSegmento2N and
		genAsiSegmentos.Segmento3N = @pSegmento3N and
		genAsiSegmentos.Segmento4N = @pSegmento4N 

SELECT conMovCont.Renglon, conCuentas.Cuenta_Id, conCuentas.Descripcion as  DescripcionCuenta,
	conMovCont.LeyendaLibroMayor, 
	conCentro1.Centro1_Id, conCentro1.Descripcion  as DescripcionCentro1,
	conCentro2.Centro2_Id , conCentro2.Descripcion as DescripcionCentro2,
	conMovCont.Importe, conMovCont.TipoMov
	 FROM genAsiSegmentos INNER JOIN AfiBajas ON
		genAsiSegmentos.Asiento_Id = AfiBajas.conAsientos
		inner join genSegmentos ON
		genAsiSegmentos.Segmento_Id =  genSegmentos.genSegmentos
		inner join  conMovCont on
		conMovCont.conAsientos = AfiBajas.conAsientos
		inner join conCuentas ON conMovCont.Cuenta_Id = conCuentas.conCuentas
		left join conCentro1 ON  conMovCont.Centro1_Id = conCentro1.conCentro1
		left join conCentro2 ON  conMovCont.Centro2_Id = conCentro2.conCentro2 
		Where
			conMovCont.Clase = 'CONTR' AND 
			genSegmentos.Segmento_Id = @pSegmento_Id and 
			genAsiSegmentos.Segmento1C = @pSegmento1C and
			genAsiSegmentos.Segmento2C = @pSegmento2C and
			genAsiSegmentos.Segmento3C = @pSegmento3C and
			genAsiSegmentos.Segmento4C = @pSegmento4C and
			genAsiSegmentos.Segmento1N = @pSegmento1N and
			genAsiSegmentos.Segmento2N = @pSegmento2N and
			genAsiSegmentos.Segmento3N = @pSegmento3N and
			genAsiSegmentos.Segmento4N = @pSegmento4N 
	

end

GO

DROP PROCEDURE AfiBajasGuardar
GO
CREATE PROCEDURE AfiBajasGuardar
(
@pconAsientos bigint,
@pCausa QMemo = NULL,
@pCantidad QCantidad,
@pMonto qMonedaD2,
@pMontoFiscal qMonedaD2,
@pMontoDepreciacion qMonedaD2
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM AfiBajas WHERE (conAsientos = @pconAsientos)))
BEGIN 
	UPDATE AfiBajas
	SET		Causa = @pCausa,
		Cantidad = @pCantidad,
		Monto = @pMonto,
		MontoFiscal = @pMontoFiscal,
		MontoDepreciacion = @pMontoDepreciacion
	WHERE (conAsientos = @pconAsientos)
END 
ELSE 
BEGIN 
	INSERT INTO AfiBajas
	(
		conAsientos,
		Causa,
		Cantidad,
		Monto,
		MontoFiscal,
		MontoDepreciacion
	)
	VALUES 
	(
		@pconAsientos,
		@pCausa,
		@pCantidad,
		@pMonto,
		@pMontoFiscal,
		@pMontoDepreciacion
	)
END 

GO

DROP PROCEDURE AfiBajasEliminar
GO
CREATE PROCEDURE AfiBajasEliminar
(
@pconAsientos bigint = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM AfiBajas 
WHERE (conAsientos = ISNULL(@pconAsientos, conAsientos))
 
RETURN @@Error 

GO
DROP Procedure AfiActivoFijoBaja
GO
CREATE Procedure AfiActivoFijoBaja(
	@pActivoFijo_Id VarChar(15),
	@pEmpresa_Id Int,
	@pCantidad             QCantidad ,
	@pMontoVO              qMonedaD2 ,
	@pMontoFiscal          qMonedaD2 ,
	@pMontoDepreciacion    qMonedaD2 , 
	@pFechaBaja			   DateTime = NULL
)
as

	Update afiActivoFijo SET Cantidad = Cantidad - @pCantidad, 
		ValorInicial = ValorInicial - @pMontoVO,
		ValorFiscal = ValorFiscal - @pMontoFiscal,
		AmortAcumulada = AmortAcumulada - @pMontoDepreciacion, 
		FechaBaja = @pFechaBaja
		Where
			ActivoFijo_Id = @pActivoFijo_Id and 
			Empresa_Id = @pEmpresa_Id
GO