DROP PROCEDURE suePersCondServicioGuardar
GO
CREATE PROCEDURE suePersCondServicioGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pCondServicio_Id varchar(2),
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
IF (EXISTS (SELECT 1 FROM suePersCondServicio WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersCondServicio
	SET		FechaHasta = isnull((select min(Catego2.FechaDesde) 
		from suePersCondServicio Catego2 
		where 
		Catego2.Legajo = suePersCondServicio.Legajo and 
		Catego2.FechaDesde>suePersCondServicio.FechaDesde),@pFechaHasta),
		CondServicio_Id = @pCondServicio_Id,
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
if not exists (select 1 from suePersCondServicio where suePersCondServicio.Legajo = @pLegajo)
BEGIN
set @pFechaDesde=(select FechaIngreso from suePersonal where suePersonal.genEntidades=@pLegajo)
end
if (not exists(select CondServicio_Id from suePersCondServicio where (Legajo = @pLegajo) AND (FechaHasta = '29990101')and CondServicio_Id=@pCondServicio_Id))
begin
update suePersCondServicio set FechaHasta=DATEADD(dd,-1, @pFechaDesde) where FechaHasta='29990101' and 	Legajo = @pLegajo
	INSERT INTO suePersCondServicio
	(
		Legajo,
		FechaDesde,
		FechaHasta,
		CondServicio_Id,
		Usuario_Id
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		@pFechaHasta,
		@pCondServicio_Id,
		@pUsuario_Id
	)
END 
end
GO

DROP PROCEDURE suePersCondServicioDatos
GO
CREATE PROCEDURE suePersCondServicioDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

SELECT suePersCondServicio.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersCondServicio.FechaDesde, suePersCondServicio.FechaHasta,
	suePersCondServicio.CondServicio_Id, genEntidadesBasicasValor.Descripcion as DescripcionCondServicio, suePersCondServicio.Usuario_Id
FROM suePersCondServicio 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = suePersCondServicio.Legajo)
left join genEntidadesBasicasValor on genEntidadesBasicasValor.Entidad_Id=1503 and genEntidadesBasicasValor.Clave=suePersCondServicio.CondServicio_Id
WHERE (suePersonal.Legajo = @pLegajo)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersCondServicioEliminar
GO
CREATE PROCEDURE suePersCondServicioEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersCondServicio 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
 RETURN @@Error 

GO

GO
