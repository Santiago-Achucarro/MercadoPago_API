DROP PROCEDURE suePersAporteAdicGuardar
GO
CREATE PROCEDURE suePersAporteAdicGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pAdicional qMonedaD2,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
Set @pLegajo = (Select genEntidades From suePersonal Where Legajo = @pLegajo)
IF (EXISTS (SELECT 1 FROM suePersAporteAdic WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersAporteAdic
	SET FechaHasta = isNull((Select Min(Tabla2.FechaDesde) 
		From suePersAporteAdic Tabla2 
		Where 
		Tabla2.Legajo = suePersAporteAdic.Legajo And 
		Tabla2.FechaDesde>suePersAporteAdic.FechaDesde), @pFechaHasta),
		Adicional = @pAdicional,
		Usuario_Id = @pUsuario_Id
	Where (Legajo = @pLegajo) And (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
	If (Not Exists(Select Adicional From suePersAporteAdic Where (Legajo = @pLegajo) And (FechaHasta = '29990101') And Adicional = @pAdicional))
	Begin
		If Not Exists (Select 1 From suePersAporteAdic Where Legajo = @pLegajo)
		BEGIN
			Set @pFechaDesde = (Select FechaIngreso From suePersonal Where genEntidades = @pLegajo)
		End
		Update suePersAporteAdic set FechaHasta = DATEADD(dd,-1, @pFechaDesde) Where FechaHasta='29990101' And Legajo = @pLegajo
		INSERT INTO suePersAporteAdic
		(
			Legajo,
			FechaDesde,
			FechaHasta,
			Adicional,
			Usuario_Id
		)
		VALUES 
		(
			@pLegajo,
			@pFechaDesde,
			@pFechaHasta,
			@pAdicional,
			@pUsuario_Id
		)
	End
End
GO

DROP PROCEDURE suePersAporteAdicDatos
GO
CREATE PROCEDURE suePersAporteAdicDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

Select suePersAporteAdic.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersAporteAdic.FechaDesde, suePersAporteAdic.FechaHasta,
	suePersAporteAdic.Adicional, --genEntidadesBasicasValor.Descripcion as DescripcionTipoSDI, 
	suePersAporteAdic.Usuario_Id
From suePersAporteAdic 
Inner Join suePersonal  ON (suePersonal.genEntidades = suePersAporteAdic.Legajo)
--left join genEntidadesBasicasValor on genEntidadesBasicasValor.Entidad_Id=1513 and genEntidadesBasicasValor.Clave=suePersTipoSDI.TipoSDI
Where (suePersonal.Legajo = @pLegajo)
 
Return @@Error 

GO

DROP PROCEDURE suePersAporteAdicEliminar
GO
CREATE PROCEDURE suePersAporteAdicEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

Delete From suePersAporteAdic 
Where (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
And (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
Return @@Error 

GO

