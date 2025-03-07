DROP PROCEDURE suePersRedZonalGuardar
GO
CREATE PROCEDURE suePersRedZonalGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pReduccion qMonedaD2,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
Set @pLegajo = (Select genEntidades From suePersonal Where Legajo = @pLegajo)
IF (EXISTS (SELECT 1 FROM suePersRedZonal WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersRedZonal
	SET FechaHasta = isNull((Select Min(Tabla2.FechaDesde) 
		From suePersRedZonal Tabla2 
		Where 
		Tabla2.Legajo = suePersRedZonal.Legajo And 
		Tabla2.FechaDesde>suePersRedZonal.FechaDesde), @pFechaHasta),
		Reduccion = @pReduccion,
		Usuario_Id = @pUsuario_Id
	Where (Legajo = @pLegajo) And (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
	If (Not Exists(Select Reduccion From suePersRedZonal Where (Legajo = @pLegajo) And (FechaHasta = '29990101') And Reduccion = @pReduccion))
	Begin
		If Not Exists (Select 1 From suePersRedZonal Where Legajo = @pLegajo)
		BEGIN
			Set @pFechaDesde = (Select FechaIngreso From suePersonal Where genEntidades = @pLegajo)
		End
		Update suePersRedZonal set FechaHasta = DATEADD(dd,-1, @pFechaDesde) Where FechaHasta='29990101' And Legajo = @pLegajo
		INSERT INTO suePersRedZonal
		(
			Legajo,
			FechaDesde,
			FechaHasta,
			Reduccion,
			Usuario_Id
		)
		VALUES 
		(
			@pLegajo,
			@pFechaDesde,
			@pFechaHasta,
			@pReduccion,
			@pUsuario_Id
		)
	End
End
GO

DROP PROCEDURE suePersRedZonalDatos
GO
CREATE PROCEDURE suePersRedZonalDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

Select suePersRedZonal.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersRedZonal.FechaDesde, suePersRedZonal.FechaHasta,
	suePersRedZonal.Reduccion, --genEntidadesBasicasValor.Descripcion as DescripcionTipoSDI, 
	suePersRedZonal.Usuario_Id
From suePersRedZonal 
Inner Join suePersonal  ON (suePersonal.genEntidades = suePersRedZonal.Legajo)
--left join genEntidadesBasicasValor on genEntidadesBasicasValor.Entidad_Id=1513 and genEntidadesBasicasValor.Clave=suePersTipoSDI.TipoSDI
Where (suePersonal.Legajo = @pLegajo)
 
Return @@Error 

GO

DROP PROCEDURE suePersRedZonalEliminar
GO
CREATE PROCEDURE suePersRedZonalEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

Delete From suePersRedZonal 
Where (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
And (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
Return @@Error 

GO

