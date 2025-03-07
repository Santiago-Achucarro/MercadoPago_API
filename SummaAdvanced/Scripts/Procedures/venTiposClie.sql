DROP PROCEDURE venTiposClieGuardar
GO
CREATE PROCEDURE venTiposClieGuardar
(
@pTipoClie_Id varchar(5),
@pTipoClie_Id_Nuevo varchar(5),
@pEmpresa_Id int = NULL,
@pDescripcion varchar(35),
@pCentro1_Id varchar(8) = NULL,
@pCentro2_Id varchar(8) = NULL,
@pUsuario_Id int,
@pPosteado bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM venTiposClie WHERE (TipoClie_Id = @pTipoClie_Id)))
BEGIN 
	UPDATE venTiposClie
	SET		@lIdentidad = venTiposClie,
		TipoClie_Id = @pTipoClie_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Centro1_Id = dbo.FuncFKconCentro1(@pCentro1_Id),
		Centro2_Id = dbo.FuncFKconCentro2(@pCentro2_Id),
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (TipoClie_Id = @pTipoClie_Id)
END 
ELSE 
BEGIN 
	INSERT INTO venTiposClie
	(
		TipoClie_Id,
		Empresa_Id,
		Descripcion,
		Centro1_Id,
		Centro2_Id,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pTipoClie_Id,
		@pEmpresa_Id,
		@pDescripcion,
		dbo.FuncFKconCentro1(@pCentro1_Id),
		dbo.FuncFKconCentro2(@pCentro2_Id),
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE venTiposClieDatos
GO
CREATE PROCEDURE venTiposClieDatos
(
@pTipoClie_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT venTiposClie.venTiposClie, venTiposClie.TipoClie_Id, venTiposClie.Empresa_Id, Cast( Case When venTiposClie.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	venTiposClie.Descripcion, conCentro1.Centro1_Id, conCentro1.Descripcion as DescripcionCentro1, conCentro2.Centro2_Id,
	conCentro2.Descripcion as DescripcionCentro2, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, venTiposClie.Posteado
FROM venTiposClie 
LEFT JOIN conCentro1  ON (conCentro1.conCentro1 = venTiposClie.Centro1_Id)
LEFT JOIN conCentro2  ON (conCentro2.conCentro2 = venTiposClie.Centro2_Id)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = venTiposClie.Usuario_Id)
WHERE (TipoClie_Id = @pTipoClie_Id)
 


  Declare @pidentity bigint= dbo.FuncFKvenTiposClie(@pTipoClie_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'venTiposClie'
 RETURN @@Error 

GO

DROP PROCEDURE venTiposClieEliminar
GO
CREATE PROCEDURE venTiposClieEliminar
(
@pTipoClie_Id varchar(5) 
)
AS
SET NOCOUNT ON 

DELETE FROM venTiposClie 
WHERE (TipoClie_Id = @pTipoClie_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKvenTiposClie
GO

CREATE FUNCTION FuncFKvenTiposClie
(
@pTipoClie_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venTiposClie FROM venTiposClie WHERE 
	TipoClie_Id = @pTipoClie_Id
  RETURN @pIdentity
END


GO
