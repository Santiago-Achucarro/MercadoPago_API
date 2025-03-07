DROP PROCEDURE suePersSiniestradoGuardar
GO
CREATE PROCEDURE suePersSiniestradoGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pSiniestro_Id varchar(2),
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
IF (EXISTS (SELECT 1 FROM suePersSiniestrado WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersSiniestrado
	SET		FechaHasta = isnull((select min(Catego2.FechaDesde) 
		from suePersSiniestrado Catego2 
		where 
		Catego2.Legajo = suePersSiniestrado.Legajo and
		Catego2.FechaDesde>suePersSiniestrado.FechaDesde),@pFechaHasta),
		Siniestro_Id = @pSiniestro_Id,
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN
if (not exists(select Siniestro_Id from suePersSiniestrado where (Legajo = @pLegajo) AND (FechaHasta = '29990101')and Siniestro_Id=@pSiniestro_Id))
begin
if not exists (select 1 from suePersSiniestrado where Legajo=@pLegajo)
begin 
set @pFechaDesde=(select FechaIngreso from suePersonal where genEntidades=@pLegajo)
end
update suePersSiniestrado set FechaHasta=DATEADD(dd,-1, @pFechaDesde) where FechaHasta='29990101' and 	Legajo = @pLegajo
	INSERT INTO suePersSiniestrado
	(
		Legajo,
		FechaDesde,
		FechaHasta,
		Siniestro_Id,
		Usuario_Id
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		@pFechaHasta,
		@pSiniestro_Id,
		@pUsuario_Id
	)
END 
end
GO

DROP PROCEDURE suePersSiniestradoDatos
GO
CREATE PROCEDURE suePersSiniestradoDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

SELECT suePersSiniestrado.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersSiniestrado.FechaDesde, suePersSiniestrado.FechaHasta,
	suePersSiniestrado.Siniestro_Id, genEntidadesBasicasValor.Descripcion as DescripcionSiniestro, suePersSiniestrado.Usuario_Id
FROM suePersSiniestrado 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = suePersSiniestrado.Legajo)
left join genEntidadesBasicasValor on genEntidadesBasicasValor.Entidad_Id=1507 and genEntidadesBasicasValor.Clave=suePersSiniestrado.Siniestro_Id
WHERE (suePersonal.Legajo = @pLegajo)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersSiniestradoEliminar
GO
CREATE PROCEDURE suePersSiniestradoEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersSiniestrado 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
 RETURN @@Error 

GO

GO
