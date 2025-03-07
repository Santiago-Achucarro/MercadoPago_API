DROP PROCEDURE suePersLocalidadGuardar
GO
CREATE PROCEDURE suePersLocalidadGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pLocalidad_Id varchar(2),
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
IF (EXISTS (SELECT 1 FROM suePersLocalidad WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersLocalidad
	SET		FechaHasta = isnull((select min(Catego2.FechaDesde) 
		from suePersLocalidad Catego2 
		where 
		Catego2.Legajo = suePersLocalidad.Legajo and
		Catego2.FechaDesde>suePersLocalidad.FechaDesde),@pFechaHasta),
		Localidad_Id = @pLocalidad_Id,
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
if (not exists(select Localidad_Id from suePersLocalidad where (Legajo = @pLegajo) AND (FechaHasta = '29990101')and Localidad_Id=@pLocalidad_Id))
begin
if not exists (select 1 from suePersLocalidad where Legajo=@pLegajo)
BEGIN
set @pFechaDesde=(select FechaIngreso from suePersonal where genEntidades=@pLegajo)
end
update suePersLocalidad set FechaHasta=DATEADD(dd,-1, @pFechaDesde) where FechaHasta='29990101' and 	Legajo = @pLegajo
	INSERT INTO suePersLocalidad
	(
		Legajo,
		FechaDesde,
		FechaHasta,
		Localidad_Id,
		Usuario_Id
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		@pFechaHasta,
		@pLocalidad_Id,
		@pUsuario_Id
	)
END 
end
GO

DROP PROCEDURE suePersLocalidadDatos
GO
CREATE PROCEDURE suePersLocalidadDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

SELECT suePersLocalidad.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersLocalidad.FechaDesde, suePersLocalidad.FechaHasta,
	suePersLocalidad.Localidad_Id, genEntidadesBasicasValor.Descripcion as DescripcionLocalidad, suePersLocalidad.Usuario_Id
FROM suePersLocalidad 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = suePersLocalidad.Legajo)
left join genEntidadesBasicasValor on genEntidadesBasicasValor.Entidad_Id=1505 and genEntidadesBasicasValor.Clave=suePersLocalidad.Localidad_Id
WHERE (suePersonal.Legajo = @pLegajo)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersLocalidadEliminar
GO
CREATE PROCEDURE suePersLocalidadEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersLocalidad 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
 RETURN @@Error 

GO

GO
