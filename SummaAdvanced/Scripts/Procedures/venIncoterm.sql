DROP PROCEDURE venIncotermGuardar
GO
CREATE PROCEDURE venIncotermGuardar
(
@pIncoterm_id char(3),
@pIncoterm_id_Nuevo char(3),
@pDescripcion varchar(50)
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM venIncoterm WHERE (Incoterm_id = @pIncoterm_id)))
BEGIN 
	UPDATE venIncoterm
	SET		@lIdentidad = venIncoterm_int,
		Incoterm_id = @pIncoterm_id_Nuevo,
		Descripcion = @pDescripcion
	WHERE (Incoterm_id = @pIncoterm_id)
END 
ELSE 
BEGIN 
	INSERT INTO venIncoterm
	(
		Incoterm_id,
		Descripcion
	)
	VALUES 
	(
		@pIncoterm_id,
		@pDescripcion
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE venIncotermDatos
GO
CREATE PROCEDURE venIncotermDatos
(
@pIncoterm_id char(3)
)
AS
SET NOCOUNT ON 

SELECT venIncoterm.venIncoterm_int, venIncoterm.Incoterm_id, venIncoterm.Descripcion
FROM venIncoterm 
WHERE (Incoterm_id = @pIncoterm_id)
 


  Declare @pidentity bigint= dbo.FuncFKvenIncoterm(@pIncoterm_id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'venIncoterm'
 RETURN @@Error 

GO

DROP PROCEDURE venIncotermEliminar
GO
CREATE PROCEDURE venIncotermEliminar
(
@pIncoterm_id char(3) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM venIncoterm 
WHERE (Incoterm_id = @pIncoterm_id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKvenIncoterm
GO

CREATE FUNCTION FuncFKvenIncoterm
(
@pIncoterm_id char (3)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = venIncoterm_int FROM venIncoterm WHERE 
	Incoterm_id = @pIncoterm_id
  RETURN @pIdentity
END


GO