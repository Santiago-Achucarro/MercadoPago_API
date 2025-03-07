DROP PROCEDURE suePersTipoRegimenGuardar
GO
CREATE PROCEDURE suePersTipoRegimenGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pTipoRegimen varchar(2),
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
IF (EXISTS (SELECT 1 FROM suePersTipoRegimen WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersTipoRegimen
	SET		FechaHasta = isnull((select min(Catego2.FechaDesde) 
		from suePersTipoRegimen Catego2 
		where 
		Catego2.Legajo = suePersTipoRegimen.Legajo and 
		Catego2.FechaDesde>suePersTipoRegimen.FechaDesde),@pFechaHasta),

		TipoRegimen = @pTipoRegimen,
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
if (not exists(select TipoRegimen from suePersTipoRegimen where (Legajo = @pLegajo) AND (FechaHasta = '29990101')and TipoRegimen=@pTipoRegimen))
begin
if not EXISTS (select 1 from suePersTipoRegimen where Legajo=@pLegajo)
BEGIN
set @pFechaDesde=(select FechaIngreso from suePersonal where genEntidades=@pLegajo)
end
update suePersTipoRegimen set FechaHasta=DATEADD(dd,-1, @pFechaDesde) where FechaHasta='29990101' and 	Legajo = @pLegajo
	INSERT INTO suePersTipoRegimen
	(
		Legajo,
		FechaDesde,
		FechaHasta,
		TipoRegimen,
		Usuario_Id
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		@pFechaHasta,
		@pTipoRegimen,
		@pUsuario_Id
	)
END 
end
GO

DROP PROCEDURE suePersTipoRegimenDatos
GO
CREATE PROCEDURE suePersTipoRegimenDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

SELECT suePersTipoRegimen.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersTipoRegimen.FechaDesde, suePersTipoRegimen.FechaHasta,
	suePersTipoRegimen.TipoRegimen, genEntidadesBasicasValor.Descripcion as DescripcionTipoRegimen, suePersTipoRegimen.Usuario_Id
FROM suePersTipoRegimen 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = suePersTipoRegimen.Legajo)
left join genEntidadesBasicasValor on genEntidadesBasicasValor.Entidad_Id=1512 and genEntidadesBasicasValor.Clave=suePersTipoRegimen.TipoRegimen
WHERE (suePersonal.Legajo = @pLegajo)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersTipoRegimenEliminar
GO
CREATE PROCEDURE suePersTipoRegimenEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersTipoRegimen 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
 RETURN @@Error 

GO

GO
