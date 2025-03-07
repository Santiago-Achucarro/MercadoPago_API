DROP PROCEDURE comNivelesAutoUsuGuardar
GO
CREATE PROCEDURE comNivelesAutoUsuGuardar
(
@pNivel_Id varChar(5),
@pUsuario_Id varChar(25)
)
AS
SET NOCOUNT ON 
	INSERT INTO comNivelesAutoUsu
	(
		NivelAuto_Id,
		Usuario_Id
	)
	VALUES 
	(
		dbo.FuncFKcomNivelesAuto(@pNivel_Id),
		dbo.FuncFKgenUsuarios(@pUsuario_Id)
	)

GO

DROP PROCEDURE comNivelesAutoUsuDatos
GO
CREATE PROCEDURE comNivelesAutoUsuDatos
(
@pNivel_Id varChar(5) = Null,
@pUsuario_Id varChar(25) = Null
)
AS
SET NOCOUNT ON 

SELECT genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, comNivelesAuto.NivelAuto_Id, 
comNivelesAuto.Descripcion as DescripcioncomNivelesAuto
FROM comNivelesAutoUsu 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = comNivelesAutoUsu.Usuario_Id)
INNER JOIN comNivelesAuto  ON (comNivelesAuto.ComNivelesAuto = comNivelesAutoUsu.NivelAuto_Id)
WHERE comNivelesAutoUsu.Usuario_Id = IsNull(dbo.FuncFKgenUsuarios(@pUsuario_Id), comNivelesAutoUsu.Usuario_Id)
AND comNivelesAutoUsu.NivelAuto_Id = IsNull(dbo.FuncFKcomNivelesAuto(@pNivel_Id), comNivelesAutoUsu.NivelAuto_Id)
 
RETURN @@Error 

GO

DROP PROCEDURE comNivelesAutoUsuEliminar
GO
CREATE PROCEDURE comNivelesAutoUsuEliminar
(
@pNivel_Id varChar(5) = Null,
@pUsuario_Id varChar(25) = Null
)
AS
SET NOCOUNT ON 

DELETE FROM comNivelesAutoUsu 
WHERE comNivelesAutoUsu.Usuario_Id = IsNull(dbo.FuncFKgenUsuarios(@pUsuario_Id), comNivelesAutoUsu.Usuario_Id)
AND comNivelesAutoUsu.NivelAuto_Id = IsNull(dbo.FuncFKcomNivelesAuto(@pNivel_Id), comNivelesAutoUsu.NivelAuto_Id)
 
RETURN @@Error 

GO

