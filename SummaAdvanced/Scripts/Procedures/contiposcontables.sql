DROP PROCEDURE conTiposContablesGuardar
GO
CREATE PROCEDURE conTiposContablesGuardar
(
@pTipo_Id varchar(5),
@pDescripcion varchar(45),
@pRubro_Balance varchar(15),
@pDestino char(10),
@pCorriente char(1),
@pReservado Sino,
@pRubro_Id char(1),
@pDescripcionUsu varchar(45)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM conTiposContables WHERE (Tipo_Id = @pTipo_Id)))
BEGIN 
	UPDATE conTiposContables
	SET		Descripcion = @pDescripcion,
		Rubro_Balance = @pRubro_Balance,
		Destino = @pDestino,
		Corriente = @pCorriente,
		Reservado = @pReservado,
		Rubro_Id = @pRubro_Id,
		DescripcionUsu = @pDescripcionUsu
	WHERE (Tipo_Id = @pTipo_Id)
END 
ELSE 
BEGIN 
	INSERT INTO conTiposContables
	(
		Tipo_Id,
		Descripcion,
		Rubro_Balance,
		Destino,
		Corriente,
		Reservado,
		Rubro_Id,
		DescripcionUsu
	)
	VALUES 
	(
		@pTipo_Id,
		@pDescripcion,
		@pRubro_Balance,
		@pDestino,
		@pCorriente,
		@pReservado,
		@pRubro_Id,
		@pDescripcionUsu
	)
END 

GO

DROP PROCEDURE conTiposContablesDatos
GO
CREATE PROCEDURE conTiposContablesDatos
(
@pTipo_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT conTiposContables.Tipo_Id, conTiposContables.Descripcion, conTiposContables.Rubro_Balance, conSituPatri.Descripcion as DescripcionSituPatri,
	conTiposContables.Destino, conTiposContables.Corriente, conTiposContables.Reservado, conTiposContables.Rubro_Id,
	conRubros.Descripcion as DescripcionRubros, conTiposContables.DescripcionUsu
FROM conTiposContables 
INNER JOIN conSituPatri  ON (conSituPatri.Rubro_Balance = conTiposContables.Rubro_Balance)
INNER JOIN conRubros  ON (conRubros.Rubro_Id = conTiposContables.Rubro_Id)
WHERE (Tipo_Id = @pTipo_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE conTiposContablesEliminar
GO
CREATE PROCEDURE conTiposContablesEliminar
(
@pTipo_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM conTiposContables 
WHERE (Tipo_Id = ISNULL(@pTipo_Id, Tipo_Id))
 
 RETURN @@Error 

GO

GO
