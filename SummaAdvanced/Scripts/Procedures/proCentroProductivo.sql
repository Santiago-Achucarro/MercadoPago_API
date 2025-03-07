DROP PROCEDURE proCentroProductivoGuardar
GO
CREATE PROCEDURE proCentroProductivoGuardar
(
@pCtroProd_Id varchar(8),
@pCtroProd_Id_Nuevo varchar(8),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(35),
@pCentro1_Id varchar(8) = NULL,
@pCentro2_Id varchar(8) = NULL,
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int = NULL, 
@pCtaProdProceso VarChar(25) = NULL
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM proCentroProductivo WHERE (CtroProd_Id = @pCtroProd_Id)))
BEGIN 
	UPDATE proCentroProductivo
	SET		@lIdentidad = proCentroProductivo,
		CtroProd_Id = @pCtroProd_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id),
		Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id),
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id, 
		CtaProdProceso = dbo.FuncFKconCuentas(@pCtaProdProceso)
	WHERE (CtroProd_Id = @pCtroProd_Id)
END 
ELSE 
BEGIN 
	INSERT INTO proCentroProductivo
	(
		CtroProd_Id,
		Empresa_Id,
		Descripcion,
		Centro1_Id,
		Centro2_Id,
		Inactivo,
		Posteado,
		Usuario_Id,
		CtaProdProceso
	)
	VALUES 
	(
		@pCtroProd_Id,
		@pEmpresa_Id,
		@pDescripcion,
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id),
		@pInactivo,
		@pPosteado,
		@pUsuario_Id,
		dbo.FuncFKconCuentas(@pCtaProdProceso)
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE proCentroProductivoDatos
GO
CREATE PROCEDURE proCentroProductivoDatos
(
@pCtroProd_Id varchar(8)
)
AS
SET NOCOUNT ON 

SELECT proCentroProductivo.proCentroProductivo, proCentroProductivo.CtroProd_Id, proCentroProductivo.Empresa_Id,
	Cast( Case When proCentroProductivo.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, proCentroProductivo.Descripcion, conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, proCentroProductivo.Inactivo, proCentroProductivo.Posteado, proCentroProductivo.Usuario_Id,
	conCuentas.Cuenta_Id CtaProdProceso , conCuentas.Descripcion as DescripcionCtaProdProceso
FROM proCentroProductivo 
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = proCentroProductivo.Centro1_Id)
left join conCentro2 on (conCentro2.conCentro2 = proCentroProductivo.Centro2_Id)
Left join conCuentas ON CtaProdProceso = conCuentas.conCuentas
WHERE (CtroProd_Id = @pCtroProd_Id)
 


  Declare @pidentity bigint= dbo.FuncFKproCentroProductivo(@pCtroProd_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'proCentroProductivo'
 RETURN @@Error 

GO

DROP PROCEDURE proCentroProductivoEliminar
GO
CREATE PROCEDURE proCentroProductivoEliminar
(
@pCtroProd_Id varchar(8) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM proCentroProductivo 
WHERE (CtroProd_Id = @pCtroProd_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKproCentroProductivo
GO

CREATE FUNCTION FuncFKproCentroProductivo
(
@pCtroProd_Id varchar (8)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = proCentroProductivo FROM proCentroProductivo WHERE 
	CtroProd_Id = @pCtroProd_Id
  RETURN @pIdentity
END


GO
