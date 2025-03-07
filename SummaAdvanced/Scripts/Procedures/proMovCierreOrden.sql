DROP PROCEDURE proMovCierreOrdenGuardar
GO
CREATE PROCEDURE proMovCierreOrdenGuardar
(
@pproMovCierreOrden bigint,
@pproOrden int = NULL,
@pCantidad qCantidadD8,
@pParcial Sino,
@pCausa_Id VarChar(5)=  NULL,
@pTurno_Id VARCHAR(10)= NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM proMovCierreOrden WHERE (proMovCierreOrden = @pproMovCierreOrden)))
BEGIN 
	UPDATE proMovCierreOrden
	SET	proOrden = @pproOrden,
		Cantidad = @pCantidad,
		Parcial = @pParcial,
		Causa_Id = dbo.FuncFKproCausas(@pCausa_Id),
		Turno_Id = dbo.FuncFKproTurnos(@pTurno_Id)
	WHERE (proMovCierreOrden = @pproMovCierreOrden)
END 
ELSE 
BEGIN 
	INSERT INTO proMovCierreOrden
	(
		proMovCierreOrden,
		proOrden,
		Cantidad,
		Parcial,
		Causa_Id,
		Turno_Id
	)
	VALUES 
	(
		@pproMovCierreOrden,
		@pproOrden,
		@pCantidad,
		@pParcial,
		dbo.FuncFKproCausas(@pCausa_Id),
		dbo.FuncFKproTurnos(@pTurno_Id)
	)
END 

GO

DROP PROCEDURE proMovCierreOrdenDatos
GO
CREATE PROCEDURE proMovCierreOrdenDatos
(
@pproMovCierreOrden bigint
)
AS
SET NOCOUNT ON 

SELECT genAsiSegmentos.Segmento_Id, genAsiSegmentos.Segmento1N, genAsiSegmentos.Segmento2N, 
	genAsiSegmentos.Segmento3N, genAsiSegmentos.Segmento4N, genAsiSegmentos.Segmento1C,
	genAsiSegmentos.Segmento2C, genAsiSegmentos.Segmento3C, genAsiSegmentos.Segmento4C,
	proMovCierreOrden.proMovCierreOrden, proMovCierreOrden.proOrden,
	proMovCierreOrden.Cantidad, proMovCierreOrden.Parcial,
	proCausas.Causa_Id, proCausas.Descripcion as DescripcionCausas,
	proTurnos.Turno_Id, proTurnos.Descripcion as DescripcionTurnos
FROM proMovCierreOrden 
INNER JOIN conAsientos  ON (conAsientos.conAsientos = proMovCierreOrden.proMovCierreOrden)
INNER JOIN genAsiSegmentos ON genAsiSegmentos.Asiento_Id = conAsientos.conAsientos
LEFT JOIN proOrden  ON (proOrden.proOrden = proMovCierreOrden.proOrden)
LEFT JOIN proCausas  ON (proCausas.proCausas = proMovCierreOrden.Causa_Id)
LEFT JOIN ProTurnos ON proTurnos.proTurnos = proMovCierreOrden.Turno_Id
WHERE (proMovCierreOrden = @pproMovCierreOrden)
 
 RETURN @@Error 

GO

DROP PROCEDURE proMovCierreOrdenEliminar
GO
CREATE PROCEDURE proMovCierreOrdenEliminar
(
@pproMovCierreOrden bigint
)
AS
SET NOCOUNT ON 

DELETE FROM proMovCierreOrden 
WHERE (proMovCierreOrden = @pproMovCierreOrden)
 
RETURN @@Error 

GO


