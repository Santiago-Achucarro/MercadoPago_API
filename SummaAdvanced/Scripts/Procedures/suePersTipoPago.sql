DROP PROCEDURE suePersTipoPagoGuardar
GO
CREATE PROCEDURE suePersTipoPagoGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pFechaHasta qFechaHora,
@pTipoPago_Id varchar(5) = NULL,
@pUsuario_Id int = NULL
)
AS
SET NOCOUNT ON 
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
IF (EXISTS (SELECT 1 FROM suePersTipoPago WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)))
BEGIN 
	UPDATE suePersTipoPago
	SET		FechaHasta = isnull((select min(Catego2.FechaDesde) 
		from suePersTipoPago Catego2 
		where 
		Catego2.Legajo = suePersTipoPago.Legajo and 
		Catego2.FechaDesde>suePersTipoPago.FechaDesde),@pFechaHasta),
		TipoPago_Id =dbo.FuncFKsueTipoPago( @pTipoPago_Id),
		Usuario_Id = @pUsuario_Id
	WHERE (Legajo = @pLegajo) AND (FechaDesde = @pFechaDesde)
END 
ELSE 
BEGIN 
if (not exists(select TipoPago_Id from suePersTipoPago where (Legajo = @pLegajo) AND (FechaHasta = '29990101')and TipoPago_Id= dbo.FuncFKsueTipoPago(@pTipoPago_Id)))
begin
if not exists (select 1 from suePersTipoPago where Legajo=@pLegajo)
BEGIN
set @pFechaDesde =(select FechaIngreso from suePersonal where genEntidades=@pLegajo)
end
update suePersTipoPago set FechaHasta=DATEADD(dd,-1, @pFechaDesde) where FechaHasta='29990101' and 	Legajo = @pLegajo
	INSERT INTO suePersTipoPago
	(
		Legajo,
		FechaDesde,
		FechaHasta,
		TipoPago_Id,
		Usuario_Id
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		@pFechaHasta,
		dbo.FuncFKsueTipoPago(@pTipoPago_Id),
		@pUsuario_Id
	)
END 
end
GO

DROP PROCEDURE suePersTipoPagoDatos
GO
CREATE PROCEDURE suePersTipoPagoDatos
(
@pLegajo bigint
)
AS
SET NOCOUNT ON 

SELECT suePersTipoPago.Legajo, suePersonal.Nombres as DescripcionPersonal, suePersTipoPago.FechaDesde, suePersTipoPago.FechaHasta,
	sueTipoPago.TipoPago_Id, sueTipoPago.Descripcion, suePersTipoPago.Usuario_Id
FROM suePersTipoPago 
INNER JOIN suePersonal  ON (suePersonal.genEntidades = suePersTipoPago.Legajo)
inner join sueTipoPago on suePersTipoPago.TipoPago_Id= sueTipoPago.sueTipoPago
WHERE (suePersonal.Legajo = @pLegajo)
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersTipoPagoEliminar
GO
CREATE PROCEDURE suePersTipoPagoEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersTipoPago 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
AND (FechaDesde = ISNULL(@pFechaDesde, FechaDesde))
 
 RETURN @@Error 

GO

GO
