-- exec venClientesDatos '1'

DROP PROCEDURE venClientesGuardar
GO
CREATE PROCEDURE venClientesGuardar
(
@pgenEntidades bigint,
@pCliente_Id varchar(15),
@pCliente_Id_Nueva varchar(15),
@pEmpresa_Id int = NULL,
@pRazonSocial varchar(120),
@pSucursalPredeter SucursalN,
@pCondFisc_Id varchar(5) = NULL,
@pLimiteCredito qMonedaD2,
@pMonedaLimCred varchar(3),
@pCategCred_Id varchar(5) = NULL,
@pBonificacion1 qPorcentaje,
@pBonificacion2 qPorcentaje,
@pBonificacion3 qPorcentaje,
@pPuntual Sino,
@pEstado_Id varchar(5) = NULL,
@pGeneraDebito Sino,
@pSiempre Sino,
@pCongelaCambio Sino,
@pIBrutos varchar(20),
@pSituacion char(1),
@pFacturaCredito Sino = NULL,
@pMontoFacturaCredito qMonedaD2 = NULL,
@pCbuBanco varchar(22) = NULL,
@pPosteado Sino, 
@pRegimen VarChar(5) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM venClientes WHERE (genEntidades = @pgenEntidades)))
BEGIN 
	UPDATE venClientes
	SET		Cliente_Id = @pCliente_Id_Nueva,
		Empresa_Id = @pEmpresa_Id,
		RazonSocial = @pRazonSocial,
		SucursalPredeter = @pSucursalPredeter,
		CondFisc_Id = dbo.FuncFKvenCondFiscal(@pCondFisc_Id),
		LimiteCredito = @pLimiteCredito,
		MonedaLimCred = dbo.FuncFKgenMonedas(@pMonedaLimCred),
		CategCred_Id = dbo.FuncFKvenCategCredito(@pCategCred_Id),
		Bonificacion1 = @pBonificacion1,
		Bonificacion2 = @pBonificacion2,
		Bonificacion3 = @pBonificacion3,
		Puntual = @pPuntual,
		Estado_Id = dbo.FuncFKvenClieEstados(@pEstado_Id),
		GeneraDebito = @pGeneraDebito,
		Siempre = @pSiempre,
		CongelaCambio = @pCongelaCambio,
		IBrutos = @pIBrutos,
		Situacion = @pSituacion,
		FacturaCredito = @pFacturaCredito,
		MontoFacturaCredito = @pMontoFacturaCredito,
		CbuBanco = @pCbuBanco,
		Posteado = @pPosteado, 
		Regimen = @pRegimen
	WHERE (genEntidades = @pgenEntidades)
END 
ELSE 
BEGIN 
	INSERT INTO venClientes
	(
		genEntidades,
		Cliente_Id,
		Empresa_Id,
		RazonSocial,
		SucursalPredeter,
		CondFisc_Id,
		LimiteCredito,
		MonedaLimCred,
		CategCred_Id,
		Bonificacion1,
		Bonificacion2,
		Bonificacion3,
		Puntual,
		Estado_Id,
		GeneraDebito,
		Siempre,
		CongelaCambio,
		IBrutos,
		Situacion,
		FacturaCredito,
		MontoFacturaCredito,
		CbuBanco,
		Posteado, 
		Regimen
	)
	VALUES 
	(
		@pgenEntidades,
		@pCliente_Id_Nueva,
		@pEmpresa_Id,
		@pRazonSocial,
		@pSucursalPredeter,
		dbo.FuncFKvenCondFiscal(@pCondFisc_Id),
		@pLimiteCredito,
		dbo.FuncFKgenMonedas(@pMonedaLimCred),
		dbo.FuncFKvenCategCredito(@pCategCred_Id),
		@pBonificacion1,
		@pBonificacion2,
		@pBonificacion3,
		@pPuntual,
		dbo.FuncFKvenClieEstados(@pEstado_Id),
		@pGeneraDebito,
		@pSiempre,
		@pCongelaCambio,
		@pIBrutos,
		@pSituacion,
		@pFacturaCredito,
		@pMontoFacturaCredito,
		@pCbuBanco,
		@pPosteado, 
		@pRegimen
	)
END 

GO

DROP PROCEDURE venClientesDatos
GO
CREATE PROCEDURE venClientesDatos
(
@pCliente_id VarChar(15)
)
AS
SET NOCOUNT ON 

SELECT genEntidades.genEntidades, 
	genEntidades.CUIT, genEntidades.TipoDoc, genEntidades.IdFiscal, venClientes.Cliente_Id, venClientes.Empresa_Id, 
	Cast (Case When venClientes.Empresa_Id IS NULL THEN 1 ELSE 0 END as BIT) AS PTodasEmpresas,
	venClientes.RazonSocial,
	venClientes.SucursalPredeter, 
	venCondFiscal.CondFisc_Id, 	venCondFiscal.Descripcion as DescripcionCondFiscal, 
	venClientes.LimiteCredito, genMonedas.Moneda_Id MonedaLimCred,
	venCategCredito.CategCred_Id, venCategCredito.Descripcion as DescripcionCategCredito,
	venClientes.Bonificacion1, venClientes.Bonificacion2, venClientes.Bonificacion3, 
	venClientes.Puntual,
	venClieEstados.Estado_Id, venClieEstados.Descripcion as DescripcionClieEstados, 
	venClientes.GeneraDebito, venClientes.Siempre,
	venClientes.CongelaCambio, venClientes.IBrutos, venClientes.Situacion,
	venClientes.FacturaCredito, venClientes.MontoFacturaCredito, venClientes.CbuBanco, venClientes.Posteado, 
	venClientes.Regimen
