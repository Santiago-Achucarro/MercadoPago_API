DROP PROCEDURE suePersModContrataGuardar
GO
CREATE PROCEDURE suePersModContrataGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pModalidad_Id varchar(3),
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
IF (EXISTS (SELECT 1 FROM suePersModContrata WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersModContrata
	SET		FechaHasta = isnull((select min(Catego2.FechaDesde) 
		from suePersModContrata Catego2 
		where 
		Catego2.Legajo = suePersModContrata.Legajo and
		Catego2.FechaDesde>suePersModContrata.FechaDesde),@pFechaHasta),
		Modalidad_Id = @pModalidad_Id,
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
if (not exists(select Modalidad_Id from suePersModContrata where (Legajo = @pLegajo) AND (FechaHasta = '29990101')and Modalidad_Id=@pModalidad_Id))
begin
if not exists (select 1 from suePersModContrata where Legajo=@pLegajo)
BEGIN
set @pFechaDesde =(select FechaIngreso from suePersonal where genEntidades=@pLegajo)
end
update suePersModContrata set FechaHasta=DATEADD(dd,-1, @pFechaDesde) where FechaHasta='29990101' and 	Legajo = @pLegajo

	INSERT INTO suePersModContrata
	(
		Legajo,
		FechaDesde,
		FechaHasta,
		Modalidad_Id,
		Usuario_Id
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		@pFechaHasta,
		@pModalidad_Id,
		@pUsuario_Id
	)
END 
end
GO

DROP PROCEDURE suePersModContrataDatos
GO
CREATE PROCEDURE suePersModContrataDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

SELECT suePersModContrata.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersModContrata.FechaDesde, suePersModContrata.FechaHasta,
	suePersModContrata.Modalidad_Id, genEntidadesBasicasValor.Descripcion as DescripcionModalidad_Id, suePersModContrata.Usuario_Id
FROM suePersModContrata 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = suePersModContrata.Legajo)
left join genEntidadesBasicasValor on genEntidadesBasicasValor.Entidad_Id=1506 and genEntidadesBasicasValor.Clave=suePersModContrata.Modalidad_Id
WHERE (suePersonal.Legajo = @pLegajo)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersModContrataEliminar
GO
CREATE PROCEDURE suePersModContrataEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersModContrata 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
 RETURN @@Error 

GO

GO
