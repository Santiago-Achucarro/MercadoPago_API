DROP PROCEDURE sueTablaGuardar
GO
CREATE PROCEDURE sueTablaGuardar
(
@pTabla_Id int,
@pFila qMonedaD2,
@pValor qMonedaD2,
@pVer int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM sueTabla WHERE (Tabla_Id = @pTabla_Id and Fila = @pFila)))
BEGIN 
	UPDATE sueTabla
	SET	Valor = @pValor, Ver=@pVer
	WHERE (Tabla_Id = @pTabla_Id and Fila = @pFila)
END 
ELSE 
BEGIN 
	INSERT INTO sueTabla
	(
		Tabla_Id,
		Fila,
		Valor,
		Ver
	)
	VALUES 
	(
		@pTabla_Id,
		@pFila,
		@pValor,
		@pVer
	)
END 

GO


DROP PROCEDURE sueTablaEliminar
GO
CREATE PROCEDURE sueTablaEliminar
(
@pTabla_Id int
)
AS
SET NOCOUNT ON 

DELETE FROM sueTabla 
WHERE (Tabla_Id = @pTabla_Id)
 
 RETURN @@Error 

GO

GO
