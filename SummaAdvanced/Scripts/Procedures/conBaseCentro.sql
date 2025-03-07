DROP PROCEDURE conBaseCentroGuardar
GO
CREATE PROCEDURE conBaseCentroGuardar
(
@pBase_Id int,
@pCentro1_Id int,
@pValor QCantidad
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM conBaseCentro WHERE (Base_Id = @pBase_Id) AND (Centro1_Id = @pCentro1_Id)))
BEGIN 
	UPDATE conBaseCentro
	SET		Valor = @pValor
	WHERE (Base_Id = @pBase_Id) AND (Centro1_Id = @pCentro1_Id)
END 
ELSE 
BEGIN 
	INSERT INTO conBaseCentro
	(
		Base_Id,
		Centro1_Id,
		Valor
	)
	VALUES 
	(
		@pBase_Id,
		@pCentro1_Id,
		@pValor
	)
END 

GO

DROP PROCEDURE conBaseCentroEliminar
GO
CREATE PROCEDURE conBaseCentroEliminar
(
@pBase_Id int,
@pCentro1_Id int = Null
)
AS
SET NOCOUNT ON 

DELETE FROM conBaseCentro 
WHERE (Base_Id = @pBase_Id)
AND (Centro1_Id = IsNull(@pCentro1_Id, Centro1_Id))
 
 RETURN @@Error 

GO
