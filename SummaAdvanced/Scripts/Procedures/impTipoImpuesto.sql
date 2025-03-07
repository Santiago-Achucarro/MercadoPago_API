DROP PROCEDURE impTipoImpuestoGuardar
GO
CREATE PROCEDURE impTipoImpuestoGuardar
(
@pTipoImpuesto int,
@pDescripcion varchar(80),
@pCodigoFiscal varchar(3) = NULL,
@pJuris_Id varchar(3) = NULL,
@pReferencia01 varchar(15) = NULL,
@pReferencia02 varchar(15) = NULL,
@pReferencia03 varchar(15) = NULL,
@pReferencia04 varchar(15) = NULL,
@pReferencia05 varchar(15) = NULL,
@pReferencia06 varchar(15) = NULL,
@pReferencia07 varchar(15) = NULL,
@pReferencia08 varchar(15) = NULL,
@pReferencia09 varchar(15) = NULL,
@pReferencia10 varchar(15) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM impTipoImpuesto WHERE (TipoImpuesto = @pTipoImpuesto)))
BEGIN 
	UPDATE impTipoImpuesto
	SET		Descripcion = @pDescripcion,
		CodigoFiscal = @pCodigoFiscal,
		Juris_Id = dbo.FuncFKimpJurisdicciones(@pJuris_Id),
		Referencia01 = @pReferencia01,
		Referencia02 = @pReferencia02,
		Referencia03 = @pReferencia03,
		Referencia04 = @pReferencia04,
		Referencia05 = @pReferencia05,
		Referencia06 = @pReferencia06,
		Referencia07 = @pReferencia07,
		Referencia08 = @pReferencia08,
		Referencia09 = @pReferencia09,
		Referencia10 = @pReferencia10
	WHERE (TipoImpuesto = @pTipoImpuesto)
END 
ELSE 
BEGIN 
	INSERT INTO impTipoImpuesto
	(
		TipoImpuesto,
		Descripcion,
		CodigoFiscal,
		Juris_Id,
		Referencia01,
		Referencia02,
		Referencia03,
		Referencia04,
		Referencia05,
		Referencia06,
		Referencia07,
		Referencia08,
		Referencia09,
		Referencia10
	)
	VALUES 
	(
		@pTipoImpuesto,
		@pDescripcion,
		@pCodigoFiscal,
		dbo.FuncFKimpJurisdicciones(@pJuris_Id),
		@pReferencia01,
		@pReferencia02,
		@pReferencia03,
		@pReferencia04,
		@pReferencia05,
		@pReferencia06,
		@pReferencia07,
		@pReferencia08,
		@pReferencia09,
		@pReferencia10
	)
END 

GO

DROP PROCEDURE impTipoImpuestoDatos
GO
CREATE PROCEDURE impTipoImpuestoDatos
(
@pTipoImpuesto int
)
AS
SET NOCOUNT ON 

SELECT impTipoImpuesto.TipoImpuesto, impTipoImpuesto.Descripcion, impTipoImpuesto.CodigoFiscal, impJurisdicciones.Juris_Id,
	impJurisdicciones.Descripcion as DescripcionJurisdicciones, impTipoImpuesto.Referencia01, impTipoImpuesto.Referencia02, impTipoImpuesto.Referencia03,
	impTipoImpuesto.Referencia04, impTipoImpuesto.Referencia05, impTipoImpuesto.Referencia06, impTipoImpuesto.Referencia07,
	impTipoImpuesto.Referencia08, impTipoImpuesto.Referencia09, impTipoImpuesto.Referencia10
FROM impTipoImpuesto 
LEFT JOIN impJurisdicciones  ON (impJurisdicciones.impJurisdicciones = impTipoImpuesto.Juris_Id)
WHERE (TipoImpuesto = @pTipoImpuesto)
 
 RETURN @@Error 

GO

DROP PROCEDURE impTipoImpuestoEliminar
GO
CREATE PROCEDURE impTipoImpuestoEliminar
(
@pTipoImpuesto int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM impTipoImpuesto 
WHERE (TipoImpuesto = ISNULL(@pTipoImpuesto, TipoImpuesto))
 
 RETURN @@Error 

GO

GO
