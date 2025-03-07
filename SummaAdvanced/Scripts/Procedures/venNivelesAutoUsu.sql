DROP PROCEDURE venNivelesAutoUsuGuardar
GO
CREATE PROCEDURE venNivelesAutoUsuGuardar
(
@pNivelAuto_Id varChar(5),
@pUsuario_Id varChar(25)
)
AS
SET NOCOUNT ON 
	INSERT INTO venNivelesAutoUsu
	(
		NivelAuto_Id,
		Usuario_Id
	)
	VALUES 
	(
		dbo.FuncFKvenNivelesAuto(@pNivelAuto_Id),
		dbo.FuncFKgenUsuarios(@pUsuario_Id)
	)

GO

DROP PROCEDURE venNivelesAutoUsuDatos
GO
CREATE PROCEDURE venNivelesAutoUsuDatos
(
@pNivelAuto_Id varChar(5) = Null,
@pUsuario_Id varChar(25) = Null
)
AS
SET NOCOUNT ON 

SELECT genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, venNivelesAuto.NivelAuto_Id, 
venNivelesAuto.Descripcion as DescripcioncomNivelesAuto
FROM venNivelesAutoUsu 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = venNivelesAutoUsu.Usuario_Id)
INNER JOIN venNivelesAuto  ON (venNivelesAuto.venNivelesAuto = venNivelesAutoUsu.NivelAuto_Id)
WHERE venNivelesAutoUsu.Usuario_Id = IsNull(dbo.FuncFKgenUsuarios(@pUsuario_Id), venNivelesAutoUsu.Usuario_Id)
AND venNivelesAutoUsu.NivelAuto_Id = IsNull(dbo.FuncFKvenNivelesAuto(@pNivelAuto_Id), venNivelesAutoUsu.NivelAuto_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE venNivelesAutoUsuEliminar
GO
CREATE PROCEDURE venNivelesAutoUsuEliminar
(
@pNivelAuto_Id varChar(5) = Null,
@pUsuario_Id varChar(25) = Null
)
AS
SET NOCOUNT ON 

DELETE FROM venNivelesAutoUsu 
WHERE venNivelesAutoUsu.Usuario_Id = IsNull(dbo.FuncFKgenUsuarios(@pUsuario_Id), venNivelesAutoUsu.Usuario_Id)
AND venNivelesAutoUsu.NivelAuto_Id = IsNull(dbo.FuncFKvenNivelesAuto(@pNivelAuto_Id), venNivelesAutoUsu.NivelAuto_Id)
 
RETURN @@Error 

GO

