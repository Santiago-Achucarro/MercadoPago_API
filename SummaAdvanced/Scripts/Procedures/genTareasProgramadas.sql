
DROP PROCEDURE genTareasProgramadasGuardar
GO
CREATE PROCEDURE genTareasProgramadasGuardar
(
@pTareaProgramada_Id varchar(80),
@pTareaProgramada_Id_Nuevo varchar(80),
@pDescripcion varchar(200),
@pTarea_Id varchar(80),
@pFechaInicio qFechaHora,
@pHoraInicio varchar(5),
@pFechaFin qFechaHora = NULL,
@pHoraFin varchar(5) = NULL,
@pTipoEjecucionTarea_Id varchar(2),
@pEmpresa_Id int = NULL,
@pInactivo Sino,
@pUsuario_Id int,
@pPosteado Sino
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM genTareasProgramadas WHERE (TareaProgramada_Id = @pTareaProgramada_Id)))
BEGIN 
	UPDATE genTareasProgramadas
	SET		@lIdentidad = genTareasProgramadas,
		TareaProgramada_Id = @pTareaProgramada_Id_Nuevo,
		Descripcion = @pDescripcion,
		Tarea_Id = dbo.FuncFKgenTareas(@pTarea_Id),
		FechaInicio = @pFechaInicio,
		HoraInicio = @pHoraInicio,
		FechaFin = @pFechaFin,
		HoraFin = @pHoraFin,
		TipoEjecucionTarea_Id = @pTipoEjecucionTarea_Id,
		Empresa_Id = @pEmpresa_Id,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (TareaProgramada_Id = @pTareaProgramada_Id)
END 
ELSE 
BEGIN 
	INSERT INTO genTareasProgramadas
	(
		TareaProgramada_Id,
		Descripcion,
		Tarea_Id,
		FechaInicio,
		HoraInicio,
		FechaFin,
		HoraFin,
		TipoEjecucionTarea_Id,
		Empresa_Id,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pTareaProgramada_Id,
		@pDescripcion,
		dbo.FuncFKgenTareas(@pTarea_Id),
		@pFechaInicio,
		@pHoraInicio,
		@pFechaFin,
		@pHoraFin,
		@pTipoEjecucionTarea_Id,
		@pEmpresa_Id,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO


DROP PROCEDURE genTareasProgramadasDatos
GO
CREATE PROCEDURE genTareasProgramadasDatos
(
@pTareaProgramada_Id varchar(80)
)
AS
SET NOCOUNT ON 

SELECT genTareasProgramadas.genTareasProgramadas, genTareasProgramadas.TareaProgramada_Id, genTareasProgramadas.Descripcion,
	genTareasProgramadas.TipoEjecucionTarea_Id,	 
	genTareas.Tarea_Id, genTareas.Descripcion as DescripcionTareas, 
	genTareasProgramadas.FechaInicio, genTareasProgramadas.HoraInicio, genTareasProgramadas.FechaFin, genTareasProgramadas.HoraFin, 
	genTareasProgramadas.TareaProgramada_Id TareaProgramada_Id_Nueva, genTareasProgramadas.Empresa_Id, 
	Cast( Case When genTareasProgramadas.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, genTareasProgramadas.Inactivo,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, genTareasProgramadas.Posteado, '' as Sitio
FROM genTareasProgramadas 
INNER JOIN genTiposEjecucionTarea  ON (genTiposEjecucionTarea.TipoEjecucionTarea_Id = genTareasProgramadas.TipoEjecucionTarea_Id)
INNER JOIN genTareas  ON (genTareas.genTareas = genTareasProgramadas.Tarea_Id)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = genTareasProgramadas.Usuario_Id)
WHERE (TareaProgramada_Id = @pTareaProgramada_Id)
 
Declare @pidentity bigint= dbo.FuncFKgenTareasProgramadas(@pTareaProgramada_Id)

exec genTareasProgConRepeticionDatos @pidentity

exec genTareasProgDiariasDatos @pidentity

exec genTareasProgSemanalesDatos @pidentity

exec genTareasProgMensualesDatos @pidentity

exec genTareasProgMensualesXDiaDatos @pidentity

exec genTareasProgMensualesXDiaSemanaDatos @pidentity

exec genTareasProgParametrosDatos @pidentity

RETURN @@Error 

GO

DROP PROCEDURE genTareasProgramadasEliminar
GO
CREATE PROCEDURE genTareasProgramadasEliminar
(
@pTareaProgramada_Id varchar(80) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM genTareasProgramadas 
WHERE (TareaProgramada_Id = @pTareaProgramada_Id)
 
 RETURN @@Error 

GO


DROP PROCEDURE genTareasProgramadasTodasDatos
GO
CREATE PROCEDURE genTareasProgramadasTodasDatos
(
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 

SELECT genTareasProgramadas.genTareasProgramadas, genTareasProgramadas.TareaProgramada_Id, genTareasProgramadas.Descripcion,
	genTareas.Tarea_Id, genTareas.Descripcion as DescripcionTareas, 
	genTareasProgramadas.FechaInicio, genTareasProgramadas.HoraInicio, genTareasProgramadas.FechaFin, genTareasProgramadas.HoraFin, 
	genTareasProgramadas.Inactivo, 
	'' as EstadoSO, CONVERT(date, null) as FechaUltEjecucion, '' as HoraUltEjecucion,  CONVERT(date, null) as FechaProxEjecucion, 
	'' as HoraProxEjecucion, '' as ResultadoUltVez, '' as EstadoActual, '' as ColorFondo, '' as ColorTexto, CAST(0 as bit) EstadoCorrecto
FROM genTareasProgramadas 
INNER JOIN genTareas  ON (genTareas.genTareas = genTareasProgramadas.Tarea_Id)
WHERE (genTareasProgramadas.Empresa_Id = @pEmpresa_Id)

RETURN @@Error 

GO



DROP FUNCTION FuncFKgenTareasProgramadas
GO

CREATE FUNCTION FuncFKgenTareasProgramadas
(
@pTareaProgramada_Id varchar (80)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = genTareasProgramadas FROM genTareasProgramadas WHERE 
	TareaProgramada_Id = @pTareaProgramada_Id
  RETURN @pIdentity
END

GO




