DROP FUNCTION FuncFKvenLibros
GO

CREATE FUNCTION FuncFKvenLibros
(
@pLibro_Id varchar (10)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venLibros FROM venLibros WHERE 
	Libro_Id = @pLibro_Id
  RETURN @pIdentity
END


GO

DROP PROCEDURE venLibrosGuardar
GO
CREATE PROCEDURE venLibrosGuardar
(
@pLibro_Id varchar(10),
@pEmpresa_Id int,
@pLibro_Id_Nuevo varchar(10),
@pDescripcion varchar(50)
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM venLibros WHERE (Libro_Id = @pLibro_Id)))
BEGIN 
	UPDATE venLibros
	SET		@lIdentidad = venLibros,
			Empresa_Id = @pEmpresa_Id,
			Libro_Id = @pLibro_Id_Nuevo,
			Descripcion = @pDescripcion
	WHERE (Libro_Id = @pLibro_Id) 
END 
ELSE 
BEGIN 
	INSERT INTO venLibros
	(
		Libro_Id,
		Descripcion,
		Empresa_Id
	)
	VALUES 
	(
		@pLibro_Id,
		@pDescripcion,
		@pEmpresa_Id
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE venLibrosDatos
GO
CREATE PROCEDURE venLibrosDatos
(
@pLibro_Id varchar(10)
)
AS
SET NOCOUNT ON 




SELECT venLibros.venLibros, venLibros.Libro_Id, venLibros.Libro_Id as Libro_Id_Nuevo, venLibros.Empresa_Id, venLibros.Descripcion, 
	CAST(CASE WHEN venLibros.Empresa_Id IS NULL THEN 1 ELSE 0 END AS BIT) AS PTodasLasEmpresas
FROM venLibros 
WHERE (Libro_Id = @pLibro_Id)


 Declare @pidentity bigint = dbo.FuncFKvenLibros(@pLibro_Id)

 exec venlibrosColumnasDatos @pIdentity 
 exec venlibrosImpuestosDatos @pIdentity 
 exec venLibrosRetencionDatos @pIdentity 

 Exec genAtributosGeneralesIdentityDatos @pidentity, 'venLibros'
 RETURN @@Error 

GO

DROP PROCEDURE venLibrosEliminar
GO
CREATE PROCEDURE venLibrosEliminar
(
@pLibro_Id varchar(10)
)
AS
SET NOCOUNT ON 

DELETE FROM venLibros 
WHERE (Libro_Id = @pLibro_Id)
 RETURN @@Error 

GO

