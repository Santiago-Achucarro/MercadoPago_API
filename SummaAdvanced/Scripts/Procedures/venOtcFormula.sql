DROP PROCEDURE venOtcFormulaGuardar
GO
CREATE PROCEDURE venOtcFormulaGuardar
(
@pFormula_Id int,
@pFormula_Id_Nuevo int,
@pEmpresa_Id int = NULL,
@pDescripcion varchar(60),
@pFormula qFormula,
@pPosteado Sino,
@pUsuario_Id int
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM venOtcFormula WHERE (Formula_Id = @pFormula_Id)))
BEGIN 
	UPDATE venOtcFormula
	SET @lIdentidad = venOtcFormula,
		Formula_Id = @pFormula_Id_Nuevo,
		Empresa_Id = @pEmpresa_Id,
		Descripcion = @pDescripcion,
		Formula = @pFormula,
		Posteado = @pPosteado,
		Usuario_Id = @pUsuario_Id
	WHERE (Formula_Id = @pFormula_Id)
END 
ELSE 
BEGIN 
	INSERT INTO venOtcFormula
	(
		Formula_Id,
		Empresa_Id,
		Descripcion,
		Formula,
		Posteado,
		Usuario_Id
	)
	VALUES 
	(
		@pFormula_Id,
		@pEmpresa_Id,
		@pDescripcion,
		@pFormula,
		@pPosteado,
		@pUsuario_Id
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE venOtcFormulaDatos
GO
CREATE PROCEDURE venOtcFormulaDatos
(
@pFormula_Id int
)
AS
SET NOCOUNT ON 

SELECT venOtcFormula.venOtcFormula, venOtcFormula.Formula_Id, venOtcFormula.Formula_Id Formula_Id_Nueva, venOtcFormula.Empresa_Id,
	Cast( Case When venOtcFormula.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, venOtcFormula.Descripcion, venOtcFormula.Formula, venOtcFormula.Posteado,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario
FROM venOtcFormula 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = venOtcFormula.Usuario_Id)
WHERE (Formula_Id = @pFormula_Id)
 


Declare @pidentity bigint= dbo.FuncFKvenOtcFormula(@pFormula_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'venOtcFormula'
RETURN @@Error 

GO

DROP PROCEDURE venOtcFormulaEliminar
GO
CREATE PROCEDURE venOtcFormulaEliminar
(
@pFormula_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venOtcFormula 
WHERE (Formula_Id = @pFormula_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKvenOtcFormula
GO

CREATE FUNCTION FuncFKvenOtcFormula
(
@pFormula_Id int
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venOtcFormula FROM venOtcFormula WHERE 
	Formula_Id = @pFormula_Id
  RETURN @pIdentity
END


GO
