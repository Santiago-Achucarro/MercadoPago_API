DROP PROCEDURE venEsquemaAutoGuardar
GO
CREATE PROCEDURE venEsquemaAutoGuardar
(
@pEsquemaAuto_Id varchar(10),
@pEsquemaAuto_Id_Nuevo varchar(10),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(100)
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM venEsquemaAuto WHERE (EsquemaAuto_Id = @pEsquemaAuto_Id)))
BEGIN 
	UPDATE venEsquemaAuto
	SET @lIdentidad = venEsquemaAuto,
		EsquemaAuto_Id = @pEsquemaAuto_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion
	WHERE (EsquemaAuto_Id = @pEsquemaAuto_Id)
END 
ELSE 
BEGIN 
	INSERT INTO venEsquemaAuto
	(
		EsquemaAuto_Id,
		Empresa_Id,
		Descripcion
	)
	VALUES 
	(
		@pEsquemaAuto_Id,
		@pEmpresa_Id,
		@pDescripcion
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE venEsquemaAutoDatos
GO
CREATE PROCEDURE venEsquemaAutoDatos
(
@pEsquemaAuto_Id varchar(10)
)
AS
SET NOCOUNT ON 

SELECT venEsquemaAuto.venEsquemaAuto, venEsquemaAuto.EsquemaAuto_Id, venEsquemaAuto.Empresa_Id,
	Cast( Case When venEsquemaAuto.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, venEsquemaAuto.Descripcion
FROM venEsquemaAuto 
WHERE (EsquemaAuto_Id = @pEsquemaAuto_Id)
 
Exec venEsquemaAutoRengDatos @pEsquemaAuto_Id

Declare @pidentity bigint= dbo.FuncFKvenEsquemaAuto(@pEsquemaAuto_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'venEsquemaAuto'
RETURN @@Error 

GO

DROP PROCEDURE venEsquemaAutoEliminar
GO
CREATE PROCEDURE venEsquemaAutoEliminar
(
@pEsquemaAuto_Id varchar(10)
)
AS
SET NOCOUNT ON 

DELETE FROM venEsquemaAuto 
WHERE (EsquemaAuto_Id = @pEsquemaAuto_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKvenEsquemaAuto
GO

CREATE FUNCTION FuncFKvenEsquemaAuto
(
@pEsquemaAuto_Id varchar (10)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venEsquemaAuto FROM venEsquemaAuto WHERE 
	EsquemaAuto_Id = @pEsquemaAuto_Id
  RETURN @pIdentity
END


GO
