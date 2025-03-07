DROP PROCEDURE comEsquemaAutoGuardar
GO
CREATE PROCEDURE comEsquemaAutoGuardar
(
@pEsquemaAuto_Id varchar(10),
@pEsquemaAuto_Id_Nuevo varchar(10),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(100),
@pInactivo bit,
@pPosteado bit,
@pUsuario_Id int
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM comEsquemaAuto WHERE (EsquemaAuto_Id = @pEsquemaAuto_Id)))
BEGIN 
	UPDATE comEsquemaAuto
	SET @lIdentidad = comEsquemaAuto,
		EsquemaAuto_Id = @pEsquemaAuto_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Inactivo=@pInactivo,
		Posteado=@pPosteado,
		Usuario_Id=@pUsuario_Id
	WHERE (EsquemaAuto_Id = @pEsquemaAuto_Id)
END 
ELSE 
BEGIN 
	INSERT INTO comEsquemaAuto
	(
		EsquemaAuto_Id,
		Empresa_Id,
		Descripcion,
		Inactivo,
		Posteado,
		Usuario_Id
	)
	VALUES 
	(
		@pEsquemaAuto_Id,
		@pEmpresa_Id,
		@pDescripcion,
		@pInactivo,
		@pPosteado,
		@pUsuario_Id
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE comEsquemaAutoDatos
GO
CREATE PROCEDURE comEsquemaAutoDatos
(
@pEsquemaAuto_Id varchar(10)
)
AS
SET NOCOUNT ON 

SELECT comEsquemaAuto.comEsquemaAuto, comEsquemaAuto.EsquemaAuto_Id, comEsquemaAuto.Empresa_Id,
	Cast( Case When comEsquemaAuto.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, comEsquemaAuto.Descripcion,
	comEsquemaAuto.Inactivo, comEsquemaAuto.Posteado, comEsquemaAuto.Usuario_Id
FROM comEsquemaAuto 
WHERE (EsquemaAuto_Id = @pEsquemaAuto_Id)
 
Exec comEsquemaAutoRengDatos @pEsquemaAuto_Id

Declare @pidentity bigint= dbo.FuncFKcomEsquemaAuto(@pEsquemaAuto_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'comEsquemaAuto'
RETURN @@Error 

GO

DROP PROCEDURE comEsquemaAutoEliminar
GO
CREATE PROCEDURE comEsquemaAutoEliminar
(
@pEsquemaAuto_Id varchar(10)
)
AS
SET NOCOUNT ON 

DELETE FROM comEsquemaAuto 
WHERE (EsquemaAuto_Id = @pEsquemaAuto_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKcomEsquemaAuto
GO

CREATE FUNCTION FuncFKcomEsquemaAuto
(
@pEsquemaAuto_Id varchar (10)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = comEsquemaAuto FROM comEsquemaAuto WHERE 
	EsquemaAuto_Id = @pEsquemaAuto_Id
  RETURN @pIdentity
END


GO
