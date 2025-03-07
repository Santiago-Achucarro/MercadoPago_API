Drop Procedure genModuloOrigenGuardar
GO
Create Procedure genModuloOrigenGuardar
(
@pModuloOrigen_Id int, 
@pModuloOrigen_Id_Nuevo int, 
@pDescripcion varchar(30) 
) 
AS 
SET NOCOUNT ON  
IF (EXISTS (SELECT 1 FROM genModuloOrigen WHERE 
	ModuloOrigen_Id = @pModuloOrigen_Id
))
BEGIN 
	UPDATE genModuloOrigen SET 
	Descripcion = @pDescripcion 
	WHERE 
	ModuloOrigen_Id = @pModuloOrigen_Id
 
END 
ELSE
BEGIN
	INSERT INTO  genModuloOrigen
	(ModuloOrigen_Id , 
	Descripcion ) 
	Values 
	(@pModuloOrigen_Id , 
	@pDescripcion ) 
END
RETURN @@Error 

GO
Drop Procedure genModuloOrigenDatos
GO
CREATE PROCEDURE genModuloOrigenDatos(
@pModuloOrigen_Id int
)
AS
SELECT genModuloOrigen.ModuloOrigen_Id, genModuloOrigen.Descripcion
 FROM genModuloOrigen 
 Where 
	genModuloOrigen.ModuloOrigen_Id = @pModuloOrigen_Id

GO
Drop Procedure genModuloOrigenEliminar
GO
Create Procedure genModuloOrigenEliminar(
@pModuloOrigen_Id int
 
) 
AS 
SET NOCOUNT ON  
DELETE FROM genModuloOrigen 
	 Where 
	genModuloOrigen.ModuloOrigen_Id = @pModuloOrigen_Id
 
 RETURN @@Error 

GO

GO
