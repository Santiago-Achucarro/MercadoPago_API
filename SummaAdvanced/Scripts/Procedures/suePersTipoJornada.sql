DROP PROCEDURE suePersTipoJornadaGuardar
GO
CREATE PROCEDURE suePersTipoJornadaGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pTipoJornada varchar(2),
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
IF (EXISTS (SELECT 1 FROM suePersTipoJornada WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersTipoJornada
	SET		FechaHasta = isnull((select min(Catego2.FechaDesde) 
			from suePersTipoJornada Catego2 
			where 
			Catego2.Legajo = suePersTipoJornada.Legajo and 
			Catego2.FechaDesde>suePersTipoJornada.FechaDesde),@pFechaHasta),
		TipoJornada = @pTipoJornada,
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
if (not exists(select TipoJornada from suePersTipoJornada where (Legajo = @pLegajo) AND (FechaHasta = '29990101')and TipoJornada=@pTipoJornada))
begin
if not EXISTS (select 1 from suePersTipoJornada where Legajo=@pLegajo)
begin
set @pFechaDesde=(select FechaIngreso from suePersonal where genEntidades=@pLegajo)
end
update suePersTipoJornada set FechaHasta=DATEADD(dd,-1, @pFechaDesde) where FechaHasta='29990101' and 	Legajo = @pLegajo
	INSERT INTO suePersTipoJornada 
	(
		Legajo,
		FechaDesde,
		FechaHasta,
		TipoJornada,
		Usuario_Id
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		@pFechaHasta,
		@pTipoJornada,
		@pUsuario_Id
	)
END 
end
GO

DROP PROCEDURE suePersTipoJornadaDatos
GO
CREATE PROCEDURE suePersTipoJornadaDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

SELECT suePersTipoJornada.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersTipoJornada.FechaDesde, suePersTipoJornada.FechaHasta,
	suePersTipoJornada.TipoJornada, genEntidadesBasicasValor.Descripcion as DescripcionTipoJornada, suePersTipoJornada.Usuario_Id
FROM suePersTipoJornada 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = suePersTipoJornada.Legajo)
left join genEntidadesBasicasValor on genEntidadesBasicasValor.Entidad_Id=1511 and genEntidadesBasicasValor.Clave=suePersTipoJornada.TipoJornada
WHERE (suePersonal.Legajo = @pLegajo)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersTipoJornadaEliminar
GO
CREATE PROCEDURE suePersTipoJornadaEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersTipoJornada 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
 RETURN @@Error 

GO

GO
