DROP PROCEDURE suePersSucursalGuardar
GO
CREATE PROCEDURE suePersSucursalGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pSucursal Sucursal = NULL,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
IF (EXISTS (SELECT 1 FROM suePersSucursal WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersSucursal
	SET		FechaHasta = isnull((select min(Catego2.FechaDesde) 
		from suePersSucursal Catego2 
		where 
		Catego2.Legajo = suePersSucursal.Legajo and 
		Catego2.FechaDesde>suePersSucursal.FechaDesde),@pFechaHasta),
		Sucursal = dbo.FuncFKgenSucursalesEmpr(@pSucursal),
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
if (not exists(select Sucursal from suePersSucursal where (Legajo = @pLegajo) AND (FechaHasta = '29990101') and Sucursal= dbo.FuncFKgenSucursalesEmpr( @pSucursal)))
begin
if not EXISTS (select 1 from suePersSucursal where Legajo=@pLegajo)
BEGIN
set @pFechaDesde=(select FechaIngreso from suePersonal where genEntidades=@pLegajo)
end
update suePersSucursal set FechaHasta=DATEADD(dd,-1, @pFechaDesde) where FechaHasta='29990101' and 	Legajo = @pLegajo
	INSERT INTO suePersSucursal
	(
		Legajo,
		FechaDesde,
		FechaHasta,
		Sucursal,
		Usuario_Id
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		@pFechaHasta,
		dbo.FuncFKgenSucursalesEmpr(@pSucursal),
		@pUsuario_Id
	)
END 
end
GO

DROP PROCEDURE suePersSucursalDatos
GO
CREATE PROCEDURE suePersSucursalDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

SELECT suePersSucursal.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersSucursal.FechaDesde, suePersSucursal.FechaHasta,
	genSucursalesEmpr.Sucursal, genSucursalesEmpr.Descripcion as DescripcionSucursal, suePersSucursal.Usuario_Id
FROM suePersSucursal 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = suePersSucursal.Legajo)
left join genSucursalesEmpr on genSucursalesEmpr.genSucursalesEmpr=suePersSucursal.Sucursal
WHERE (suePersonal.Legajo = @pLegajo)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersSucursalEliminar
GO
CREATE PROCEDURE suePersSucursalEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersSucursal 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
 RETURN @@Error 

GO

GO
