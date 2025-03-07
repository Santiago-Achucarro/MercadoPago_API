DROP PROCEDURE genPermisosEspGuardar
GO
CREATE PROCEDURE genPermisosEspGuardar
(
@pPermiso_Id int,
@pDescripcion varchar(100)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genPermisosEsp WHERE (Permiso_Id = @pPermiso_Id)))
BEGIN 
	UPDATE genPermisosEsp
	SET		Descripcion = @pDescripcion
	WHERE (Permiso_Id = @pPermiso_Id)
END 
ELSE 
BEGIN 
	INSERT INTO genPermisosEsp
	(
		Permiso_Id,
		Descripcion
	)
	VALUES 
	(
		@pPermiso_Id,
		@pDescripcion
	)
END 

GO

DROP PROCEDURE genPermisosEspDatos
GO
CREATE PROCEDURE genPermisosEspDatos
(
@pPermiso_Id int
)
AS
SET NOCOUNT ON 

SELECT genPermisosEsp.Permiso_Id, genPermisosEsp.Descripcion
FROM genPermisosEsp 
WHERE (Permiso_Id = @pPermiso_Id)
 
 RETURN @@Error 

GO

DROP PROCEDURE genPermisosEspEliminar
GO
CREATE PROCEDURE genPermisosEspEliminar
(
@pPermiso_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM genPermisosEsp 
WHERE (Permiso_Id = ISNULL(@pPermiso_Id, Permiso_Id))
 
 RETURN @@Error 

GO

