DROP PROCEDURE proRecursosGuardar
GO
CREATE PROCEDURE proRecursosGuardar
(
@pRecurso_Id varchar(25),
@pRecurso_Id_Nueva varchar(25),
@pDescripcion varchar(60),
@pUnidad_Id varchar(5) = NULL,
@pCapacidad qCantidadD8,
@pCosto qMonedaD4,
@pUsaSubRecurso Sino,
@pInactivo Sino,
@pPosteado Sino,
@pEmpresa_Id Int = NULL, 
@pUsuario_Id Int, 
@pCuenta_Id VarChar(25) = NULL
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM proRecursos WHERE (Recurso_Id = @pRecurso_Id)))
BEGIN 
	UPDATE proRecursos
	SET		@lIdentidad=proRecursos,
	Recurso_Id = @pRecurso_Id_Nueva,
		Descripcion = @pDescripcion,
		Unidad_Id = dbo.FuncFKstkUniMed(@pUnidad_Id),
		Capacidad = @pCapacidad,
		Costo = @pCosto,
		UsaSubRecurso = @pUsaSubRecurso,
		Inactivo = @pInactivo,
		Posteado = @pPosteado, 
		Empresa_Id = @pEmpresa_Id, 
		Usuario_Id = @pUsuario_Id, 
		Cuenta_Id = dbo.FuncFKconCuentas(@pCuenta_Id)
	WHERE (Recurso_Id = @pRecurso_Id)
END 
ELSE 
BEGIN 
	INSERT INTO proRecursos
	(
		
		Recurso_Id,
		Descripcion,
		Unidad_Id,
		Capacidad,
		Costo,
		UsaSubRecurso,
		Inactivo,
		Posteado,
		Empresa_Id, 
		Usuario_Id,
		Cuenta_Id
	)
	VALUES 
	(
		
		@pRecurso_Id,
		@pDescripcion,
		dbo.FuncFKstkUniMed(@pUnidad_Id),
		@pCapacidad,
		@pCosto,
		@pUsaSubRecurso,
		@pInactivo,
		@pPosteado, 
		@pEmpresa_Id, 
		@pUsuario_Id, 
		dbo.FuncFKconCuentas(@pCuenta_Id)
	)
SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE proRecursosDatos
GO
CREATE PROCEDURE proRecursosDatos
(
@pRecurso_Id varchar(25)
)
AS
SET NOCOUNT ON 

SELECT proRecursos.proRecursos, proRecursos.Recurso_Id,  proRecursos.Descripcion, stkUniMed.Medida_Id,
	stkUniMed.Descripcion as DescripcionUniMed, proRecursos.Capacidad, proRecursos.Costo, proRecursos.UsaSubRecurso,
	proRecursos.Inactivo, proRecursos.Posteado, 
	proRecursos.Empresa_Id,
	CAST(CASE WHEN proRecursos.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT) AS PTodasEmpresas,
	genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario,
	conCuentas.Cuenta_Id, conCuentas.Descripcion as  DescripcionCuenta
FROM proRecursos 
LEFT JOIN stkUniMed  ON (stkUniMed.stkUniMed = proRecursos.Unidad_Id)
INNER JOIN genUsuarios ON genUsuarios.genUsuarios = proRecursos.Usuario_Id
LEFT JOIN conCuentas ON conCuentas.conCuentas = proRecursos.Cuenta_Id
WHERE (proRecursos = dbo.FuncFKproRecursos(@pRecurso_Id))

exec proSubRecursosDatos @pRecurso_Id

 Declare @pidentity bigint= dbo.FuncFKproRecursos(@pRecurso_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'proRecursos'

 RETURN @@Error 

GO

DROP PROCEDURE proRecursosEliminar
GO
CREATE PROCEDURE proRecursosEliminar
(
@pRecurso_Id varchar(25) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM proRecursos 
WHERE proRecursos.Recurso_Id=@pRecurso_Id
 
 RETURN @@Error 

GO
DROP FUNCTION FuncFKproRecursos
GO

CREATE FUNCTION FuncFKproRecursos
(
@pRecurso_Id varchar (25)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = proRecursos FROM proRecursos WHERE 
	Recurso_Id = @pRecurso_Id
  RETURN @pIdentity
END


GO
