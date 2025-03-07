DROP PROCEDURE venCamionesGuardar
GO
CREATE PROCEDURE venCamionesGuardar
(
@pPatente_Id varchar(20),
@pPatente_Id_Nuevo varchar(20),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(35),
@pFormaEntrega_Id varchar(3) = NULL,
@pCargaMaxima qCantidadD8 = NULL,
@pTara qCantidadD8 = NULL,
@pMarca varchar(100) = NULL,
@pInspeccion qFecha = NULL,
@pEsAcoplado Sino,
@pInactivo Sino,
@pUsuario_Id int = NULL,
@pPosteado Sino,
@pNroPoliza VarChar(30) = NULL,
@pNombreAseg VarChar(50) = NULL,
@pConfVehicular VarChar(10) = NULL, 
@pModelo Int = NULL, 
@pTipoPermisoSCT VarChar(6) = NULL,
@pNroPermisoSCT VarChar(50) = NULL, 
@pPropArre_Id VarChar(15) = null,
@pAseguraMedAmb VarChar(50) = null,
@pPolizaMedAmbiente VarChar(30) = null,
@pAseguraCarga VarChar(50) = null,
@pPolizaCarga VarChar(30) = null,
@pPrimaSeguro Numeric(18,2) = null
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM venCamiones WHERE (Patente_Id = @pPatente_Id)))
BEGIN 
	UPDATE venCamiones
	SET		@lIdentidad = venCamiones,
		Patente_Id = @pPatente_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		FormaEntrega_Id = dbo.FuncFKvenFormaEntrega(@pFormaEntrega_Id),
		CargaMaxima = @pCargaMaxima,
		Tara = @pTara,
		Marca = @pMarca,
		Inspeccion = @pInspeccion,
		EsAcoplado = @pEsAcoplado,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado, 
		NroPoliza = @pNroPoliza ,
		NombreAseg = @pNombreAseg,
		ConfVehicular= @pConfVehicular, 
		Modelo = @pModelo , 
		TipoPermisoSCT = @pTipoPermisoSCT,
		NroPermisoSCT = @pNroPermisoSCT, 
		PropArre_Id = dbo.FuncFKvenPropietarioArrenda(@pPropArre_Id),
		AseguraMedAmb = @pAseguraMedAmb ,
		PolizaMedAmbiente = @pPolizaMedAmbiente,
		AseguraCarga = @pAseguraCarga,
		PolizaCarga = @pPolizaCarga,
		PrimaSeguro = @pPrimaSeguro 
	WHERE (Patente_Id = @pPatente_Id)
END 
ELSE 
BEGIN 
	INSERT INTO venCamiones
	(
		Patente_Id,
		Empresa_Id,
		Descripcion,
		FormaEntrega_Id,
		CargaMaxima,
		Tara,
		Marca,
		Inspeccion,
		EsAcoplado,
		Inactivo,
		Usuario_Id,
		Posteado,
		NroPoliza ,
		NombreAseg ,
		ConfVehicular, 
		Modelo ,
		TipoPermisoSCT,
		NroPermisoSCT,
		PropArre_Id ,
		AseguraMedAmb,
		PolizaMedAmbiente,
		AseguraCarga,
		PolizaCarga,
		PrimaSeguro
	)
	VALUES 
	(
		@pPatente_Id,
		@pEmpresa_Id,
		@pDescripcion,
		dbo.FuncFKvenFormaEntrega(@pFormaEntrega_Id),
		@pCargaMaxima,
		@pTara,
		@pMarca,
		@pInspeccion,
		@pEsAcoplado,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado,
		@pNroPoliza ,
		@pNombreAseg ,
		@pConfVehicular, 
		@pModelo , 
		@pTipoPermisoSCT,
		@pNroPermisoSCT,
		dbo.FuncFKvenPropietarioArrenda(@pPropArre_Id),
		@pAseguraMedAmb ,
		@pPolizaMedAmbiente,
		@pAseguraCarga,
		@pPolizaCarga,
		@pPrimaSeguro 

	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE venCamionesDatos
GO
CREATE PROCEDURE venCamionesDatos
(
@pPatente_Id varchar(20)
)
AS
SET NOCOUNT ON 

SELECT venCamiones.venCamiones, venCamiones.Patente_Id,  venCamiones.Empresa_Id,
	Cast( Case When venCamiones.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, venCamiones.Descripcion, 
	venFormaEntrega.FormaEntrega_Id, venFormaEntrega.RazonSocial,
	venCamiones.CargaMaxima, venCamiones.Tara, venCamiones.Marca, venCamiones.Inspeccion,
	venCamiones.EsAcoplado, venCamiones.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	venCamiones.Posteado,venCamiones.NroPoliza , venCamiones.NombreAseg , venCamiones.ConfVehicular,  venCamiones.Modelo , 
	venCamiones.TipoPermisoSCT, venCamiones.NroPermisoSCT, 
	venPropietarioArrenda.PropArre_Id, venPropietarioArrenda.Nombre, 
	AseguraMedAmb,PolizaMedAmbiente,AseguraCarga,PolizaCarga,PrimaSeguro 
FROM venCamiones 
LEFT JOIN venFormaEntrega  ON (venFormaEntrega.venFormaEntrega = venCamiones.FormaEntrega_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = venCamiones.Usuario_Id)
LEFT JOIN venPropietarioArrenda ON  venPropietarioArrenda.venPropietarioArrenda = venCamiones.PropArre_Id
WHERE (Patente_Id = @pPatente_Id)
 


  Declare @pidentity bigint= dbo.FuncFKvenCamiones(@pPatente_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'venCamiones'
 RETURN @@Error 

GO

DROP PROCEDURE venCamionesEliminar
GO
CREATE PROCEDURE venCamionesEliminar
(
@pPatente_Id varchar(20) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venCamiones 
WHERE (Patente_Id = @pPatente_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKvenCamiones
GO

CREATE FUNCTION FuncFKvenCamiones
(
@pPatente_Id varchar (20)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venCamiones FROM venCamiones WHERE 
	Patente_Id = @pPatente_Id
  RETURN @pIdentity
END


GO
