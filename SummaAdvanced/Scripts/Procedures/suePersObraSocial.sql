DROP PROCEDURE suePersObraSocialGuardar
GO
CREATE PROCEDURE suePersObraSocialGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pObraSocial varChar(6),
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
Set @pLegajo = (Select genEntidades From suePersonal Where Legajo = @pLegajo)
IF (EXISTS (SELECT 1 FROM suePersObraSocial WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersObraSocial
	SET FechaHasta = isNull((Select Min(Tabla2.FechaDesde) 
		From suePersObraSocial Tabla2 
		Where 
		Tabla2.Legajo = suePersObraSocial.Legajo And 
		Tabla2.FechaDesde>suePersObraSocial.FechaDesde), @pFechaHasta),
		ObraSocial = @pObraSocial,
		Usuario_Id = @pUsuario_Id
	Where (Legajo = @pLegajo) And (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
	If (Not Exists(Select ObraSocial From suePersObraSocial Where (Legajo = @pLegajo) And (FechaHasta = '29990101') And ObraSocial = @pObraSocial))
	Begin
		If Not Exists (Select 1 From suePersObraSocial Where Legajo = @pLegajo)
		BEGIN
			Set @pFechaDesde = (Select FechaIngreso From suePersonal Where genEntidades = @pLegajo)
		End
		Update suePersObraSocial set FechaHasta = DATEADD(dd,-1, @pFechaDesde) Where FechaHasta='29990101' And Legajo = @pLegajo
		INSERT INTO suePersObraSocial
		(
			Legajo,
			FechaDesde,
			FechaHasta,
			ObraSocial,
			Usuario_Id
		)
		VALUES 
		(
			@pLegajo,
			@pFechaDesde,
			@pFechaHasta,
			@pObraSocial,
			@pUsuario_Id
		)
	End
End
GO

DROP PROCEDURE suePersObraSocialDatos
GO
CREATE PROCEDURE suePersObraSocialDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

Select suePersObraSocial.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersObraSocial.FechaDesde, suePersObraSocial.FechaHasta,
	suePersObraSocial.ObraSocial, genEntidadesBasicasValor.Descripcion as DescripcionObraSocial, 
	suePersObraSocial.Usuario_Id
From suePersObraSocial 
Inner Join suePersonal  ON (suePersonal.genEntidades = suePersObraSocial.Legajo)
Left Join genEntidadesBasicasValor on genEntidadesBasicasValor.Entidad_Id=1607 And genEntidadesBasicasValor.Clave = suePersObraSocial.ObraSocial
Where (suePersonal.Legajo = @pLegajo)
 
Return @@Error 

GO

DROP PROCEDURE suePersObraSocialEliminar
GO
CREATE PROCEDURE suePersObraSocialEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

Delete From suePersObraSocial 
Where (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
And (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
Return @@Error 

GO

