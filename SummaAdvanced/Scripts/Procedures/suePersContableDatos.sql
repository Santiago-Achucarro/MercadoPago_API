DROP PROCEDURE suePersContableDatosGuardar
GO
CREATE PROCEDURE suePersContableDatosGuardar
(
@pLegajo bigint,
@pFechaDesde qFechaHora,
@pCuenta_Id varchar(25),
@pCentro1_Id varchar(8),
@pCentro2_Id varchar(8),
@pPorcentaje qPorcentaje
)
AS
SET NOCOUNT ON 
set @pLegajo=(select genEntidades from suePersonal where Legajo=@pLegajo)
if (exists(select 1 from suePersContable where (Legajo = @pLegajo)  and FechaDesde=@pFechaDesde) and 
not exists (select 1 from suePersContableDatos where FechaDesde=@pFechaDesde and Legajo=@pLegajo and Centro1_Id=dbo.FuncFKconCentro1( @pCentro1_Id )and Centro2_Id=dbo.FuncFKconCentro2( @pCentro2_Id )and Cuenta_Id=dbo.FuncFKconCuentas(@pCuenta_Id)))
begin
	INSERT INTO suePersContableDatos
	(
		Legajo,
		FechaDesde,
		Cuenta_Id,
		Centro1_Id,
		Centro2_Id,
		Porcentaje
	)
	VALUES 
	(
		@pLegajo,
		@pFechaDesde,
		dbo.FuncFKconCuentas(@pCuenta_Id),
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id),
		@pPorcentaje
	)
	
END 
update suePersContableDatos set Porcentaje=@pPorcentaje where FechaDesde=@pFechaDesde and Legajo=@pLegajo and Centro1_Id=dbo.FuncFKconCentro1( @pCentro1_Id )and Centro2_Id=dbo.FuncFKconCentro2( @pCentro2_Id )and Cuenta_Id=dbo.FuncFKconCuentas(@pCuenta_Id)
GO

DROP PROCEDURE suePersContableDatosDatos
GO
CREATE PROCEDURE suePersContableDatosDatos
(
@pLegajo bigint,
@pFechaDesde datetime=NULL
)
AS
SET NOCOUNT ON 

SELECT suePersContableDatos.Legajo, suePersContableDatos.FechaDesde, conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas, conCentro1.Centro1_Id,
	conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, suePersContableDatos.Porcentaje, 
		Cast(0 as int) Renglon
FROM suePersContableDatos 
INNER JOIN conCentro1  ON (conCentro1.conCentro1 = suePersContableDatos.Centro1_Id)
inner join conCentro2 on conCentro2.conCentro2= suePersContableDatos.Centro2_Id
left join conCuentas on conCuentas.conCuentas =suePersContableDatos.Cuenta_Id
inner join suePersonal on suePersonal.genEntidades=suePersContableDatos.Legajo
WHERE (suePersonal.Legajo = @pLegajo and suePersContableDatos.FechaDesde=isnull(@pFechaDesde, suePersContableDatos.FechaDesde))
 
 RETURN @@Error 

GO

DROP PROCEDURE suePersContableDatosEliminar
GO
CREATE PROCEDURE suePersContableDatosEliminar
(
@pLegajo bigint,
@pFechaDesde qFechaHora = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM suePersContableDatos 
WHERE (Legajo = dbo.FuncFKsuePersonal(@pLegajo))
AND (FechaDesde = ISNULL(@pFechaDesde,FechaDesde))
 
 RETURN @@Error 

GO

GO
