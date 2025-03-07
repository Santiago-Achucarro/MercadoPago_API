DROP PROCEDURE sueImpNombreGuardar
GO
CREATE PROCEDURE sueImpNombreGuardar
(
@pImporte_Id int,
@pDescripcion varchar(60),
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM sueImpNombre WHERE (Importe_Id = @pImporte_Id)))
BEGIN 
	UPDATE sueImpNombre
	SET		Descripcion = @pDescripcion,
		Usuario_Id = @pUsuario_Id
	WHERE (Importe_Id = @pImporte_Id)
END 
ELSE 
BEGIN 
	INSERT INTO sueImpNombre
	(
		Importe_Id,
		Descripcion,
		Usuario_Id
	)
	VALUES 
	(
		@pImporte_Id,
		@pDescripcion,
		@pUsuario_Id
	)
END 

GO

DROP PROCEDURE sueImpNombreDatos
GO
CREATE PROCEDURE sueImpNombreDatos
(
@pImporte_Id int
)
AS
SET NOCOUNT ON 

SELECT sueImpNombre.Importe_Id, sueImpNombre.Descripcion, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM sueImpNombre 
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = sueImpNombre.Usuario_Id)
WHERE (Importe_Id = @pImporte_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE sueImpNombreEliminar
GO
CREATE PROCEDURE sueImpNombreEliminar
(
@pImporte_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM sueImpNombre 
WHERE (Importe_Id = ISNULL(@pImporte_Id, Importe_Id))
 
 RETURN @@Error 

GO

GO
