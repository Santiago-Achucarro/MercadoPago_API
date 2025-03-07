DROP PROCEDURE conTipoEspecialesGuardar
GO
CREATE PROCEDURE conTipoEspecialesGuardar
(
@pTipoEspe_Id varchar(5),
@pDescripcion varchar(35)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM conTipoEspeciales WHERE (TipoEspe_Id = @pTipoEspe_Id)))
BEGIN 
	UPDATE conTipoEspeciales
	SET		Descripcion = @pDescripcion
	WHERE (TipoEspe_Id = @pTipoEspe_Id)
END 
ELSE 
BEGIN 
	INSERT INTO conTipoEspeciales
	(
		TipoEspe_Id,
		Descripcion
	)
	VALUES 
	(
		@pTipoEspe_Id,
		@pDescripcion
	)
END 

GO

DROP PROCEDURE conTipoEspecialesDatos
GO
CREATE PROCEDURE conTipoEspecialesDatos
(
@pTipoEspe_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT conTipoEspeciales.TipoEspe_Id, conTipoEspeciales.Descripcion
FROM conTipoEspeciales 
WHERE (TipoEspe_Id = @pTipoEspe_Id)

SELECT conTipoEspecialesCuerpo.TipoEspe_Id, conTipoEspeciales.Descripcion as DescripcionTipoEspeciales, 
	conTipoEspecialesCuerpo.Tipo_Id, conTiposContables.Descripcion as DescripcionTiposContables
FROM conTipoEspecialesCuerpo 
INNER JOIN conTipoEspeciales ON (conTipoEspeciales.TipoEspe_Id = conTipoEspecialesCuerpo.TipoEspe_Id)
INNER JOIN conTiposContables ON (conTiposContables.Tipo_Id = conTipoEspecialesCuerpo.Tipo_Id)
WHERE conTipoEspecialesCuerpo.TipoEspe_Id = @pTipoEspe_Id

 
 RETURN @@Error 

GO

DROP PROCEDURE conTipoEspecialesEliminar
GO
CREATE PROCEDURE conTipoEspecialesEliminar
(
@pTipoEspe_Id varchar(5)
)
AS
SET NOCOUNT ON 

DELETE FROM conTipoEspeciales 
WHERE TipoEspe_Id = @pTipoEspe_Id
 
 RETURN @@Error 

GO

GO
