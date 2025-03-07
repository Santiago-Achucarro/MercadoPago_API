-- AJ SE  AGREGO UsaUbicacion EN V2
-- stkDepositosDatos 'a'
DROP PROCEDURE stkDepositosGuardar
GO
CREATE PROCEDURE stkDepositosGuardar
(
@pDeposito_id varchar(15),
@pDeposito_id_Nuevo varchar(15),
@pEmpresa_Id int = NULL,
@pSucursal Sucursal = NULL,
@pDescripcion varchar(35),
@pDireccion varchar(35),
@pGrupoUsuarios varchar(25) = NULL,
@pCentro1_Id varchar(8) = NULL,
@pCentro2_Id varchar(8) = NULL,
@pAdmiteVentas Sino,
@pConsignacion Sino,
@pCuentaDeudCons varchar(25) = NULL,
@pCuentaAcredCons varchar(25) = NULL,
@pCtaBienesCambio varchar(25) = NULL,
@pCtaMercEnCons varchar(25) = NULL,
@pDepositoReal varchar(15) = NULL,
@pconsCompra_Venta Sino,
@pLocalidad varchar(35) = NULL,
@pCodigoPostal CodigoPostal = NULL,
@pProvincia_Id varchar(5) = NULL,
@pInactivo Sino,
@pPosteado Sino,
@pUsuario_Id int, 
@pUsaUbicacion SiNo, 
@pc_ColoniaEntr VarChar(4) = NULL,
@pc_LocalidadEntr VarChar(4) = NULL,
@pc_MunicipioEntr VarChar(3) = NULL

)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM stkDepositos WHERE (Deposito_id = @pDeposito_id)))
BEGIN 
	UPDATE stkDepositos
	SET		@lIdentidad = stkDepositos,
		Deposito_id = @pDeposito_id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Sucursal = dbo.FuncFKgenSucursalesEmpr(@pSucursal),
		Descripcion = @pDescripcion,
		Direccion = @pDireccion,
		GrupoUsuarios = dbo.FuncFKgenUsuarios(@pGrupoUsuarios),
		Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id),
		Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id),
		AdmiteVentas = @pAdmiteVentas,
		Consignacion = @pConsignacion,
		CuentaDeudCons = dbo.FuncFKconCuentas(@pCuentaDeudCons),
		CuentaAcredCons = dbo.FuncFKconCuentas(@pCuentaAcredCons),
		CtaBienesCambio = dbo.FuncFKconCuentas(@pCtaBienesCambio),
		CtaMercEnCons = dbo.FuncFKconCuentas(@pCtaMercEnCons),
		DepositoReal = dbo.FuncFKstkDepositos(@pDepositoReal),
		consCompra_Venta = @pconsCompra_Venta,
		Localidad = @pLocalidad,
		CodigoPostal = @pCodigoPostal,
		Provincia_Id = dbo.FuncFKgenProvincias(@pProvincia_Id),
		Inactivo = @pInactivo,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id, 
		UsaUbicacion = @pUsaUbicacion, 
		c_ColoniaEntr = @pc_ColoniaEntr,
		c_LocalidadEntr = @pc_LocalidadEntr,
		c_MunicipioEntr =  @pc_MunicipioEntr
	WHERE (Deposito_id = @pDeposito_id)
END 
ELSE 
BEGIN 
	INSERT INTO stkDepositos
	(
		Deposito_id,
		Empresa_Id,
		Sucursal,
		Descripcion,
		Direccion,
		GrupoUsuarios,
		Centro1_Id,
		Centro2_Id,
		AdmiteVentas,
		Consignacion,
		CuentaDeudCons,
		CuentaAcredCons,
		CtaBienesCambio,
		CtaMercEnCons,
		DepositoReal,
		consCompra_Venta,
		Localidad,
		CodigoPostal,
		Provincia_Id,
		Inactivo,
		Posteado,
		Usuario_Id, 
		UsaUbicacion, 
		c_ColoniaEntr,
		c_LocalidadEntr,
		c_MunicipioEntr

	)
	VALUES 
	(
		@pDeposito_id,
		@pEmpresa_Id,
		dbo.FuncFKgenSucursalesEmpr(@pSucursal),
		@pDescripcion,
		@pDireccion,
		dbo.FuncFKgenUsuarios(@pGrupoUsuarios),
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id),
		@pAdmiteVentas,
		@pConsignacion,
		dbo.FuncFKconCuentas(@pCuentaDeudCons),
		dbo.FuncFKconCuentas(@pCuentaAcredCons),
		dbo.FuncFKconCuentas(@pCtaBienesCambio),
		dbo.FuncFKconCuentas(@pCtaMercEnCons),
		dbo.FuncFKstkDepositos(@pDepositoReal),
		@pconsCompra_Venta,
		@pLocalidad,
		@pCodigoPostal,
		dbo.FuncFKgenProvincias(@pProvincia_Id),
		@pInactivo,
		@pPosteado,
		@pUsuario_Id, 
		@pUsaUbicacion, 
		@pc_ColoniaEntr,
		@pc_LocalidadEntr,
		@pc_MunicipioEntr
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE stkDepositosDatos
GO
CREATE PROCEDURE stkDepositosDatos
(
@pDeposito_id varchar(15)
)
AS
SET NOCOUNT ON 

