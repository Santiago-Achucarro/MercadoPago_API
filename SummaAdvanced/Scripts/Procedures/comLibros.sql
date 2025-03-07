DROP FUNCTION FuncFKcomLIbros
GO

CREATE FUNCTION FuncFKcomLIbros
(
	@pLibro_Id varchar (10)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = comLibros FROM comLIbros WHERE 
	Libro_Id = @pLibro_Id 
  RETURN @pIdentity
END

GO


DROP PROCEDURE comLIbrosGuardar
GO
CREATE PROCEDURE comLIbrosGuardar
(
	@pEmpresa_Id int = null,
	@pLibro_Id varchar(10),
	@pLibro_Id_Nuevo varchar(10),
	@pDescripcion varchar(50)
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM comLIbros WHERE (Libro_Id = @pLibro_Id)))
BEGIN 
	UPDATE comLIbros
	SET		@lIdentidad = comLibros,
		Empresa_Id = @pEmpresa_Id,
		Libro_Id = @pLibro_Id_Nuevo,
		Descripcion = @pDescripcion
	WHERE (Libro_Id = @pLibro_Id) 
END 
ELSE 
BEGIN 
	INSERT INTO comLIbros
	(
		Empresa_Id,
		Libro_Id,
		Descripcion
	)
	VALUES 
	(
		@pEmpresa_Id,
		@pLibro_Id,
		@pDescripcion
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE comLIbrosDatos
GO
CREATE PROCEDURE comLIbrosDatos
(
	@pLibro_Id varchar(10)
)
AS
SET NOCOUNT ON 
SELECT comLIbros.comLibros, 
	Cast(case when comLIbros.Empresa_Id is null then 0 else 1 end as bit) as  PTodasLasEmpresas,
	comLIbros.Libro_Id,comLIbros.Libro_Id as Libro_Id_Nuevo, comLIbros.Descripcion
FROM comLIbros 
WHERE (Libro_Id = @pLibro_Id)

Declare @pidentity bigint= dbo.FuncFKcomLIbros(@pLibro_Id)

exec comlibrosColumnasDatos @pIdentity 
exec comlibrosImpuestosDatos @pIdentity 
Exec genAtributosGeneralesIdentityDatos @pidentity, 'comLIbros'

RETURN @@Error 

GO

DROP PROCEDURE comLIbrosEliminar
GO
CREATE PROCEDURE comLIbrosEliminar
(
@pLibro_Id varchar(10) 
)
AS
SET NOCOUNT ON 

DELETE FROM comLIbros 
WHERE (Libro_Id = @pLibro_Id)
 
RETURN @@Error 

GO

