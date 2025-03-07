DROP PROCEDURE suePersActividadGuardar
GO
CREATE PROCEDURE suePersActividadGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pActividad_Id varchar(4),
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
IF (EXISTS (SELECT 1 FROM suePersActividad WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersActividad
	SET		FechaHasta = isnull((select min(Catego2.FechaDesde) 
		from suePersActividad Catego2 where 
			Catego2.Legajo = suePersActividad.Legajo and 
			Catego2.FechaDesde>suePersActividad.FechaDesde),@pFechaHasta),
		Actividad_Id = @pActividad_Id,
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
if(exists (select Actividad_Id from  suePersActividad where (Legajo = (@pLegajo))))
begin
set TRANSACTION ISOLATION level READ UNCOMMITTED
set @pFechaDesde=(select FechaIngreso from suePersonal where genEntidades=@pLegajo)
end
if (not exists(select Actividad_Id from suePersActividad where (Legajo = @pLegajo) AND (FechaHasta = '29990101')and Actividad_Id=@pActividad_Id))
begin
update suePersActividad set FechaHasta= DATEADD(dd,-1,@pFechaDesde) where FechaHasta='29990101' and 	Legajo = @pLegajo
	INSERT INTO suePersActividad
	(
		Legajo,
		FechaDesde,
		FechaHasta,
		Actividad_Id,
		Usuario_Id
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		@pFechaHasta,
		@pActividad_Id,
		@pUsuario_Id
	) 
end
end
GO

DROP PROCEDURE suePersActividadDatos
GO
CREATE PROCEDURE suePersActividadDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

SELECT suePersActividad.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersActividad.FechaDesde, suePersActividad.FechaHasta,
	suePersActividad.Actividad_Id, genEntidadesBasicasValor.Descripcion as DescripcionActividad, suePersActividad.Usuario_Id
FROM suePersActividad 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = suePersActividad.Legajo)
left join genEntidadesBasicasValor on genEntidadesBasicasValor.Entidad_Id=1501 and genEntidadesBasicasValor.Clave=suePersActividad.Actividad_Id
WHERE (suePersonal.Legajo = @pLegajo)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersActividadEliminar
GO
CREATE PROCEDURE suePersActividadEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersActividad 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
 RETURN @@Error 

GO

GO
