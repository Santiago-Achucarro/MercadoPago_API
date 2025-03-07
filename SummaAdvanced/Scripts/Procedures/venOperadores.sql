DROP PROCEDURE venOperadoresGuardar
GO
CREATE PROCEDURE venOperadoresGuardar
(
@pOperador_Id varchar(15),
@pOperador_Id_Nueva varchar(15),
@pEmpresa_Id int = NULL,
@pInactivo Bit, 
@pPosteado Bit, 
@pRfcOperador varchar(14),
@pNumLicencia varchar(16),
@pNombreOperador varchar(254),
@pNumRegIdTribOperador varchar(40),
@pResidenciaFiscalOperador smallint,
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
IF (EXISTS (SELECT 1 FROM venOperadores WHERE Operador_Id = @pOperador_Id))
BEGIN 
	UPDATE venOperadores
	SET		@lIdentidad = venOperadores,
		Operador_Id = @pOperador_Id_Nueva,
		Empresa_Id = @pEmpresa_Id,
		RfcOperador = @pRfcOperador,
		NumLicencia = @pNumLicencia,
		NombreOperador = @pNombreOperador,
		NumRegIdTribOperador = @pNumRegIdTribOperador,
		ResidenciaFiscalOperador = dbo.FuncFKgenPaises(@pResidenciaFiscalOperador),
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
		Usuario_Id = @pUsuario_Id, 
		Inactivo = @pInactivo, 
		Posteado = @pPosteado
	WHERE 
		Operador_Id = @pOperador_Id
END 
ELSE 
BEGIN 
	INSERT INTO venOperadores
	(
		Operador_Id,
		Empresa_Id,
		RfcOperador,
		NumLicencia,
		NombreOperador,
		NumRegIdTribOperador,
		ResidenciaFiscalOperador,
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
		Usuario_Id, 
		Inactivo, 
		Posteado
	)
	VALUES 
	(
		@pOperador_Id_Nueva,
		@pEmpresa_Id,
		@pRfcOperador,
		@pNumLicencia,
		@pNombreOperador,
		@pNumRegIdTribOperador,
		dbo.FuncFKgenPaises(@pResidenciaFiscalOperador),
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
		@pUsuario_Id, 
		@pInactivo, 
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE venOperadoresDatos
GO
CREATE PROCEDURE venOperadoresDatos
(
	@pOperador_Id varchar(15)
)
AS
SET NOCOUNT ON 

SELECT venOperadores.venOperadores, venOperadores.Operador_Id,  venOperadores.Empresa_Id,
	Cast( Case When venOperadores.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, 
	venOperadores.Inactivo, venOperadores.Posteado,
	venOperadores.RfcOperador, venOperadores.NumLicencia, venOperadores.NombreOperador,
	venOperadores.NumRegIdTribOperador, genPaises.Pais_Id ResidenciaFiscal, genPaises.Descripcion as DescripcionResidenciaFiscal, venOperadores.Calle,
	venOperadores.NumeroExterior, venOperadores.Numerointerior, venOperadores.Colonia, venOperadores.Localidad,
	venOperadores.Referencia, venOperadores.Municipio, venOperadores.Estado, genPaises2.Pais_Id,
	genPaises2.Descripcion as DescripcionPaises, venOperadores.CodigoPostal, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM venOperadores 
INNER JOIN genPaises  ON (genPaises.genPaises = venOperadores.ResidenciaFiscalOperador)
INNER JOIN genPaises genPaises2 ON (genPaises2.genPaises = venOperadores.Pais)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = venOperadores.Usuario_Id)
WHERE  
	Operador_Id = @pOperador_Id

 Declare @pidentity bigint= dbo.FuncFKvenOperadores(@pOperador_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'venOperadores'
RETURN @@Error 

GO

DROP PROCEDURE venOperadoresEliminar
GO
CREATE PROCEDURE venOperadoresEliminar
(
	@pOperador_Id varchar(15)
)
AS
SET NOCOUNT ON 

DELETE FROM venOperadores 
WHERE  Operador_Id = @pOperador_Id
 RETURN @@Error 

GO

DROP FUNCTION FuncFKvenOperadores
GO

CREATE FUNCTION FuncFKvenOperadores
(
@pOperador_Id varchar (15)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venOperadores FROM venOperadores WHERE 
	Operador_Id = @pOperador_Id
  RETURN @pIdentity
END


GO
