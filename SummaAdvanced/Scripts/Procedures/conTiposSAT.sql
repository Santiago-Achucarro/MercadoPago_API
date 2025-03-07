DROP PROCEDURE conTiposSATGuardar
GO
CREATE PROCEDURE conTiposSATGuardar
(
@pTipoSAT_Id varchar(25),
@pDescripcion varchar(200),
@pRubro char(3),
@pCirculante Sino,
@pImputable Sino
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM conTiposSAT WHERE (TipoSAT_Id = @pTipoSAT_Id)))
BEGIN 
	UPDATE conTiposSAT
	SET		Descripcion = @pDescripcion,
		Rubro = @pRubro,
		Circulante = @pCirculante,
		Imputable = @pImputable
	WHERE (TipoSAT_Id = @pTipoSAT_Id)
END 
ELSE 
BEGIN 
	INSERT INTO conTiposSAT
	(
		TipoSAT_Id,
		Descripcion,
		Rubro,
		Circulante,
		Imputable
	)
	VALUES 
	(
		@pTipoSAT_Id,
		@pDescripcion,
		@pRubro,
		@pCirculante,
		@pImputable
	)
END 

GO

DROP PROCEDURE conTiposSATDatos
GO
CREATE PROCEDURE conTiposSATDatos
(
@pTipoSAT_Id varchar(25)
)
AS
SET NOCOUNT ON 

SELECT conTiposSAT.TipoSAT_Id, conTiposSAT.Descripcion, conTiposSAT.Rubro, conTiposSAT.Circulante,
	conTiposSAT.Imputable
FROM conTiposSAT 
WHERE (TipoSAT_Id = @pTipoSAT_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE conTiposSATEliminar
GO
CREATE PROCEDURE conTiposSATEliminar
(
@pTipoSAT_Id varchar(25) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM conTiposSAT 
WHERE (TipoSAT_Id = ISNULL(@pTipoSAT_Id, TipoSAT_Id))
 
 RETURN @@Error 

GO

GO
