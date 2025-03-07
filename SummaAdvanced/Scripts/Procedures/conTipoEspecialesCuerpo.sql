DROP PROCEDURE conTipoEspecialesCuerpoGuardar
GO
CREATE PROCEDURE conTipoEspecialesCuerpoGuardar
(
@pTipoEspe_Id varchar(5),
@pTipo_Id varchar(5)
)
AS
SET NOCOUNT ON 
	INSERT INTO conTipoEspecialesCuerpo
	(
		TipoEspe_Id,
		Tipo_Id
	)
	VALUES 
	(
		@pTipoEspe_Id,
		@pTipo_Id
	)
GO

DROP PROCEDURE conTipoEspecialesCuerpoEliminar
GO
CREATE PROCEDURE conTipoEspecialesCuerpoEliminar
(
@pTipoEspe_Id varchar(5),
@pTipo_Id varchar(5) = Null
)
AS
SET NOCOUNT ON 

DELETE FROM conTipoEspecialesCuerpo 
WHERE TipoEspe_Id = @pTipoEspe_Id
AND Tipo_Id = IsNull(@pTipo_Id, Tipo_Id)
 
 RETURN @@Error 

GO

GO
DROP PROCEDURE conTipoEspecialesCuerpoDatos
GO
CREATE PROCEDURE conTipoEspecialesCuerpoDatos
(
@pTipoEspe_Id varchar(5),
@pTipo_Id varchar(5) = Null
)
AS
SET NOCOUNT ON 

SELECT Tipo_Id, TipoEspe_Id FROM conTipoEspecialesCuerpo 
WHERE TipoEspe_Id = @pTipoEspe_Id
	AND Tipo_Id = IsNull(@pTipo_Id, Tipo_Id)
 
 RETURN @@Error 

GO


