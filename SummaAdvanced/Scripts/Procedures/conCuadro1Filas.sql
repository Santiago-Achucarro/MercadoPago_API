DROP PROCEDURE conCuadro1FilasGuardar
GO
CREATE PROCEDURE conCuadro1FilasGuardar
(
@pCuadro1Fila_Id int,
@pCuadro1Fila_Id_Nuevo int,
@pDescripcion varchar(40),
@pEmpresa_Id int = NULL,
@pInactivo Sino,
@pUsuario_Id int,
@pPosteado Sino
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM conCuadro1Filas WHERE (Cuadro1Fila_Id = @pCuadro1Fila_Id)))
BEGIN 
	UPDATE conCuadro1Filas
	SET		@lIdentidad = conCuadro1Filas,
		Cuadro1Fila_Id = @pCuadro1Fila_Id_Nuevo,
		Descripcion = @pDescripcion,
		Empresa_Id = @pEmpresa_Id,
		Inactivo = @pInactivo,
		Usuario_Id = @pUsuario_Id,
		Posteado = @pPosteado
	WHERE (Cuadro1Fila_Id = @pCuadro1Fila_Id)
END 
ELSE 
BEGIN 
	INSERT INTO conCuadro1Filas
	(
		Cuadro1Fila_Id,
		Descripcion,
		Empresa_Id,
		Inactivo,
		Usuario_Id,
		Posteado
	)
	VALUES 
	(
		@pCuadro1Fila_Id,
		@pDescripcion,
		@pEmpresa_Id,
		@pInactivo,
		@pUsuario_Id,
		@pPosteado
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE conCuadro1FilasDatos
GO
CREATE PROCEDURE conCuadro1FilasDatos
(
@pCuadro1Fila_Id int
)
AS
SET NOCOUNT ON 

SELECT conCuadro1Filas.conCuadro1Filas, conCuadro1Filas.Cuadro1Fila_Id, conCuadro1Filas.Descripcion, conCuadro1Filas.Empresa_Id,
	Cast( Case When conCuadro1Filas.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT ) as PTodasEmpresas, conCuadro1Filas.Inactivo, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	conCuadro1Filas.Posteado
FROM conCuadro1Filas 
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = conCuadro1Filas.Usuario_Id)
WHERE (Cuadro1Fila_Id = @pCuadro1Fila_Id)
 


  Declare @pidentity bigint= dbo.FuncFKconCuadro1Filas(@pCuadro1Fila_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'conCuadro1Filas'
 RETURN @@Error 

GO

DROP PROCEDURE conCuadro1FilasEliminar
GO
CREATE PROCEDURE conCuadro1FilasEliminar
(
@pCuadro1Fila_Id int = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM conCuadro1Filas 
WHERE (Cuadro1Fila_Id = @pCuadro1Fila_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKconCuadro1Filas
GO

CREATE FUNCTION FuncFKconCuadro1Filas
(
@pCuadro1Fila_Id int
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = conCuadro1Filas FROM conCuadro1Filas WHERE 
	Cuadro1Fila_Id = @pCuadro1Fila_Id
  RETURN @pIdentity
END


GO
