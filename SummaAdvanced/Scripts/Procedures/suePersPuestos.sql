DROP PROCEDURE suePersPuestosGuardar
GO
CREATE PROCEDURE suePersPuestosGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pPuesto_Id varchar(5),
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
IF (EXISTS (SELECT 1 FROM suePersPuestos WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersPuestos
	SET		FechaHasta = isnull((select min(Catego2.FechaDesde) 
		from suePersPuestos Catego2 
		where 
		Catego2.Legajo = suePersPuestos.Legajo and
		Catego2.FechaDesde>suePersPuestos.FechaDesde),@pFechaHasta),
		Puesto_Id =dbo.FuncFKsuePuestos(@pPuesto_Id),
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
if (not exists(select Puesto_Id from suePersPuestos where (Legajo = @pLegajo) AND (FechaHasta = '29990101')and Puesto_Id=dbo.FuncFKsuePuestos(@pPuesto_Id)))
begin
if not exists (select 1 from suePersPuestos where Legajo=@pLegajo)
begin
set @pFechaDesde=(select FechaIngreso from suePersonal where genEntidades=@pLegajo)
end
update suePersPuestos set FechaHasta=DATEADD(dd,-1, @pFechaDesde) where FechaHasta='29990101' and 	Legajo = @pLegajo
	INSERT INTO suePersPuestos
	(
		Legajo,
		FechaDesde,
		FechaHasta,
		Puesto_Id,
		Usuario_Id
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		@pFechaHasta,
		dbo.FuncFKsuePuestos(@pPuesto_Id),
		@pUsuario_Id
	)
END 
end
GO

DROP PROCEDURE suePersPuestosDatos
GO
CREATE PROCEDURE suePersPuestosDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

SELECT suePersPuestos.Legajo, suePersPuestos.FechaDesde, suePersPuestos.FechaHasta,
	suePuestos.Puesto_Id, suePuestos.Descripcion as DescripcionPuesto, suePersPuestos.Usuario_Id
FROM suePersPuestos 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = suePersPuestos.Legajo)
left join suePuestos on suePuestos.suePuestos=suePersPuestos.Puesto_Id
WHERE (suePersonal.Legajo = @pLegajo)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersPuestosEliminar
GO
CREATE PROCEDURE suePersPuestosEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersPuestos 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
 RETURN @@Error 

GO

GO
