DROP PROCEDURE suePersConvenioGuardar
GO
CREATE PROCEDURE suePersConvenioGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pConvenio_Id varchar(5),
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
IF (EXISTS (SELECT 1 FROM suePersConvenio WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersConvenio
	SET		FechaHasta = isnull((select min(Catego2.FechaDesde) 
			from suePersConvenio Catego2 
			where 
			Catego2.Legajo = suePersConvenio.Legajo and
			Catego2.FechaDesde>suePersConvenio.FechaDesde),@pFechaHasta),
		Convenio_Id = dbo.FuncFKsueConvenio(@pConvenio_Id),
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
if (not exists(select Convenio_Id from suePersConvenio where (Legajo = @pLegajo) AND (FechaHasta = '29990101')and Convenio_Id=dbo.FuncFKsueConvenio(@pConvenio_Id)))
begin
if not exists (select 1 from suePersConvenio where Legajo=@pLegajo)
BEGIN
set @pFechaDesde =(select FechaIngreso from suePersonal where genEntidades=@pLegajo)
end
update suePersConvenio set FechaHasta=DATEADD(dd,-1, @pFechaDesde) where FechaHasta='29990101' and 	Legajo = @pLegajo
	INSERT INTO suePersConvenio
	(
		Legajo,
		FechaDesde,
		FechaHasta,
		Convenio_Id,
		Usuario_Id
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		@pFechaHasta,
		dbo.FuncFKsueConvenio(@pConvenio_Id),
		@pUsuario_Id
	)
END 
end
GO

DROP PROCEDURE suePersConvenioDatos
GO
CREATE PROCEDURE suePersConvenioDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

SELECT suePersConvenio.Legajo, suePersConvenio.FechaDesde, suePersConvenio.FechaHasta, sueConvenio.Convenio_Id, sueConvenio.Descripcion as DescripcionConvenio,
	suePersConvenio.Usuario_Id
FROM suePersConvenio 
inner join suePersonal on suePersConvenio.Legajo=suePersonal.genEntidades
LEFT JOIN sueConvenio  ON (sueConvenio.sueConvenio = suePersConvenio.Convenio_Id)
WHERE (suePersonal.Legajo = @pLegajo)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersConvenioEliminar
GO
CREATE PROCEDURE suePersConvenioEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersConvenio 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
 RETURN @@Error 

GO

GO
