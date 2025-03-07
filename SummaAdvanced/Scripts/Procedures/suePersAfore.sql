DROP PROCEDURE suePersAforeGuardar
GO
CREATE PROCEDURE suePersAforeGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pAfore_Id varchar(5),
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
IF (EXISTS (SELECT 1 FROM suePersAfore WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersAfore
	SET		FechaHasta = isnull((select min(Catego2.FechaDesde) 
		from suePersAfore Catego2 
			where 
			Catego2.Legajo = suePersAfore.Legajo and 
			Catego2.FechaDesde>suePersAfore.FechaDesde),@pFechaHasta),
		Afore_Id = @pAfore_Id,
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
if not exists (select 1 from suePersAfore where suePersAfore.Legajo=@pLegajo)
begin
set transaction isolation level read UNCOMMITTED
set @pFechaDesde=(select FechaIngreso from suePersonal where @pLegajo=genEntidades)
end
if (not exists(select Afore_Id from suePersAfore where (Legajo = @pLegajo) AND (FechaHasta = '29990101')and @pAfore_Id=@pAfore_Id))
begin
update suePersAfore set FechaHasta=DATEADD(dd,-1, @pFechaDesde) where FechaHasta='29990101' and 	Legajo = @pLegajo
	INSERT INTO suePersAfore
	(
		Legajo,
		FechaDesde,
		FechaHasta,
		Afore_Id,
		Usuario_Id
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		@pFechaHasta,
		@pAfore_Id,
		@pUsuario_Id
	)
END 
end
GO

DROP PROCEDURE suePersAforeDatos
GO
CREATE PROCEDURE suePersAforeDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

SELECT suePersAfore.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersAfore.FechaDesde, suePersAfore.FechaHasta,
	suePersAfore.Afore_Id, genEntidadesBasicasValor.Descripcion as DescripcionAfore, suePersAfore.Usuario_Id
FROM suePersAfore 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = suePersAfore.Legajo)
left join genEntidadesBasicasValor on genEntidadesBasicasValor.Entidad_Id=1502 and genEntidadesBasicasValor.Clave = suePersAfore.Afore_Id
WHERE (suePersonal.Legajo = @pLegajo)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersAforeEliminar
GO
CREATE PROCEDURE suePersAforeEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersAfore 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
 RETURN @@Error 

GO

GO
