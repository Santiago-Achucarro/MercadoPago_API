DROP PROCEDURE suePersEstadoCivilGuardar
GO
CREATE PROCEDURE suePersEstadoCivilGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pEstadoCivil_Id varchar(3),
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
IF (EXISTS (SELECT 1 FROM suePersEstadoCivil WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersEstadoCivil
	SET		FechaHasta = isnull((select min(Catego2.FechaDesde) 
		from suePersEstadoCivil Catego2 
		where 
		Catego2.Legajo = suePersEstadoCivil.Legajo and
		Catego2.FechaDesde>suePersEstadoCivil.FechaDesde),@pFechaHasta),
		EstadoCivil_Id = @pEstadoCivil_Id,
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
if (not exists(select EstadoCivil_Id from suePersEstadoCivil where (Legajo = @pLegajo) AND (FechaHasta = '29990101')and EstadoCivil_Id=@pEstadoCivil_Id))
begin
if not EXISTS (select 1 from suePersEstadoCivil where Legajo=@pLegajo)
BEGIN
set @pFechaDesde=(select FechaIngreso from suePersonal where genEntidades=@pLegajo)
end
update suePersEstadoCivil set FechaHasta=DATEADD(dd,-1, @pFechaDesde) where FechaHasta='29990101' and 	Legajo = @pLegajo
	INSERT INTO suePersEstadoCivil
	(
		Legajo,
		FechaDesde,
		FechaHasta,
		EstadoCivil_Id,
		Usuario_Id
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		@pFechaHasta,
		@pEstadoCivil_Id,
		@pUsuario_Id
	)
END 
end
GO

DROP PROCEDURE suePersEstadoCivilDatos
GO
CREATE PROCEDURE suePersEstadoCivilDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

SELECT suePersEstadoCivil.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersEstadoCivil.FechaDesde, suePersEstadoCivil.FechaHasta,
	suePersEstadoCivil.EstadoCivil_Id, genEntidadesBasicasValor.Descripcion as DescripcionEstadoCivil, suePersEstadoCivil.Usuario_Id
FROM suePersEstadoCivil 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = suePersEstadoCivil.Legajo)
left join genEntidadesBasicasValor on genEntidadesBasicasValor.Entidad_Id=1504 and genEntidadesBasicasValor.Clave=suePersEstadoCivil.EstadoCivil_Id
WHERE (suePersonal.Legajo = @pLegajo)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersEstadoCivilEliminar
GO
CREATE PROCEDURE suePersEstadoCivilEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersEstadoCivil 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
 RETURN @@Error 

GO

GO
