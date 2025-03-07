

-- comProveedoresDatos 'ABB'
DROP PROCEDURE comProveedoresGuardar
GO
CREATE PROCEDURE comProveedoresGuardar
(
@pgenEntidades bigint,
@pProveed_Id varchar(15),
@pEmpresa_Id int = NULL,
@pRazonSocial varchar(120),
@pNombreLegal varchar(120),
@pDireccion1 varchar(100),
@pDireccion2 varchar(100),
@pLocalidad varchar(30),
@pCodigoPostal CodigoPostal,
@pProvincia_Id varchar(5) = NULL,
@pPais smallint = NULL,
@pTelefono varchar(100),
@pRegion_Id varchar(5) = NULL,
@pCondPago_Id varchar(5) = NULL,
@pFormaEnt_Id varchar(5) = NULL,
@pContacto varchar(20),
@pEMail varchar(max),
@pFax varchar(30),
@pFecha_Alta datetime,
@pFechaUltActiv datetime,
@pLetra_Fact char(1),
@pObservaciones VarChar(max) = NULL,
@pCondFiscal_Id varchar(5) = NULL,
@pGanancias bit,
@pIBrutos varchar(20),
@pEspecializacion char(1),
@pOrigen_Id smallint = NULL,
@pEsAduana bit,
@pTipoCuenta char(2),
@pNroCuenta varchar(17),
@pCBU varchar(22),
@pInterbanking qFechaHora = Null,
@pBanco_Id varchar(3) = NULL,
@pProvTipo_Id varChar(5) = Null,
@pInactivo bit,
@pUsuario_Id int = NULL,
@pPosteado bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comProveedores WHERE (genEntidades = @pgenEntidades)))
BEGIN 
	UPDATE comProveedores
	SET	
		Proveed_Id = @pProveed_Id,
		Empresa_Id = @pEmpresa_Id,
		RazonSocial = @pRazonSocial,
		NombreLegal = @pNombreLegal,
		Direccion1 = @pDireccion1,
		Direccion2 = @pDireccion2,
		Localidad = @pLocalidad,
		CodigoPostal = @pCodigoPostal,
		Provincia_Id = dbo.FuncFKgenProvincias(@pProvincia_Id),
		Pais = dbo.FuncFKgenPaises(@pPais),
		Telefono = @pTelefono,
		Region_Id = dbo.FuncFKcomRegiones(@pRegion_Id),
		CondPago_Id = dbo.FuncFKcomConPago(@pCondPago_Id),
		FormaEnt_Id = dbo.FuncFKcomForEntre(@pFormaEnt_Id),
		Contacto = @pContacto,
		EMail = @pEMail,
		Fax = @pFax,
		Fecha_Alta = @pFecha_Alta,
		FechaUltActiv = @pFechaUltActiv,
		Letra_Fact = @pLetra_Fact,
		Observaciones = @pObservaciones,
		CondFiscal_Id = dbo.FuncFKcomCondFiscal(@pCondFiscal_Id),
		Ganancias = @pGanancias,
		IBrutos = @pIBrutos,
		Especializacion = @pEspecializacion,
		Origen_Id = dbo.FuncFKcomOrigenesFiscales(@pOrigen_Id),
		EsAduana = @pEsAduana,
		TipoCuenta = @pTipoCuenta,
		NroCuenta = @pNroCuenta,
		CBU = @pCBU,
		Interbanking = @pInterbanking,
		Banco_Id = dbo.FuncFKtesBancos(@pBanco_Id),
		ProvTipo_Id = dbo.FuncFKcomProvTipos(@pProvTipo_Id),
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (genEntidades = @pgenEntidades)
END 
ELSE 
BEGIN 
	INSERT INTO comProveedores
	(
		genEntidades,
		Proveed_Id,
		Empresa_Id,
		RazonSocial,
		NombreLegal,
		Direccion1,
		Direccion2,
		Localidad,
		CodigoPostal,
		Provincia_Id,
		Pais,
		Telefono,
		Region_Id,
		CondPago_Id,
		FormaEnt_Id,
		Contacto,
		EMail,
		Fax,
		Fecha_Alta,
		FechaUltActiv,
		Letra_Fact,
		Observaciones,
		CondFiscal_Id,
		Ganancias,
		IBrutos,
		Especializacion,
		Origen_Id,
		EsAduana,
		TipoCuenta,
		NroCuenta,
		CBU,
		Interbanking,
		Banco_Id,
		ProvTipo_Id,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pgenEntidades,
		@pProveed_Id,
		@pEmpresa_Id,
		@pRazonSocial,
		@pNombreLegal,
		@pDireccion1,
		@pDireccion2,
		@pLocalidad,
		@pCodigoPostal,
		dbo.FuncFKgenProvincias(@pProvincia_Id),
		dbo.FuncFKgenPaises(@pPais),
		@pTelefono,
		dbo.FuncFKcomRegiones(@pRegion_Id),
		dbo.FuncFKcomConPago(@pCondPago_Id),
		dbo.FuncFKcomForEntre(@pFormaEnt_Id),
		@pContacto,
		@pEMail,
		@pFax,
		@pFecha_Alta,
		@pFechaUltActiv,
		@pLetra_Fact,
		@pObservaciones,
		dbo.FuncFKcomCondFiscal(@pCondFiscal_Id),
		@pGanancias,
		@pIBrutos,
		@pEspecializacion,
		dbo.FuncFKcomOrigenesFiscales(@pOrigen_Id),
		@pEsAduana,
		@pTipoCuenta,
		@pNroCuenta,
		@pCBU,
		@pInterbanking,
		dbo.FuncFKtesBancos(@pBanco_Id),
		dbo.FuncFKcomProvTipos(@pProvTipo_Id),
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
END 

GO

--comProveedoresDatos 'COSECHAR S.A.','H'
DROP PROCEDURE comProveedoresDatos
GO
CREATE PROCEDURE comProveedoresDatos
(
@pProveed_Id VarChar(15),
@pEspecializacion char(1)
)
AS
SET NOCOUNT ON 

SELECT genEntidades.genEntidades,  genEntidades.CUIT, genEntidades.TipoDoc, genEntidades.idFiscal,
	comProveedores.Proveed_Id, comProveedores.Empresa_Id, 
	Cast(Case When comProveedores.Empresa_Id IS NULL THEN 1 ELSE 0 END as Bit) as PTodasEmpresas, 
	comProveedores.RazonSocial,
	comProveedores.NombreLegal, comProveedores.Direccion1, comProveedores.Direccion2, 
	comProveedores.Localidad,  comProveedores.CodigoPostal, genProvincias.Provincia_Id, 
	genProvincias.Descripcion as DescripcionProvincias, 
	genPaises.Pais_Id, genPaises.Descripcion as DescripcionPaises, 
	comProveedores.Telefono, comRegiones.Region_Id, comRegiones.Descripcion as DescripcionRegiones,
	comConPago.CondPago_Id, comConPago.Descripcion as DescripcionConPago, 
	comForEntre.FormaEnt_Id, comForEntre.Descripcion as DescripcionForEntre,
	comProveedores.Contacto, comProveedores.EMail,
	comProveedores.Fax, comProveedores.Fecha_Alta, comProveedores.FechaUltActiv, 
	comProveedores.Letra_Fact,comProveedores.Observaciones, 
	comCondFiscal.CondFiscal_Id, comCondFiscal.Descripcion as DescripcionCondFiscal, 
	comProveedores.Ganancias,comProveedores.IBrutos, comProveedores.Especializacion, 
	comOrigenesFiscales.Origen_Id, comOrigenesFiscales.Descripcion as DescripcionOrCredFisc,
	comProveedores.EsAduana, comProveedores.TipoCuenta, comProveedores.NroCuenta, comProveedores.CBU, 
	comProveedores.Interbanking,
	tesBancos.Banco_Id, tesBancos.Descripcion as DescripcionBancos, 
	comProvTipos.ProvTipo_Id, comProvTipos.Descripcion DescripcionProvTipos,
	comProveedores.Inactivo,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
	comProveedores.Posteado
FROM comProveedores 
INNER JOIN genEntidades  ON (genEntidades.genEntidades = comProveedores.genEntidades)
LEFT JOIN genProvincias  ON (genProvincias.genProvincias = comProveedores.Provincia_Id)
LEFT JOIN genPaises  ON (genPaises.genPaises = comProveedores.Pais)
LEFT JOIN comRegiones  ON (comRegiones.comRegiones = comProveedores.Region_Id)
LEFT JOIN comConPago  ON (comConPago.comConPago = comProveedores.CondPago_Id)
LEFT JOIN comForEntre  ON (comForEntre.comForEntre = comProveedores.FormaEnt_Id)
LEFT JOIN comCondFiscal  ON (comCondFiscal.comCondFiscal = comProveedores.CondFiscal_Id)
LEFT JOIN comOrigenesFiscales  ON (comOrigenesFiscales.comOrigenesFiscales= comProveedores.Origen_Id)
LEFT JOIN tesBancos  ON (tesBancos.tesBancos = comProveedores.Banco_Id)
LEFT JOIN genUsuarios  ON (genUsuarios.genUsuarios = comProveedores.Usuario_Id)
Left Join comProvTipos On comProvTipos.comProvTipos = comProveedores.ProvTipo_Id
WHERE comProveedores.Proveed_Id = @pProveed_Id /* And comProveedores.Especializacion = @pEspecializacion*/
 
Declare @pidentity bigint= dbo.FuncFKcomProveedores(@pProveed_Id)

-- Cuentas Pasivo

exec comProveedoresCtasPasivoDatos @pidentity
 /*
 SELECT comProveedoresTipoPasivo.TipoCtaProv,  
		genMonedas.Moneda_id, genMonedas.Descripcion as DescripcioMoneda,
		comProveedoresTipoPasivo.Descripcion as DescripcionTC,
		conCuentas.Cuenta_id, conCuentas.Descripcion as DescripcionCuenta,
		CtaPagoXAdelantado.Cuenta_id as CtaPagoXAdelantado , 
			CtaPagoXAdelantado.Descripcion as DescripcionCtaPagoXAdelantado
	FROM 
	comProveedoresTipoPasivo INNER JOIN comProveedoresCtasPasivo on
	comProveedoresTipoPasivo.TipoCtaProv = comProveedoresCtasPasivo.TipoCtaProv 
	INNER JOIN genMonedas ON
	comProveedoresCtasPasivo.Moneda_id = genMonedas.genMonedas
	LEFT OUTER JOIN  conCuentas ON 
	comProveedoresCtasPasivo.Cuenta_id = conCuentas.conCuentas
	LEFT OUTER JOIN  conCuentas as CtaPagoXAdelantado ON
	CtaPagoXAdelantado.conCuentas = comProveedoresCtasPasivo.CtaPagoXAdelantado 
	inner join comProveedores ON
	comProveedores.genEntidades =comProveedoresCtasPasivo.genEntidades
	WHERE
		comProveedores.Proveed_id = @pProveed_id  
	 
	 order by 2,1		
*/
 
exec comProvCtasContrapDatos @pidentity
/*
 -- Cuentas ContraPartida
SELECT conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas,
	conCentro1.Centro1_id, conCentro1.Descripcion as DescripcionCentro1, 
	conCentro2.Centro2_id, conCentro2.Descripcion as DescripcionCentro2,
	comProvCtasContrap.Detalle
FROM comProvCtasContrap 
INNER JOIN comProveedores  ON (comProveedores.genEntidades = comProvCtasContrap.Proveed_Id)
INNER JOIN conCuentas  ON (conCuentas.conCuentas = comProvCtasContrap.Cuenta_Id)
INNER JOIN conCentro1  ON (conCentro1.conCentro1 = comProvCtasContrap.Centro1_Id)
INNER JOIN conCentro2  ON (conCentro2.conCentro2 = comProvCtasContrap.Centro2_Id)
WHERE 
     comProveedores .Proveed_Id = @pProveed_Id 
*/

exec comProveedoresImpuestosDatos @pProveed_Id

/*
SELECT comImpuestos.Impuesto_id, comImpuestos.Descripcion
 FROM comProveedoresImpuestos INNER JOIN comProveedores ON
comProveedoresImpuestos.Proveed_id = comProveedores.genEntidades
inner join comImpuestos ON
comImpuestos.comImpuestos = comProveedoresImpuestos.Impuesto_id
where
comProveedores.Proveed_Id = @pProveed_Id 
*/


Exec genAtributosGeneralesIdentityDatos @pidentity, 'comProveedores'

exec genJurisCoeficientesDatos @pIdentity

exec comProveedoresRetencionDatos @pIdentity

exec genAdjuntosIdentityDatos 'comProveedores', @pIdentity

exec comProveedoresContactoDatos @pIdentity
 
RETURN @@Error 

GO

DROP PROCEDURE comProveedoresEliminar
GO
CREATE PROCEDURE comProveedoresEliminar
(
@pProveed_Id VarChar(15)
)
AS
SET NOCOUNT ON 

declare @genEntidad bigint  = (SELECT GenEntidades from	
	comProveedores where Proveed_Id = @pProveed_Id)
	
DELETE FROM comProveedores 
WHERE (Proveed_Id = @pProveed_Id)

IF NOT EXISTS(SELECT 1 FROM venClientes where GenEntidades = @genEntidad)
begin
	--IF NOT EXISTS(SELECT 1 FROM suePersonal where GenEntidades = @genEntidad)
		
		delete from genEntidades where GenEntidades = @genEntidad

end

 
 RETURN @@Error 


GO


DROP FUNCTION FuncFKcomProveedores
GO

CREATE FUNCTION FuncFKcomProveedores
(
@pProveed_Id VarChar(15)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = genEntidades FROM comProveedores  WHERE 
		Proveed_Id = @pProveed_Id  
  RETURN @pIdentity
END


GO


DROP PROCEDURE comProveedoresDatosCUIT
GO
CREATE PROCEDURE comProveedoresDatosCUIT
(
@pCuit VarChar(15)
)
AS
SET NOCOUNT ON 

SELECT comProveedores.Proveed_Id, comProveedores.Especializacion, comProveedores.Inactivo
	FROM comProveedores 
	INNER JOIN genEntidades ON (genEntidades.genEntidades = comProveedores.genEntidades)
	Where
	genEntidades.Cuit = @pCuit or
	genEntidades.Cuit = ' ' + @pCuit
ORDER BY comProveedores.Inactivo , comProveedores.Especializacion DESC
GO

Drop Procedure comProveedoresDatosId
GO
Create Procedure comProveedoresDatosId
(
@pIdentity bigint
)
As

Declare @pProveed_Id varChar(15)
Select @pProveed_Id = Proveed_Id From comProveedores Where genEntidades = @pIdentity

exec comProveedoresDatos @pProveed_Id, 'H'
Go



 
 
 
 