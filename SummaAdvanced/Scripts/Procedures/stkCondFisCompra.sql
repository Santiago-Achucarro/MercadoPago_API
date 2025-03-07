DROP PROCEDURE stkCondFisCompraGuardar
GO
CREATE PROCEDURE stkCondFisCompraGuardar
(
@pCFComp_Id varchar(5),
@pCFComp_Id_Nuevo varchar(5),
@pEmpresa_Id int=null,
@pDescripcion varchar(35),
@pInactivo Sino,
@pUsuario_Id int,
@pPosteado Sino
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM stkCondFisCompra WHERE (CFComp_Id = @pCFComp_Id)))
BEGIN 
	UPDATE stkCondFisCompra
	SET		@lIdentidad = stkCondFisCompra,
		CFComp_Id = @pCFComp_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (CFComp_Id = @pCFComp_Id)
END 
ELSE 
BEGIN 
	INSERT INTO stkCondFisCompra
	(
		CFComp_Id,
		Empresa_Id,
		Descripcion,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pCFComp_Id,
		@pEmpresa_Id,
		@pDescripcion,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE stkCondFisCompraDatos
GO
CREATE PROCEDURE stkCondFisCompraDatos
(
@pCFComp_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT stkCondFisCompra.stkCondFisCompra, stkCondFisCompra.CFComp_Id, stkCondFisCompra.Empresa_Id, 
	dbo.PTodasEmpresas(stkCondFisCompra.Empresa_Id) as PTodasEmpresas,
	stkCondFisCompra.Descripcion,
	stkCondFisCompra.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, stkCondFisCompra.Posteado
FROM stkCondFisCompra 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = stkCondFisCompra.Usuario_Id)
WHERE (CFComp_Id = @pCFComp_Id)
 
 SELECT comImpuestos.Impuesto_id, comImpuestos.Descripcion from 
	stkCFComImp inner join comImpuestos ON
	stkCFComImp.Impuesto_Id = comImpuestos.comImpuestos
	INNER JOIN stkCondFisCompra on 
	stkCondFisCompra.stkCondFisCompra = stkCFComImp.CFComp_Id
WHERE	
	stkCondFisCompra.CFComp_Id = @pCFComp_Id
ORDER BY 1


Declare @pidentity bigint= dbo.FuncFKstkCondFisCompra(@pCFComp_id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'stkCondFisCompra'
 
RETURN @@Error 

GO

DROP PROCEDURE stkCondFisCompraEliminar
GO
CREATE PROCEDURE stkCondFisCompraEliminar
(
@pCFComp_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM stkCondFisCompra 
WHERE (CFComp_Id = @pCFComp_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKstkCondFisCompra
GO

CREATE FUNCTION FuncFKstkCondFisCompra
(
@pCFComp_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = stkCondFisCompra FROM stkCondFisCompra WHERE 
	CFComp_Id = @pCFComp_Id
  RETURN @pIdentity
END


GO


 
