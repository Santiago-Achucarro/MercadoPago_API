DROP PROCEDURE conRubrosAxiGuardar
GO
CREATE PROCEDURE conRubrosAxiGuardar
(
@pRubroAxi_Id int,
@pRubroAxi_Id_Nueva int,
@pDescripcion varchar(120),
@pRubro_Id char(1),
@pEmpresa_Id int = NULL,
@pPosteado bit,
@pInactivo bit
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM conRubrosAxi WHERE RubroAxi_Id = @pRubroAxi_Id))
BEGIN 
	UPDATE conRubrosAxi
	SET		@lIdentidad = conRubrosAxi,
		RubroAxi_Id = @pRubroAxi_Id_Nueva,
		Descripcion = @pDescripcion,
		Rubro_Id = @pRubro_Id,
		Empresa_Id = @pEmpresa_Id,
		Posteado = @pPosteado,
		Inactivo = @pInactivo
	WHERE 
		RubroAxi_Id = @pRubroAxi_Id
END 
ELSE 
BEGIN 
	INSERT INTO conRubrosAxi
	(
		RubroAxi_Id,
		Descripcion,
		Rubro_Id,
		Empresa_Id,
		Posteado,
		Inactivo
	)
	VALUES 
	(
		@pRubroAxi_Id,
		@pDescripcion,
		@pRubro_Id,
		@pEmpresa_Id,
		@pPosteado,
		@pInactivo
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE conRubrosAxiDatos
GO
CREATE PROCEDURE conRubrosAxiDatos
(
	@pRubroAxi_Id int
)
AS
SET NOCOUNT ON 

SELECT conRubrosAxi.conRubrosAxi, conRubrosAxi.RubroAxi_Id, conRubrosAxi.Descripcion, conRubrosAxi.Rubro_Id,
	conRubros.Descripcion as DescripcionRubros, conRubrosAxi.RubroAxi_Id RubroAxi_Id_Nueva, conRubrosAxi.Empresa_Id, Cast( Case When conRubrosAxi.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas,
	conRubrosAxi.Posteado, conRubrosAxi.Inactivo
FROM conRubrosAxi 
INNER JOIN conRubros  ON (conRubros.Rubro_Id = conRubrosAxi.Rubro_Id)
WHERE  
	RubroAxi_Id = @pRubroAxi_Id 

 Declare @pidentity bigint= dbo.FuncFKconRubrosAxi(@pRubroAxi_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'conRubrosAxi'
 RETURN @@Error 

GO

DROP PROCEDURE conRubrosAxiEliminar
GO
CREATE PROCEDURE conRubrosAxiEliminar
(
	@pRubroAxi_Id int
)
AS
SET NOCOUNT ON 

DELETE FROM conRubrosAxi WHERE RubroAxi_Id = @pRubroAxi_Id 
RETURN @@Error 

GO

DROP FUNCTION FuncFKconRubrosAxi
GO

CREATE FUNCTION FuncFKconRubrosAxi
(
@pRubroAxi_Id int
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = conRubrosAxi FROM conRubrosAxi WHERE 
	RubroAxi_Id = @pRubroAxi_Id
  RETURN @pIdentity
END

GO
