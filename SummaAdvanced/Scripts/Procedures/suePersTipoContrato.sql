DROP PROCEDURE suePersTipoContratoGuardar
GO
CREATE PROCEDURE suePersTipoContratoGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pTipoContrato varchar(2),
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
IF (EXISTS (SELECT 1 FROM suePersTipoContrato WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersTipoContrato
	SET		FechaHasta = isnull((select min(Catego2.FechaDesde) 
		from suePersTipoContrato Catego2 
		where 
		Catego2.Legajo = suePersTipoContrato.Legajo and
		Catego2.FechaDesde>suePersTipoContrato.FechaDesde),@pFechaHasta),
		TipoContrato = @pTipoContrato,
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
if (not exists(select TipoContrato from suePersTipoContrato where (Legajo = @pLegajo) AND (FechaHasta = '29990101')and TipoContrato=@pTipoContrato))
begin
if not exists (select 1 from suePersTipoContrato where Legajo=@pLegajo)
begin
set @pFechaDesde=(select FechaIngreso from suePersonal where genEntidades=@pLegajo)
end
update suePersTipoContrato set FechaHasta=DATEADD(dd,-1,@pFechaDesde) where FechaHasta='29990101' and 	Legajo = @pLegajo
	INSERT INTO suePersTipoContrato
	(
		Legajo,
		FechaDesde,
		FechaHasta,
		TipoContrato,
		Usuario_Id
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		@pFechaHasta,
		@pTipoContrato,
		@pUsuario_Id
	)
END 
end
GO

DROP PROCEDURE suePersTipoContratoDatos
GO
CREATE PROCEDURE suePersTipoContratoDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

SELECT suePersTipoContrato.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersTipoContrato.FechaDesde, suePersTipoContrato.FechaHasta,
	suePersTipoContrato.TipoContrato, genEntidadesBasicasValor.Descripcion as DescripcionTipoContrato, suePersTipoContrato.Usuario_Id
FROM suePersTipoContrato 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = suePersTipoContrato.Legajo)
left join genEntidadesBasicasValor on genEntidadesBasicasValor.Entidad_Id=1509 and genEntidadesBasicasValor.Clave=suePersTipoContrato.TipoContrato
WHERE (suePersonal.Legajo = @pLegajo)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersTipoContratoEliminar
GO
CREATE PROCEDURE suePersTipoContratoEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersTipoContrato 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
 RETURN @@Error 

GO

GO
