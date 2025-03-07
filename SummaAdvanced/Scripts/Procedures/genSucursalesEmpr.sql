DROP PROCEDURE genSucursalesEmprGuardar
GO
CREATE PROCEDURE genSucursalesEmprGuardar
(
@pSucursal char(4),
@pSucursal_Nuevo char(4),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(50),
@pProvincia_Id varchar(5) = NULL,
@pPais_Id smallint = NULL,
@pDepositoVentas varchar(15) = NULL,
@pDepositoPedidos varchar(15) = NULL,
@pDepositoOC varchar(15) = NULL,
@pFechaCaja datetime,
@pVaConCentral bit,
@pFacturaElectronica bit,
@pUsaWS bit,
@pTipoFE varChar(5) = null,
@pDireccion varchar(120) = NULL,
@pLocalidad varchar(60) = NULL,
@pTelefono varchar(60) = NULL,
@pSucursalRemito char(4) = Null,
@pSucursalTesoreria char(4) = Null,
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit, 
@pCodigoPostal VarChar(10),
@pSerie varchar(25)=null, 
@pRegPatronal VarChar(20)= NULL,
@pcodColonia VarChar(4)= NULL,
@pcodLocalidad VarChar(4)= NULL,
@pcodMunicipio VarChar(3)= NULL
)
AS
SET NOCOUNT ON 

DECLARE @lIdentidad int

IF (EXISTS (SELECT 1 FROM genSucursalesEmpr WHERE (Sucursal = @pSucursal)))
BEGIN 
	UPDATE genSucursalesEmpr
	SET		@lIdentidad = genSucursalesEmpr,
		Sucursal = @pSucursal_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Provincia_Id = dbo.FuncFKgenProvincias(@pProvincia_Id),
		Pais_Id = dbo.FuncFKgenPaises(@pPais_Id),
		DepositoVentas = dbo.FuncFKstkDepositos(@pDepositoVentas),
		DepositoPedidos = dbo.FuncFKstkDepositos(@pDepositoPedidos),
		DepositoOC = dbo.FuncFKstkDepositos(@pDepositoOC),
		FechaCaja = @pFechaCaja,
		VaConCentral = @pVaConCentral,
		FacturaElectronica = @pFacturaElectronica,
		UsaWS = @pUsaWS,
		TipoFE = @pTipoFE,
		Direccion = @pDireccion,
		Localidad = @pLocalidad,
		Telefono = @pTelefono,
		SucursalRemito = dbo.FuncFKgenSucursalesEmpr(@pSucursalRemito),
		SucursalTesoreria = dbo.FuncFKgenSucursalesEmpr(@pSucursalTesoreria),
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado, 
		CodigoPostal = @pCodigoPostal,
		Serie=@pSerie, 
		RegPatronal = @pRegPatronal, 
		codColonia = @pcodColonia,
		codLocalidad = @pcodLocalidad,
		codMunicipio = @pcodMunicipio
	WHERE (Sucursal = @pSucursal)
