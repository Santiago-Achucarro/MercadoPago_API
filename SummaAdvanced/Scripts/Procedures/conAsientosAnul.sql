DROP PROCEDURE conAsientosAnulGuardar
GO
CREATE PROCEDURE conAsientosAnulGuardar
(
@pAsiento_Id bigint,
@pUsuario_Id int,
@pTipoEnvio char(1), 
@pCausa VarChar(Max) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM conAsientosAnul WHERE (Asiento_Id = @pAsiento_Id)))
BEGIN 
	UPDATE conAsientosAnul
	SET		FechaAnulacion = dbo.FechaActual(),
		Usuario_Id = @pUsuario_Id,
		TipoEnvio = @pTipoEnvio, 
		Causa = @pCausa
	WHERE (Asiento_Id = @pAsiento_Id)
END 
ELSE 
BEGIN 
	INSERT INTO conAsientosAnul
	(
		Asiento_Id,
		FechaAnulacion,
		Usuario_Id,
		TipoEnvio, 
		Causa
	)
	VALUES 
	(
		@pAsiento_Id,
		dbo.FechaActual(),
		@pUsuario_Id,
		@pTipoEnvio, 
		@pCausa
	)
END 

GO

DROP PROCEDURE conAsientosAnulDatos
GO
CREATE PROCEDURE conAsientosAnulDatos
(
@pAsiento_Id bigint
)
AS
SET NOCOUNT ON 

SELECT conAsientos.conAsientos, 
	conAsientosAnul.FechaAnulacion, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	conAsientosAnul.TipoEnvio, conAsientosAnul.Causa
FROM conAsientosAnul 
INNER JOIN conAsientos  ON (conAsientos.conAsientos = conAsientosAnul.Asiento_Id)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = conAsientosAnul.Usuario_Id)
WHERE (Asiento_Id = @pAsiento_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE conAsientosAnulEliminar
GO
CREATE PROCEDURE conAsientosAnulEliminar
(
@pAsiento_Id bigint
)
AS
SET NOCOUNT ON 

DELETE FROM conAsientosAnul 
WHERE (Asiento_Id = @pAsiento_Id)
 
 RETURN @@Error 

GO

GO
