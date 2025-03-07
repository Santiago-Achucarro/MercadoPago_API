DROP PROCEDURE venPropietarioArrendaGuardar
GO
CREATE PROCEDURE venPropietarioArrendaGuardar
(
@pPropArre_Id varchar(15),
@pPropArre_Id_Nueva varchar(15),
@pEmpresa_Id int = NULL,
@pPropArre int,
@pRfc varchar(14),
@pNombre varchar(254),
@pNumRegIdTrib varchar(40),
@pResidenciaFiscal smallint,
@pCalle varchar(100),
@pNumeroExterior varchar(30) = NULL,
@pNumerointerior varchar(30) = NULL,
@pColonia varchar(120) = NULL,
@pLocalidad varchar(120) = NULL,
@pReferencia varchar(100) = NULL,
@pMunicipio varchar(120) = NULL,
@pEstado varchar(30) = NULL,
@pPais smallint = NULL,
@pCodigoPostal varchar(20) = NULL,
@pUsuario_Id int
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM venPropietarioArrenda WHERE  PropArre_Id = @pPropArre_Id))
BEGIN 
	UPDATE venPropietarioArrenda
	SET		@lIdentidad = venPropietarioArrenda,
		PropArre_Id = @pPropArre_Id_Nueva,
		Empresa_Id = @pEmpresa_Id,
		PropArre = @pPropArre,
		Rfc = @pRfc,
		Nombre = @pNombre,
		NumRegIdTrib = @pNumRegIdTrib,
		ResidenciaFiscal = dbo.FuncFKgenPaises(@pResidenciaFiscal),
		Calle = @pCalle,
		NumeroExterior = @pNumeroExterior,
		Numerointerior = @pNumerointerior,
		Colonia = @pColonia,
		Localidad = @pLocalidad,
		Referencia = @pReferencia,
		Municipio = @pMunicipio,
		Estado = @pEstado,
		Pais = dbo.FuncFKgenPaises(@pPais),
		CodigoPostal = @pCodigoPostal,
		Usuario_Id = @pUsuario_Id
	WHERE 
		PropArre_Id = @pPropArre_Id
END 
ELSE 
BEGIN 
	INSERT INTO venPropietarioArrenda
	(
		PropArre_Id,
		Empresa_Id,
		PropArre,
		Rfc,
		Nombre,
		NumRegIdTrib,
		ResidenciaFiscal,
		Calle,
		NumeroExterior,
		Numerointerior,
		Colonia,
		Localidad,
		Referencia,
		Municipio,
		Estado,
		Pais,
		CodigoPostal,
		Usuario_Id
	)
	VALUES 
	(
		@pPropArre_Id,
		@pEmpresa_Id,
		@pPropArre,
		@pRfc,
		@pNombre,
		@pNumRegIdTrib,
		dbo.FuncFKgenPaises(@pResidenciaFiscal),
		@pCalle,
		@pNumeroExterior,
		@pNumerointerior,
		@pColonia,
		@pLocalidad,
		@pReferencia,
		@pMunicipio,
		@pEstado,
		dbo.FuncFKgenPaises(@pPais),
		@pCodigoPostal,
		@pUsuario_Id
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE venPropietarioArrendaDatos
GO
CREATE PROCEDURE venPropietarioArrendaDatos
(
	@pPropArre_Id VarChar(15)
)
AS
SET NOCOUNT ON 

SELECT venPropietarioArrenda.venPropietarioArrenda, venPropietarioArrenda.PropArre_Id,  venPropietarioArrenda.Empresa_Id,
	Cast( Case When venPropietarioArrenda.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, venPropietarioArrenda.PropArre, 
	venPropietarioArrenda.Rfc, venPropietarioArrenda.Nombre,
	venPropietarioArrenda.NumRegIdTrib, genPaises.Pais_Id ResidenciaFiscal, genPaises.Descripcion as DescripcionRecidenciaFiscal, venPropietarioArrenda.Calle,
	venPropietarioArrenda.NumeroExterior, venPropietarioArrenda.Numerointerior, venPropietarioArrenda.Colonia, venPropietarioArrenda.Localidad,
	venPropietarioArrenda.Referencia, venPropietarioArrenda.Municipio, venPropietarioArrenda.Estado, genPaises2.Pais_Id,
	genPaises2.Descripcion as DescripcionPaises, venPropietarioArrenda.CodigoPostal, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM venPropietarioArrenda 
INNER JOIN genPaises  ON (genPaises.genPaises = venPropietarioArrenda.ResidenciaFiscal)
INNER JOIN genPaises genPaises2 ON (genPaises2.genPaises = venPropietarioArrenda.Pais)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = venPropietarioArrenda.Usuario_Id)
WHERE  
PropArre_Id = @pPropArre_Id

 Declare @pidentity bigint= dbo.FuncFKvenPropietarioArrenda(@pPropArre_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'venPropietarioArrenda'
RETURN @@Error 

GO

DROP PROCEDURE venPropietarioArrendaEliminar
GO
CREATE PROCEDURE venPropietarioArrendaEliminar
(
	@pPropArre_Id VarChar(15)
)
AS
SET NOCOUNT ON 

DELETE FROM venPropietarioArrenda 
WHERE  
PropArre_Id = @pPropArre_Id

RETURN @@Error 

GO

DROP FUNCTION FuncFKvenPropietarioArrenda
GO

CREATE FUNCTION FuncFKvenPropietarioArrenda
(
	@pPropArre_Id varchar (15)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venPropietarioArrenda FROM venPropietarioArrenda WHERE 
	PropArre_Id = @pPropArre_Id
  RETURN @pIdentity
END


GO
