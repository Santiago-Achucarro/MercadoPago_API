DROP PROCEDURE comProvCtasContrapInsertar
GO
CREATE PROCEDURE comProvCtasContrapInsertar
(
@pProveed_Id bigint,
@pCuenta_Id VarChar(25) ,
@pCentro1_Id VarChar(8),
@pCentro2_Id VarChar(8),
@pDetalle varchar(35)
)
AS
SET NOCOUNT ON 
	INSERT INTO comProvCtasContrap
	(
		Proveed_Id,
		Cuenta_Id,
		Centro1_Id,
		Centro2_Id,
		Detalle
	)
	VALUES 
	(
		@pProveed_Id,
		dbo.FuncFKconCuentas(@pCuenta_Id),
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id),
		@pDetalle
	)

GO

DROP PROCEDURE comProvCtasContrapDatos
GO
CREATE PROCEDURE comProvCtasContrapDatos
(
@pProveed_Id bigint,
@pCuenta_Id VarChar(25) =NULL,
@pCentro1_Id VarChar(8) =NULL,
@pCentro2_Id VarChar(8) =NULL
)
AS
SET NOCOUNT ON 

SELECT comProvCtasContrap.Proveed_Id,
	conCuentas.Cuenta_Id, conCuentas.Descripcion as DescripcionCuentas,
	conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, 
	conCentro2.Centro2_Id, conCentro2.Descripcion as DescripcionCentro2,
	comProvCtasContrap.Detalle
FROM comProvCtasContrap 
INNER JOIN comProveedores  ON (comProveedores.genEntidades = comProvCtasContrap.Proveed_Id)
INNER JOIN conCuentas  ON (conCuentas.conCuentas = comProvCtasContrap.Cuenta_Id)
INNER JOIN conCentro1  ON (conCentro1.conCentro1 = comProvCtasContrap.Centro1_Id)
INNER JOIN conCentro2  ON (conCentro2.conCentro2 = comProvCtasContrap.Centro2_Id)
WHERE 
     comProvCtasContrap.Proveed_Id = @pProveed_Id AND 
	 comProvCtasContrap.Cuenta_Id = ISNULL(dbo.FuncFKconCuentas(@pCuenta_Id),comProvCtasContrap.Cuenta_Id) AND 
	 comProvCtasContrap.Centro1_Id = ISNULL(dbo.FuncFKconCentro1(@pCentro1_Id),comProvCtasContrap.Centro1_Id) AND 
	 comProvCtasContrap.Centro2_Id = ISNULL(dbo.FuncFKconCentro2(@pCentro2_Id),comProvCtasContrap.Centro2_Id)

 
 RETURN @@Error 

GO

DROP PROCEDURE comProvCtasContrapEliminar
GO
CREATE PROCEDURE comProvCtasContrapEliminar
(
@pProveed_Id bigint,
@pCuenta_Id VarChar(25)= null ,
@pCentro1_Id VarChar(8) = null,
@pCentro2_Id VarChar(8) = null
)
AS
SET NOCOUNT ON 

DELETE FROM comProvCtasContrap 
WHERE 
Proveed_Id = @pProveed_Id AND 
(@pCuenta_Id IS NULL OR Cuenta_Id = dbo.FuncFKconCuentas(@pCuenta_Id)) AND 
(@pCentro1_Id IS NULL OR Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id)) AND 
(@pCentro2_Id IS NULL OR Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id))
 
 RETURN @@Error 

GO

