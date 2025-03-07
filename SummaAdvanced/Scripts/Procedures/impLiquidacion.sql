

DROP PROCEDURE impLiquidacionGuardar
GO
CREATE PROCEDURE impLiquidacionGuardar
(
@pconAsientos bigint,
@pImpuesto_Id varchar(5),
@pFechaPago datetime,
@pFechaDesde datetime,
@pFechaHasta datetime,
@pTotalaPagar qMonedaD2,
@pSePaga bit,
@ptesMovimientos bigint = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM impLiquidacion WHERE (conAsientos = @pconAsientos)))
BEGIN 
	UPDATE impLiquidacion
	SET		Impuesto_Id = dbo.FuncFKimpImpuestos( @pImpuesto_Id),
		FechaPago = @pFechaPago,
		FechaDesde = @pFechaDesde,
		FechaHasta = @pFechaHasta,
		TotalaPagar = @pTotalaPagar,
		Saldo = @pTotalaPagar,
		SePaga = @pSePaga,
		tesMovimientos = @ptesMovimientos
	WHERE (conAsientos = @pconAsientos)
END 
ELSE 
BEGIN 
	INSERT INTO impLiquidacion
	(
		conAsientos,
		Impuesto_Id,
		FechaPago,
		FechaDesde,
		FechaHasta,
		TotalaPagar,
		Saldo,
		SePaga,
		tesMovimientos
	)
	VALUES 
	(
		@pconAsientos,
		dbo.FuncFKimpImpuestos( @pImpuesto_Id),
		@pFechaPago,
		@pFechaDesde,
		@pFechaHasta,
		@pTotalaPagar,
		@pTotalaPagar,
		@pSePaga,
		@ptesMovimientos
	)
END 

GO

DROP PROCEDURE impLiquidacionDatos
GO
CREATE PROCEDURE impLiquidacionDatos
(

@pSegmento_Id varchar(10),
@pSegmento1N int,
@pSegmento2N int,
@pSegmento3N int,
@pSegmento4N int,
@pSegmento1C varchar(20),
@pSegmento2C varchar(20),
@pSegmento3C varchar(20),
@pSegmento4C varchar(20),
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 
declare @pconAsientos int
set @pconAsientos=(select Asiento_Id from genAsiSegmentos where
Segmento_Id=dbo.FuncFKgenSegmentos(@pSegmento_Id) and
Segmento1N=@pSegmento1N and Segmento2N=@pSegmento2N AND
Segmento3N=@pSegmento3N and Segmento4N=@pSegmento4N and
Segmento1C=@pSegmento1C and Segmento2C=@pSegmento2C and 
Segmento4C=@pSegmento3C and Segmento4C=@pSegmento4C and
Empresa_Id=@pEmpresa_Id
)
SELECT conAsientos.conAsientos,conAsientos.Fecha,conAsientos.Anulado,conAsientos.Posteado, genSegmentos.Segmento_Id,genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,genAsiSegmentos.Segmento3N,
genAsiSegmentos.Segmento4N,genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,genAsiSegmentos.Segmento3C ,genAsiSegmentos.Segmento4C,
impImpuestos.Impuesto_Id,impImpuestos.Descripcion as DescripcionImpuesto, impLiquidacion.FechaPago, impLiquidacion.FechaDesde,
impLiquidacion.FechaHasta, impLiquidacion.TotalaPagar, impLiquidacion.SePaga, impLiquidacion.tesMovimientos
FROM impLiquidacion inner join impImpuestos on impImpuestos.impImpuestos=impLiquidacion.Impuesto_Id 
inner join genAsiSegmentos on  genAsiSegmentos.Asiento_Id = impLiquidacion.conAsientos 
inner join conAsientos on conAsientos.conAsientos=impLiquidacion.conAsientos
inner join genSegmentos on genSegmentos.genSegmentos=genAsiSegmentos.Segmento_Id

WHERE (conAsientos.conAsientos = @pconAsientos)
 
 SELECT   conMovCont.Renglon, conCuentas.Cuenta_Id,conCuentas.Descripcion,conMovCont.LeyendaLibroMayor as Detalle,
 case when conMovCont.TipoMov =1 then conMovCont.Importe else 0 end as Debe,
 case when conMovCont.TipoMov =2 then conMovCont.Importe else 0 end as Haber
   FROM conMovCont 
 INNER JOIN conCuentas on conMovCont.Cuenta_Id=conCuentas.conCuentas WHERE (conAsientos = @pconAsientos) order by 1
 
 Exec genAtributosGeneralesIdentityDatos @pconAsientos, 'impLiquidacion'

 RETURN @@Error 

GO

DROP PROCEDURE impLiquidacionEliminar
GO
CREATE PROCEDURE impLiquidacionEliminar
(
@pconAsientos bigint = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM impLiquidacion 
WHERE (conAsientos = ISNULL(@pconAsientos, conAsientos))
 
 RETURN @@Error 

GO



DROP PROCEDURE impLiquidacionPagar
GO
CREATE PROCEDURE impLiquidacionPagar
(
@pconAsientos bigint,
@ptesMovimientos bigint = NULL
)
AS
	UPDATE impLiquidacion SET	 tesMovimientos = @ptesMovimientos
		WHERE (conAsientos = @pconAsientos)

GO




DROP PROCEDURE impLiquidacionFechaDatos
GO
CREATE PROCEDURE impLiquidacionFechaDatos
(

@pFechaDesde DateTime, 
@pImpuesto_Id VarChar(5),
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

SELECT dbo.Segmento(genAsiSegmentos.Segmento_Id,
	genAsiSegmentos.Segmento1C,genAsiSegmentos.Segmento2C,
	genAsiSegmentos.Segmento3C ,genAsiSegmentos.Segmento4C,
	genAsiSegmentos.Segmento1N,genAsiSegmentos.Segmento2N,
	genAsiSegmentos.Segmento3N,genAsiSegmentos.Segmento4N) as Segmento,
impImpuestos.Impuesto_Id,impImpuestos.Descripcion as DescripcionImpuesto, 
impLiquidacion.FechaDesde, impLiquidacion.FechaHasta, impLiquidacion.TotalaPagar
FROM impLiquidacion inner join impImpuestos on impImpuestos.impImpuestos=impLiquidacion.Impuesto_Id 
inner join genAsiSegmentos on  genAsiSegmentos.Asiento_Id = impLiquidacion.conAsientos 
inner join conAsientos on conAsientos.conAsientos=impLiquidacion.conAsientos
WHERE 
	conAsientos.Anulado = 0 and 
	conAsientos.Posteado= 1 AND 
	conAsientos.Empresa_Id = @pEmpresa_Id and 
	impLiquidacion.FechaDesde= @pFechaDesde and 
	impImpuestos.Impuesto_Id = @pImpuesto_Id
 

GO
