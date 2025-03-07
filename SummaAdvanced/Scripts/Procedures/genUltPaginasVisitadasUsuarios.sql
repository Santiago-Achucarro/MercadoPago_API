DROP PROCEDURE genUltPaginasVisitadasUsuariosGuardar
GO
CREATE PROCEDURE genUltPaginasVisitadasUsuariosGuardar
(
@pUsuario_Id int,
@pFormulario_id varchar(30)
)
AS
SET NOCOUNT ON 

IF (NOT EXISTS (SELECT 1 FROM genUltPaginasVisitadasUsuarios WHERE (Usuario_Id = @pUsuario_Id) AND (OrdenFormularioMenu = dbo.FuncFKgenMenusFormulario(@pFormulario_id))))
BEGIN 
	---Esta tabla no puede tener mas de 12 registros
	DELETE FROM genUltPaginasVisitadasUsuarios 
	WHERE OrdenFormularioMenu NOT IN (SELECT TOP 11 OrdenFormularioMenu FROM genUltPaginasVisitadasUsuarios ORDER BY FechaRegistro DESC)

	
	INSERT INTO genUltPaginasVisitadasUsuarios
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
--Debemos actualizar la fecha de registro
ELSE 
BEGIN

UPDATE genUltPaginasVisitadasUsuarios 
SET FechaRegistro = GETDATE()
WHERE (Usuario_Id = @pUsuario_Id) AND (OrdenFormularioMenu = dbo.FuncFKgenMenusFormulario(@pFormulario_id))

END

GO

DROP PROCEDURE genUltPaginasVisitadasUsuariosDatos
GO
CREATE PROCEDURE genUltPaginasVisitadasUsuariosDatos
(
@pUsuario_Id int
)
AS
SET NOCOUNT ON 

Select '' as Formulario_Id

SELECT 	disFormularios.Formulario_Id, disFormularios.Titulo, mn2.Opcion as Modulo, mn1.Orden
FROM genUltPaginasVisitadasUsuarios 
INNER JOIN genMenus mn1 ON (mn1.Orden = genUltPaginasVisitadasUsuarios.OrdenFormularioMenu)
INNER JOIN disFormularios  ON (mn1.Formulario_Id = disFormularios.disFormularios)
--INNER JOIN genMenus mn2 on mn2.Orden = SUBSTRING(mn1.Orden, 1, 1) + '000' 
INNER JOIN genMenus mn2 on SUBSTRING(mn2.Orden, 1, 1) = SUBSTRING(mn1.Orden, 1, 1) AND mn2.Nivel = 1
WHERE (genUltPaginasVisitadasUsuarios.Usuario_Id = @pUsuario_Id)
ORDEr BY genUltPaginasVisitadasUsuarios.FechaRegistro DESC 
 RETURN @@Error 

GO

DROP PROCEDURE genUltPaginasVisitadasUsuariosEliminar
GO
CREATE PROCEDURE genUltPaginasVisitadasUsuariosEliminar
(
@pUsuario_Id int,
@pFormulario_id varchar(30)
)
AS
SET NOCOUNT ON 

DELETE FROM genUltPaginasVisitadasUsuarios 
WHERE (Usuario_Id = @pUsuario_Id)
AND (OrdenFormularioMenu = dbo.FuncFKgenMenusFormulario(@pFormulario_id))
 
 RETURN @@Error 

GO
