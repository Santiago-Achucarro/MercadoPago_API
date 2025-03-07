DROP PROCEDURE suePersTipoEmpleadorGuardar
GO
CREATE PROCEDURE suePersTipoEmpleadorGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pTipoEmpleador_Id varchar(2),
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
IF (EXISTS (SELECT 1 FROM suePersTipoEmpleador WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersTipoEmpleador
	SET		FechaHasta = isnull((select min(Catego2.FechaDesde) 
		from suePersTipoEmpleador Catego2 
		where 
		Catego2.Legajo = suePersTipoEmpleador.Legajo and 
		Catego2.FechaDesde>suePersTipoEmpleador.FechaDesde),@pFechaHasta),
		TipoEmpleador_Id = @pTipoEmpleador_Id,
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
if (not exists(select TipoEmpleador_Id from suePersTipoEmpleador where (Legajo = @pLegajo) AND (FechaHasta = '29990101')and @pTipoEmpleador_Id=@pTipoEmpleador_Id))
begin
if not exists (select 1 from suePersTipoEmpleador where Legajo=@pLegajo)
BEGIN
set @pFechaDesde=(select FechaIngreso from suePersonal where genEntidades=@pLegajo)
end
update suePersTipoEmpleador set FechaHasta=DATEADD(dd,-1, @pFechaDesde) where FechaHasta='29990101' and 	Legajo = @pLegajo
	INSERT INTO suePersTipoEmpleador
	(
		Legajo,
		FechaDesde,
		FechaHasta,
		TipoEmpleador_Id,
		Usuario_Id
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		@pFechaHasta,
		@pTipoEmpleador_Id,
		@pUsuario_Id
	)
END 
end
GO

DROP PROCEDURE suePersTipoEmpleadorDatos
GO
CREATE PROCEDURE suePersTipoEmpleadorDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

SELECT suePersTipoEmpleador.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersTipoEmpleador.FechaDesde, suePersTipoEmpleador.FechaHasta,
	suePersTipoEmpleador.TipoEmpleador_Id, genEntidadesBasicasValor.Descripcion as DescripcionTipoEmpleador, suePersTipoEmpleador.Usuario_Id
FROM suePersTipoEmpleador 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = suePersTipoEmpleador.Legajo)
left join genEntidadesBasicasValor on genEntidadesBasicasValor.Entidad_Id=1510 and genEntidadesBasicasValor.Clave=suePersTipoEmpleador.TipoEmpleador_Id
WHERE (suePersonal.Legajo = @pLegajo)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersTipoEmpleadorEliminar
GO
CREATE PROCEDURE suePersTipoEmpleadorEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersTipoEmpleador 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
 RETURN @@Error 

GO

GO
