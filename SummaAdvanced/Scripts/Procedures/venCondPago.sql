DROP PROCEDURE venCondPagoGuardar
GO
CREATE PROCEDURE venCondPagoGuardar
(
@pCondPagoCli_id varchar(5),
@pCondPagoCli_id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(35),
@pCantCuotas smallint,
@pTipoVencimiento char(2),
@pDias int,
@pDiasVencimiento smallint,
@pDiasDescFinanc smallint,
@pDescFinanc numeric(5,2),
@pImpPrimCuota bit,
@pEditaCuotas bit,
@pFactCredito bit,
@pInactivo bit,
@pUsuario_Id int,
@pPosteado bit, 
@pTipoFiscal VarChar(5)
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM venCondPago WHERE (CondPagoCli_id = @pCondPagoCli_id)))
BEGIN 
	UPDATE venCondPago
	SET		@lIdentidad = venCondPago,
		CondPagoCli_id = @pCondPagoCli_id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		CantCuotas = @pCantCuotas,
		TipoVencimiento = @pTipoVencimiento,
		Dias = @pDias,
		DiasVencimiento = @pDiasVencimiento,
		DiasDescFinanc = @pDiasDescFinanc,
		DescFinanc = @pDescFinanc,
		ImpPrimCuota = @pImpPrimCuota,
		EditaCuotas = @pEditaCuotas,
		FactCredito = @pFactCredito,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado, 
		TipoFiscal = @pTipoFiscal
	WHERE (CondPagoCli_id = @pCondPagoCli_id)
END 
ELSE 
BEGIN 
	INSERT INTO venCondPago
	(
		CondPagoCli_id,
		Empresa_Id,
		Descripcion,
		CantCuotas,
		TipoVencimiento,
		Dias,
		DiasVencimiento,
		DiasDescFinanc,
		DescFinanc,
		ImpPrimCuota,
		EditaCuotas,
		FactCredito,
		Inactivo,
		Usuario_Id,
		Posteado, 
		TipoFiscal
	)
	VALUES 
	(
		@pCondPagoCli_id,
		@pEmpresa_Id,
		@pDescripcion,
		@pCantCuotas,
		@pTipoVencimiento,
		@pDias,
		@pDiasVencimiento,
		@pDiasDescFinanc,
		@pDescFinanc,
		@pImpPrimCuota,
		@pEditaCuotas,
		@pFactCredito,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado, 
		@pTipoFiscal
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE venCondPagoDatos
GO
CREATE PROCEDURE venCondPagoDatos
(
@pCondPagoCli_id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT venCondPago.venCondPago, venCondPago.CondPagoCli_id, venCondPago.Empresa_Id, Cast( Case When venCondPago.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	venCondPago.Descripcion, venCondPago.CantCuotas, venCondPago.TipoVencimiento, venCondPago.Dias,
	venCondPago.DiasVencimiento, venCondPago.DiasDescFinanc, venCondPago.DescFinanc, venCondPago.ImpPrimCuota,
	venCondPago.EditaCuotas, venCondPago.FactCredito, venCondPago.Inactivo, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, venCondPago.Posteado, venCondPago.TipoFiscal
FROM venCondPago 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = venCondPago.Usuario_Id)
WHERE (venCondPago.CondPagoCli_id = @pCondPagoCli_id)
 


 Declare @pidentity bigint= dbo.FuncFKvenCondPago(@pCondPagoCli_id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'venCondPago'
 
 SELECT  venCondPagoCuotas.Renglon, venCondPagoCuotas.Dias, venCondPagoCuotas.Porcentaje 
 From 
	venCondPagoCuotas inner join venCondPago ON
	venCondPagoCuotas.CondPagoCli_id = venCondPago.venCondPago
 WHERE
	venCondPago.CondPagoCli_id = @pCondPagoCli_id
	ORDER BY 1
	
 RETURN @@Error 

GO

DROP PROCEDURE venCondPagoEliminar
GO
CREATE PROCEDURE venCondPagoEliminar
(
@pCondPagoCli_id varchar(5)
)
AS
SET NOCOUNT ON 

DELETE FROM venCondPago 
WHERE (CondPagoCli_id = @pCondPagoCli_id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKvenCondPago
GO

CREATE FUNCTION FuncFKvenCondPago
(
@pCondPagoCli_id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venCondPago FROM venCondPago WHERE 
	CondPagoCli_id = @pCondPagoCli_id
  RETURN @pIdentity
END


GO


DROP PROCEDURE venCondPagoDatosXDias
GO
CREATE PROCEDURE venCondPagoDatosXDias
(
@pDias int
)
AS
SET NOCOUNT ON 

SELECT top 1 venCondPago.venCondPago, venCondPago.CondPagoCli_id, venCondPago.Empresa_Id, Cast( Case When venCondPago.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	venCondPago.Descripcion, venCondPago.CantCuotas, venCondPago.TipoVencimiento, venCondPago.Dias,
	venCondPago.DiasVencimiento, venCondPago.DiasDescFinanc, venCondPago.DescFinanc, venCondPago.ImpPrimCuota,
	venCondPago.EditaCuotas, venCondPago.FactCredito, venCondPago.Inactivo, genUsuarios.Usuario_Id,
	genUsuarios.Apellido_y_Nombres as DescripcionUsuario, venCondPago.Posteado, venCondPago.TipoFiscal
FROM venCondPago 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = venCondPago.Usuario_Id)
WHERE (venCondPago.DiasVencimiento = @pDias)
order by 1
 


 Declare @pidentity bigint= (select min(venCondPago) from venCondPago where DiasVencimiento=@pDias)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'venCondPago'
 
 SELECT  venCondPagoCuotas.Renglon, venCondPagoCuotas.Dias, venCondPagoCuotas.Porcentaje 
 From 
	venCondPagoCuotas inner join venCondPago ON
	venCondPagoCuotas.CondPagoCli_id = venCondPago.venCondPago
 WHERE
	venCondPago.CondPagoCli_id = @pidentity
	ORDER BY 1
	
 RETURN @@Error 

GO