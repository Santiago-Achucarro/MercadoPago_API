DROP PROCEDURE genFavoritosUsuariosGuardar
GO
CREATE PROCEDURE genFavoritosUsuariosGuardar
(
@pUsuario_Id int,
@pFormulario_id varchar(30)
)
AS
SET NOCOUNT ON 

IF (NOT EXISTS (SELECT 1 FROM genFavoritosUsuarios WHERE (Usuario_Id = @pUsuario_Id) AND (OrdenFormularioMenu = dbo.FuncFKgenMenusFormulario(@pFormulario_id))))
BEGIN 
	---Esta tabla no puede tener mas de 12 registros
	DELETE FROM genFavoritosUsuarios 
	WHERE 
	(Usuario_Id = @pUsuario_Id) AND
	OrdenFormularioMenu NOT IN (SELECT TOP 11 OrdenFormularioMenu FROM genFavoritosUsuarios 
		where 
			genFavoritosUsuarios.Usuario_Id = @pUsuario_Id 
	ORDER BY FechaRegistro DESC)

	
	INSERT INTO genFavoritosUsuarios
	(
		Usuario_Id,
		OrdenFormularioMenu,
		FechaRegistro
	)
	VALUES 
	(
		@pUsuario_Id,
		dbo.FuncFKgenMenusFormulario(@pFormulario_id),
		GETDATE()
	)
END 

GO

DROP PROCEDURE genFavoritosUsuariosDatos
GO
CREATE PROCEDURE genFavoritosUsuariosDatos
(
@pUsuario_Id int
)
AS
SET NOCOUNT ON 
Select '' as Formulario_Id

SELECT 	disFormularios.Formulario_Id, disFormularios.Titulo, mn2.Opcion as Modulo, mn1.Orden
FROM genFavoritosUsuarios 
INNER JOIN genMenus mn1 ON (mn1.Orden = genFavoritosUsuarios.OrdenFormularioMenu)
INNER JOIN disFormularios  ON (mn1.Formulario_Id = disFormularios.disFormularios)
INNER JOIN genMenus mn2 on SUBSTRING(mn2.Orden, 1, 1) = SUBSTRING(mn1.Orden, 1, 1) And mn2.Nivel = 1
WHERE (genFavoritosUsuarios.Usuario_Id = @pUsuario_Id)
--ORDER BY genFavoritosUsuarios.FechaRegistro DESC 
ORDER BY mn1.orden 
 RETURN @@Error 

GO

DROP PROCEDURE genFavoritosUsuariosEliminar
GO
CREATE PROCEDURE genFavoritosUsuariosEliminar
(
@pUsuario_Id int,
@pFormulario_id varchar(30)
)
AS
SET NOCOUNT ON 

DELETE FROM genFavoritosUsuarios 
WHERE (Usuario_Id = @pUsuario_Id)
AND (OrdenFormularioMenu = dbo.FuncFKgenMenusFormulario(@pFormulario_id))
 
 RETURN @@Error 

GO
