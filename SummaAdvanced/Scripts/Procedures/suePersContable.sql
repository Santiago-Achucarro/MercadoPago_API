DROP PROCEDURE suePersContableGuardar
GO
CREATE PROCEDURE suePersContableGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
IF (EXISTS (SELECT 1 FROM suePersContable WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersContable
	SET		FechaHasta = isnull((select min(Catego2.FechaDesde) 
		from suePersContable Catego2 
		where 
		Catego2.Legajo = suePersContable.Legajo and 
		Catego2.FechaDesde>suePersContable.FechaDesde),@pFechaHasta),
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
if (not exists(select FechaDesde from suePersContable where (Legajo = @pLegajo) AND (FechaHasta = '29990101')and FechaDesde>=@pFechaDesde))
begin
if not exists (select 1 from suePersContable where Legajo=@pLegajo)
BEGIN
set @pFechaDesde =(select FechaIngreso from suePersonal where suePersonal.genEntidades=@pLegajo)
end
update suePersContable set FechaHasta=DATEADD(dd,-1, @pFechaDesde) where FechaHasta='29990101' and 	Legajo = @pLegajo
	INSERT INTO suePersContable
	(
		Legajo,
		FechaDesde,
		FechaHasta,
		Usuario_Id
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		@pFechaHasta,
		@pUsuario_Id
	)
END 
end
GO

DROP PROCEDURE suePersContableDatosSP
GO
CREATE PROCEDURE suePersContableDatosSP
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

SELECT suePersContable.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersContable.FechaDesde, suePersContable.FechaHasta,
	suePersContable.Usuario_Id, Cast(0 as int) Renglon
FROM suePersContable 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = suePersContable.Legajo)
WHERE (suePersonal.Legajo = @pLegajo)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersContableEliminar
GO
CREATE PROCEDURE suePersContableEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersContable 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
 RETURN @@Error 

GO

GO