END 
ELSE 
BEGIN 
	INSERT INTO genSucursalesEmpr
	(
		Sucursal,
		Empresa_Id,
		Descripcion,
		Provincia_Id,
		Pais_Id,
		DepositoVentas,
		DepositoPedidos,
		DepositoOC,
		FechaCaja,
		VaConCentral,
		FacturaElectronica,
		UsaWS,
		TipoFE,
		Direccion,
		Localidad,
		Telefono,
		SucursalRemito,
		SucursalTesoreria,
		Inactivo,
		Usuario_Id,
		Posteado, 
		CodigoPostal,
		Serie,
		RegPatronal,
		codColonia ,
		codLocalidad ,
		codMunicipio 
	)
	VALUES 
	(
		@pSucursal,
		@pEmpresa_Id,
		@pDescripcion,
		dbo.FuncFKgenProvincias(@pProvincia_Id),
		dbo.FuncFKgenPaises(@pPais_Id),
		dbo.FuncFKstkDepositos(@pDepositoVentas),
		dbo.FuncFKstkDepositos(@pDepositoPedidos),
		dbo.FuncFKstkDepositos(@pDepositoOC),
		@pFechaCaja,
		@pVaConCentral,
		@pFacturaElectronica,
		@pUsaWS,
		@pTipoFE,
		@pDireccion,
		@pLocalidad,
		@pTelefono,
		dbo.FuncFKgenSucursalesEmpr(@pSucursalRemito),
		dbo.FuncFKgenSucursalesEmpr(@pSucursalTesoreria),
		@pInactivo,
		@pUsuario_Id,
		@pPosteado, 
		@pCodigoPostal,
		@pSerie, 
		@pRegPatronal, 
		@pcodColonia ,
		@pcodLocalidad ,
		@pcodMunicipio 
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO


DROP PROCEDURE genSucursalesEmprDatos
GO
CREATE PROCEDURE genSucursalesEmprDatos
(
@pSucursal char(4)
)
AS
SET NOCOUNT ON 

SELECT genSucursalesEmpr.genSucursalesEmpr, genSucursalesEmpr.Sucursal,  
	genSucursalesEmpr.Empresa_Id, 
	Cast( Case When genSucursalesEmpr.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	genSucursalesEmpr.Descripcion, 
	genProvincias.Provincia_Id, genProvincias.Descripcion as DescripcionProvincias, genPaises.Pais_Id,
	genPaises.Descripcion as DescripcionPaises, 
	stkDepositos.Deposito_Id as DepositoVentas, stkDepositos.Descripcion as DescripcionDepositoVentas, 
	stkDepositos2.Deposito_Id as DepositoPedidos, stkDepositos2.Descripcion as DescripcionDepositoPedidos, 
	stkDepositos3.Deposito_Id as DepositoOC, stkDepositos3.Descripcion as DescripcionDepositoOC, 
	genSucursalesEmpr.FechaCaja, genSucursalesEmpr.VaConCentral, genSucursalesEmpr.FacturaElectronica, 
	genSucursalesEmpr.UsaWS, genSucursalesEmpr.TipoFE, genWSFactElec.Descripcion DescripcionTipoFE,
	genSucursalesEmpr.Direccion,
	genSucursalesEmpr.Localidad, genSucursalesEmpr.Telefono, genSucRemito.Sucursal SucursalRemito,
	genSucTesoreria.Sucursal SucursalTesoreria, genSucursalesEmpr.Inactivo, 
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
	genSucursalesEmpr.Posteado, genSucursalesEmpr.CodigoPostal,genSucursalesEmpr.Serie, 
	genSucursalesEmpr.RegPatronal, 
	genSucursalesEmpr.codColonia, genColonias.NombreAsentamiento as DescripcioncodColonia,
	genSucursalesEmpr.codLocalidad, genlocalidades.Descripcion as DescripcioncodLocalidad,
	genSucursalesEmpr.codMunicipio, genMunicipios.Descripcion as DescripcioncodMunicipio
FROM genSucursalesEmpr 
LEFT JOIN genProvincias  ON (genProvincias.genProvincias = genSucursalesEmpr.Provincia_Id)
LEFT JOIN genPaises  ON (genPaises.genPaises = genSucursalesEmpr.Pais_Id)
LEFT JOIN stkDepositos  ON (stkDepositos.stkDepositos = genSucursalesEmpr.DepositoVentas)
LEFT JOIN stkDepositos stkDepositos2 ON (stkDepositos2.stkDepositos = genSucursalesEmpr.DepositoPedidos)
LEFT JOIN stkDepositos stkDepositos3 ON (stkDepositos3.stkDepositos = genSucursalesEmpr.DepositoOC)
Left Join genWSFactElec On genWSFactElec.TipoFE = genSucursalesEmpr.TipoFE
Left Join genSucursalesEmpr genSucRemito On genSucRemito.genSucursalesEmpr = genSucursalesEmpr.SucursalRemito
Left Join genSucursalesEmpr genSucTesoreria On genSucTesoreria.genSucursalesEmpr = genSucursalesEmpr.SucursalTesoreria
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = genSucursalesEmpr.Usuario_Id)
LEFT JOIN genColonias ON  genColonias.c_Colonia = genSucursalesEmpr.codColonia and 
						 genColonias.c_CodigoPostal = 	genSucursalesEmpr.CodigoPostal
LEFT JOIN genlocalidades ON  genlocalidades.c_Localidad = genSucursalesEmpr.codLocalidad and 
						 genlocalidades.c_Estado = 	genProvincias.CodFiscal
LEFT JOIN genMunicipios ON  genMunicipios.c_Municipio = genSucursalesEmpr.codMunicipio and 
						 genMunicipios.c_Estado = 	genProvincias.CodFiscal

WHERE (genSucursalesEmpr.Sucursal = @pSucursal)
 


 Declare @pidentity bigint= dbo.FuncFKgenSucursalesEmpr(@pSucursal)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'genSucursalesEmpr'
 RETURN @@Error 

GO


Drop FUNCTION FuncFKgenSucursalesEmpr 
Go
CREATE FUNCTION FuncFKgenSucursalesEmpr  
(  
@pSucursal char (4)  
)  
RETURNS int  
  
AS  
BEGIN  
  DECLARE @pIdentity int  
  SELECT @pIdentity = genSucursalesEmpr FROM genSucursalesEmpr WHERE   
 Sucursal = @pSucursal  
  RETURN @pIdentity  
END  
Go



DROP procedure genSucursalesSetFechaCaja
Go
CREATE procedure genSucursalesSetFechaCaja
(
@pEmpresa_Id int,
@pSucursal char(4),
@pFechaCaja DateTime,
@pEsSucuCentral Sino
)
As
If @pEsSucuCentral = 1
	UPDATE genSucursalesEmpr Set FechaCaja = @pFechaCaja Where Sucursal = @pSucursal Or vaConCentral = 1
Else
	UPDATE genSucursalesEmpr Set FechaCaja = @pFechaCaja Where Sucursal = @pSucursal
GO

DROP PROCEDURE genSucursalesEmprEliminar
GO
CREATE PROCEDURE genSucursalesEmprEliminar
(
@pSucursal char(4)
)
AS
delete from genSucursalesEmpr where Sucursal = @pSucursal
GO
