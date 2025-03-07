DROP PROCEDURE suePersRebPromoGuardar
GO
CREATE PROCEDURE suePersRebPromoGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pRebaja qPorcentaje,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
Set @pLegajo = (Select genEntidades From suePersonal Where Legajo = @pLegajo)
IF (EXISTS (SELECT 1 FROM suePersRebPromo WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersRebPromo
	SET FechaHasta = isNull((Select Min(Tabla2.FechaDesde) 
		From suePersRebPromo Tabla2 
		Where 
		Tabla2.Legajo = suePersRebPromo.Legajo And 
		Tabla2.FechaDesde>suePersRebPromo.FechaDesde), @pFechaHasta),
		Rebaja = @pRebaja,
		Usuario_Id = @pUsuario_Id
	Where (Legajo = @pLegajo) And (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
	If (Not Exists(Select Rebaja From suePersRebPromo Where (Legajo = @pLegajo) And (FechaHasta = '29990101') And Rebaja = @pRebaja))
	Begin
		If Not Exists (Select 1 From suePersRebPromo Where Legajo = @pLegajo)
		BEGIN
			Set @pFechaDesde = (Select FechaIngreso From suePersonal Where genEntidades = @pLegajo)
		End
		Update suePersRebPromo set FechaHasta = DATEADD(dd,-1, @pFechaDesde) Where FechaHasta='29990101' And Legajo = @pLegajo
		INSERT INTO suePersRebPromo
		(
			Legajo,
			FechaDesde,
			FechaHasta,
			Rebaja,
			Usuario_Id
		)
		VALUES 
		(
			@pLegajo,
			@pFechaDesde,
			@pFechaHasta,
			@pRebaja,
			@pUsuario_Id
		)
	End
End
GO

DROP PROCEDURE suePersRebPromoDatos
GO
CREATE PROCEDURE suePersRebPromoDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

Select suePersRebPromo.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersRebPromo.FechaDesde, suePersRebPromo.FechaHasta,
	suePersRebPromo.Rebaja, --genEntidadesBasicasValor.Descripcion as DescripcionTipoSDI, 
	suePersRebPromo.Usuario_Id
From suePersRebPromo 
Inner Join suePersonal  ON (suePersonal.genEntidades = suePersRebPromo.Legajo)
--left join genEntidadesBasicasValor on genEntidadesBasicasValor.Entidad_Id=1513 and genEntidadesBasicasValor.Clave=suePersTipoSDI.TipoSDI
Where (suePersonal.Legajo = @pLegajo)
 
Return @@Error 

GO

DROP PROCEDURE suePersRebPromoEliminar
GO
CREATE PROCEDURE suePersRebPromoEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

Delete From suePersRebPromo 
Where (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
And (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
Return @@Error 

GO

