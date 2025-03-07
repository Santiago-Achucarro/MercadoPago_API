DROP PROCEDURE suePersTareasGuardar
GO
CREATE PROCEDURE suePersTareasGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pTarea_Id varchar(5) = NULL,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
IF (EXISTS (SELECT 1 FROM suePersTareas WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersTareas
	SET		FechaHasta = @pFechaHasta,
		Tarea_Id = dbo.FuncFKsueTareas(@pTarea_Id),
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
if not exists (select 1 from suePersTareas where Legajo=@pLegajo)
begin
set @pFechaDesde = (select 1 from suePersonal where genEntidades=@pLegajo)
end
if (not exists(select Tarea_Id from suePersTareas where (Legajo = @pLegajo) AND (FechaHasta = '29990101')and Tarea_Id=dbo.FuncFKsueTareas(@pTarea_Id)))
begin
	INSERT INTO suePersTareas
	(
		Legajo,
		FechaDesde,
		FechaHasta,
		Tarea_Id,
		Usuario_Id
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		@pFechaHasta,
		dbo.FuncFKsueTareas(@pTarea_Id),
		@pUsuario_Id
	)
END 
end
GO

DROP PROCEDURE suePersTareasDatos
GO
CREATE PROCEDURE suePersTareasDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

SELECT suePersTareas.Legajo, suePersTareas.FechaDesde, suePersTareas.FechaHasta,
	sueTareas.Tarea_Id, sueTareas.Descripcion as DescripcionTareas, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM suePersTareas 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = suePersTareas.Legajo)
LEFT JOIN sueTareas  ON (sueTareas.sueTareas = suePersTareas.Tarea_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = suePersTareas.Usuario_Id)
WHERE (suePersonal.Legajo = @pLegajo)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersTareasEliminar
GO
CREATE PROCEDURE suePersTareasEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersTareas 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
 RETURN @@Error 

GO

GO