FROM venClientes 
INNER JOIN genEntidades  ON (genEntidades.genEntidades = venClientes.genEntidades)
LEFT JOIN venCondFiscal  ON (venCondFiscal.venCondFiscal = venClientes.CondFisc_Id)
LEFT JOIN venCategCredito  ON (venCategCredito.venCategCredito = venClientes.CategCred_Id)
LEFT JOIN venClieEstados  ON (venClieEstados.venClieEstados = venClientes.Estado_Id)
Left Join genMonedas On genMonedas.genMonedas = venClientes.MonedaLimCred

WHERE (venClientes.Cliente_Id = @pCliente_Id)
 


Declare @pidentity bigint= dbo.FuncFKvenClientes(@pCliente_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'venClientes'


 
 RETURN @@Error 

GO


DROP PROCEDURE venClientesDatosId
GO
CREATE PROCEDURE venClientesDatosId
(
	@genEntidades Bigint
)
AS
SET NOCOUNT ON 

SELECT genEntidades.genEntidades, venClientes.Cliente_Id,
	genEntidades.CUIT, genEntidades.TipoDoc, genEntidades.IdFiscal, venClientes.Empresa_Id, 
	Cast (Case When venClientes.Empresa_Id IS NULL THEN 1 ELSE 0 END as BIT) AS PTodasEmpresas,
	venClientes.RazonSocial,
	venClientes.SucursalPredeter, 
	venCondFiscal.CondFisc_Id, 	venCondFiscal.Descripcion as DescripcionCondFiscal, 
	venClientes.LimiteCredito, genMonedas.Moneda_Id MonedaLimCred,
	venCategCredito.CategCred_Id, venCategCredito.Descripcion as DescripcionCategCredito,
	venClientes.Bonificacion1, venClientes.Bonificacion2, venClientes.Bonificacion3, 
	venClientes.Puntual,
	venClieEstados.Estado_Id, venClieEstados.Descripcion as DescripcionClieEstados, 
	venClientes.GeneraDebito, venClientes.Siempre,
	venClientes.CongelaCambio, venClientes.IBrutos, venClientes.Situacion, 
	venClientes.FacturaCredito, venClientes.MontoFacturaCredito, venClientes.CbuBanco, venClientes.Posteado, 
	venClientes.Regimen
FROM venClientes 
INNER JOIN genEntidades  ON (genEntidades.genEntidades = venClientes.genEntidades)
LEFT JOIN venCondFiscal  ON (venCondFiscal.venCondFiscal = venClientes.CondFisc_Id)
LEFT JOIN venCategCredito  ON (venCategCredito.venCategCredito = venClientes.CategCred_Id)
LEFT JOIN venClieEstados  ON (venClieEstados.venClieEstados = venClientes.Estado_Id)
Left Join genMonedas On genMonedas.genMonedas = venClientes.MonedaLimCred
WHERE (venClientes.genEntidades = @genEntidades)
 
 
Exec genAtributosGeneralesIdentityDatos @genEntidades, 'venClientes'


 
RETURN @@Error 

GO

DROP PROCEDURE venClientesEliminar
GO
CREATE PROCEDURE venClientesEliminar
(
@pCliente_Id bigint
)
AS
SET NOCOUNT ON 

DELETE FROM venClientes 
WHERE (genEntidades = @pCliente_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKvenClientes
GO

CREATE FUNCTION FuncFKvenClientes
(
@pCliente_Id varchar (15)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = genEntidades FROM venClientes WHERE 
	Cliente_Id = @pCliente_Id
  RETURN @pIdentity
END


GO



DROP PROCEDURE venClientesCFiscalGuardar
GO
CREATE PROCEDURE venClientesCFiscalGuardar
(
@pCliente_Id bigint, 
@pCondFiscal_Id VarChar(5)
)
AS
SET NOCOUNT ON 

UPDATE venClientes SET CondFisc_Id = dbo.FuncFKvenCondFiscal(@pCondFiscal_Id)
	WHERE (genEntidades = @pCliente_Id)
 
 RETURN @@Error 

GO




DROP PROCEDURE venClientesSucDatos
GO
CREATE PROCEDURE venClientesSucDatos
(
	@pCliente_id VarChar(15)
)
AS
SET NOCOUNT ON 

SELECT venClientes.genEntidades, venClientes.Cliente_Id
FROM venClientes 
WHERE (venClientes.Cliente_Id = @pCliente_Id)

SELECT venClieHabitual.Sucursal, venClieHabitual.NombreFantasia
FROM venClieHabitual INNER JOIN venClientes ON 
venClieHabitual.genEntidades = venClientes.genEntidades 
WHERE
venClientes.Cliente_Id = @pCliente_Id
ORDER BY 1 


 
RETURN @@Error 

GO
