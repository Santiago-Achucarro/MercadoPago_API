DROP PROCEDURE suePersAporteVoluntarioGuardar
GO
CREATE PROCEDURE suePersAporteVoluntarioGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pVoluntario qMonedaD2,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
Set @pLegajo = (Select genEntidades From suePersonal Where Legajo = @pLegajo)
IF (EXISTS (SELECT 1 FROM suePersAporteVoluntario WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersAporteVoluntario
	SET FechaHasta = isNull((Select Min(Tabla2.FechaDesde) 
		From suePersAporteVoluntario Tabla2 
		Where 
		Tabla2.Legajo = suePersAporteVoluntario.Legajo And 
		Tabla2.FechaDesde>suePersAporteVoluntario.FechaDesde), @pFechaHasta),
		Voluntario = @pVoluntario,
		Usuario_Id = @pUsuario_Id
	Where (Legajo = @pLegajo) And (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
	If (Not Exists(Select Voluntario From suePersAporteVoluntario Where (Legajo = @pLegajo) And (FechaHasta = '29990101') And Voluntario = @pVoluntario))
	Begin
		If Not Exists (Select 1 From suePersAporteVoluntario Where Legajo = @pLegajo)
		BEGIN
			Set @pFechaDesde = (Select FechaIngreso From suePersonal Where genEntidades = @pLegajo)
		End
		Update suePersAporteVoluntario set FechaHasta = DATEADD(dd,-1, @pFechaDesde) Where FechaHasta='29990101' And Legajo = @pLegajo
		INSERT INTO suePersAporteVoluntario
		(
			Legajo,
			FechaDesde,
			FechaHasta,
			Voluntario,
			Usuario_Id
		)
		VALUES 
		(
			@pLegajo,
			@pFechaDesde,
			@pFechaHasta,
			@pVoluntario,
			@pUsuario_Id
		)
	End
End
GO

DROP PROCEDURE suePersAporteVoluntarioDatos
GO
CREATE PROCEDURE suePersAporteVoluntarioDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

Select suePersAporteVoluntario.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersAporteVoluntario.FechaDesde, suePersAporteVoluntario.FechaHasta,
	suePersAporteVoluntario.Voluntario, --genEntidadesBasicasValor.Descripcion as DescripcionTipoSDI, 
	suePersAporteVoluntario.Usuario_Id
From suePersAporteVoluntario 
Inner Join suePersonal  ON (suePersonal.genEntidades = suePersAporteVoluntario.Legajo)
--left join genEntidadesBasicasValor on genEntidadesBasicasValor.Entidad_Id=1513 and genEntidadesBasicasValor.Clave=suePersTipoSDI.TipoSDI
Where (suePersonal.Legajo = @pLegajo)
 
Return @@Error 

GO

DROP PROCEDURE suePersAporteVoluntarioEliminar
GO
CREATE PROCEDURE suePersAporteVoluntarioEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

Delete From suePersAporteVoluntario 
Where (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
And (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
Return @@Error 

GO

