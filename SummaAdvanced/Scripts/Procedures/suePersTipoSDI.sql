DROP PROCEDURE suePersTipoSDIGuardar
GO
CREATE PROCEDURE suePersTipoSDIGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pTipoSDI char(1),
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
IF (EXISTS (SELECT 1 FROM suePersTipoSDI WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersTipoSDI
	SET		FechaHasta = isnull((select min(Catego2.FechaDesde) 
		from suePersTipoSDI Catego2 
		where 
		Catego2.Legajo = suePersTipoSDI.Legajo and 
		Catego2.FechaDesde>suePersTipoSDI.FechaDesde),@pFechaHasta),
		TipoSDI = @pTipoSDI,
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
if (not exists(select TipoSDI from suePersTipoSDI where (Legajo = @pLegajo) AND (FechaHasta = '29990101') and TipoSDI=@pTipoSDI))
begin
if not exists (select 1 from suePersTipoSDI where Legajo=@pLegajo)
BEGIN
set @pFechaDesde =(select FechaIngreso from suePersonal where genEntidades=@pLegajo)
end
update suePersTipoSDI set FechaHasta=DATEADD(dd,-1, @pFechaDesde) where FechaHasta='29990101' and 	Legajo = @pLegajo
	INSERT INTO suePersTipoSDI
	(
		Legajo,
		FechaDesde,
		FechaHasta,
		TipoSDI,
		Usuario_Id
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		@pFechaHasta,
		@pTipoSDI,
		@pUsuario_Id
	)
END 
end
GO

DROP PROCEDURE suePersTipoSDIDatos
GO
CREATE PROCEDURE suePersTipoSDIDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

SELECT suePersTipoSDI.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersTipoSDI.FechaDesde, suePersTipoSDI.FechaHasta,
	suePersTipoSDI.TipoSDI, genEntidadesBasicasValor.Descripcion as DescripcionTipoSDI, suePersTipoSDI.Usuario_Id
FROM suePersTipoSDI 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = suePersTipoSDI.Legajo)
left join genEntidadesBasicasValor on genEntidadesBasicasValor.Entidad_Id=1513 and genEntidadesBasicasValor.Clave=suePersTipoSDI.TipoSDI
WHERE (suePersonal.Legajo = @pLegajo)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersTipoSDIEliminar
GO
CREATE PROCEDURE suePersTipoSDIEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersTipoSDI 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
 RETURN @@Error 

GO

GO
