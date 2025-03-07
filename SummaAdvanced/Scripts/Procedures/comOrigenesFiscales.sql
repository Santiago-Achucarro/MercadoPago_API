DROP PROCEDURE comOrigenesFiscalesGuardar
GO
CREATE PROCEDURE comOrigenesFiscalesGuardar
(
@pOrigen_Id smallint,
@pOrigen_Id_Nuevo smallint,
@pDescripcion varchar(35),
@pDominio_Id char(2) = NULL
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM comOrigenesFiscales WHERE (Origen_Id = @pOrigen_Id)))
BEGIN 
	UPDATE comOrigenesFiscales
	SET		@lIdentidad = comOrigenesFiscales,
		Origen_Id = @pOrigen_Id_Nuevo,
		Descripcion = @pDescripcion,
		Dominio_Id = @pDominio_Id
	WHERE (Origen_Id = @pOrigen_Id)
END 
ELSE 
BEGIN 
	INSERT INTO comOrigenesFiscales
	(
		Origen_Id,
		Descripcion,
		Dominio_Id
	)
	VALUES 
	(
		@pOrigen_Id,
		@pDescripcion,
		@pDominio_Id
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE comOrigenesFiscalesDatos
GO
CREATE PROCEDURE comOrigenesFiscalesDatos
(
@pOrigen_Id smallint
)
AS
SET NOCOUNT ON 

SELECT comOrigenesFiscales.comOrigenesFiscales, comOrigenesFiscales.Origen_Id, comOrigenesFiscales.Descripcion, comOrigenesFiscales.Dominio_Id,
	genDominios.Descripcion as DescripcionDominios
FROM comOrigenesFiscales 
LEFT JOIN genDominios  ON (genDominios.Dominio_Id = comOrigenesFiscales.Dominio_Id)
WHERE (Origen_Id = @pOrigen_Id)
 


 Declare @pidentity bigint= dbo.FuncFKcomOrigenesFiscales(@pOrigen_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'comOrigenesFiscales'
 RETURN @@Error 

GO

DROP PROCEDURE comOrigenesFiscalesEliminar
GO
CREATE PROCEDURE comOrigenesFiscalesEliminar
(
@pOrigen_Id smallint = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM comOrigenesFiscales 
WHERE (Origen_Id = @pOrigen_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKcomOrigenesFiscales
GO

CREATE FUNCTION FuncFKcomOrigenesFiscales
(
@pOrigen_Id smallint
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = comOrigenesFiscales FROM comOrigenesFiscales WHERE 
	Origen_Id = @pOrigen_Id
  RETURN @pIdentity
END


GO