SELECT stkDepositos.stkDepositos, stkDepositos.Deposito_Id, stkDepositos.Empresa_Id,
	dbo.PTodasEmpresas(stkDepositos.Empresa_Id) as PTodasEmpresas, 
	 genSucursalesEmpr.Sucursal,
	genSucursalesEmpr.Descripcion as DescripcionSucursalesEmpr, stkDepositos.Descripcion, stkDepositos.Direccion, 
	genUsuarios.Usuario_Id as GrupoUsuarios, genUsuarios.Apellido_y_Nombres as DescripcionGrupoUsuarios, 
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1,
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2, stkDepositos.AdmiteVentas, stkDepositos.Consignacion,
	CuentaDeudCons.Cuenta_Id as CuentaDeudCons, CuentaDeudCons.Descripcion as DescripcionCuentaDeudCons, 
	CuentaAcredCons.Cuenta_Id as CuentaAcredCons, CuentaAcredCons.Descripcion as DescripcionCuentaAcredCons,
	CtaBienesCambio.Cuenta_Id as CtaBienesCambio, CtaBienesCambio.Descripcion as DescripcionCtaBienesCambio, 
	CtaMercEnCons.Cuenta_Id as CtaMercEnCons, CtaMercEnCons.Descripcion as DescripcionCtaMercEnCons,
	DepositoReal.Deposito_id as DepositoReal, 
	stkDepositos.Descripcion as DescripcionDepositoReal, 
	stkDepositos.consCompra_Venta,
	stkDepositos.Localidad, stkDepositos.CodigoPostal, 
	genProvincias.Provincia_Id, 	genProvincias.Descripcion as DescripcionProvincias, 
	stkDepositos.Inactivo, stkDepositos.Posteado,
	genUsuarios2.Usuario_Id, genUsuarios2.Apellido_y_Nombres as DescripcionUsuario, 
	stkDepositos.UsaUbicacion, 	stkDepositos.c_ColoniaEntr, stkDepositos.c_LocalidadEntr,
		stkDepositos.c_MunicipioEntr
FROM stkDepositos 
LEFT JOIN genSucursalesEmpr  ON (genSucursalesEmpr.genSucursalesEmpr = stkDepositos.Sucursal)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = stkDepositos.GrupoUsuarios)
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = stkDepositos.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = stkDepositos.Centro2_Id)
LEFT JOIN conCuentas  as CuentaDeudCons ON (CuentaDeudCons.conCuentas = stkDepositos.CuentaDeudCons)
LEFT JOIN conCuentas CuentaAcredCons ON (CuentaAcredCons.conCuentas = stkDepositos.CuentaAcredCons)
LEFT JOIN conCuentas CtaBienesCambio ON (CtaBienesCambio.conCuentas = stkDepositos.CtaBienesCambio)
LEFT JOIN conCuentas CtaMercEnCons ON (CtaMercEnCons.conCuentas = stkDepositos.CtaMercEnCons)
LEFT JOIN stkDepositos  as DepositoReal ON (DepositoReal.stkDepositos = stkDepositos.DepositoReal)
LEFT JOIN genProvincias  ON (genProvincias.genProvincias = stkDepositos.Provincia_Id)
INNER JOIN genUsuarios genUsuarios2 ON (genUsuarios2.genUsuarios = stkDepositos.Usuario_Id)
WHERE (stkDepositos.Deposito_id = @pDeposito_id)
 
 Declare @pidentity bigint= dbo.FuncFKstkDepositos(@pDeposito_id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'stkDepositos' 
 
 RETURN @@Error 

GO


-- stkTieneExistenciaDepo '1'
DROP PROCEDURE stkTieneExistenciaDepo
GO
CREATE PROCEDURE stkTieneExistenciaDepo
(
@pDeposito_Id VarChar(15) 
)
AS
SET NOCOUNT ON 

SELECT COUNT(1) as Cantidad
FROM stkExistencia 
INNER JOIN stkProductos  ON (stkProductos.stkProductos = stkExistencia.Producto_Id)
INNER JOIN stkDepositos  ON (stkDepositos.stkDepositos = stkExistencia.Deposito_Id)
WHERE 
stkDepositos.Deposito_Id = @pDeposito_Id and 
stkExistencia.Cantidad <> 0
 
RETURN @@Error 

GO


DROP PROCEDURE stkDepositosEliminar
GO
CREATE PROCEDURE stkDepositosEliminar
(
@pDeposito_id varchar(15) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkDepositos 
WHERE (Deposito_id = @pDeposito_id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKstkDepositos
GO

CREATE FUNCTION FuncFKstkDepositos
(
@pDeposito_id varchar (15)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = stkDepositos FROM stkDepositos WHERE 
	Deposito_id = @pDeposito_id 
  RETURN @pIdentity
END


GO
