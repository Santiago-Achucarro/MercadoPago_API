DROP PROCEDURE conIndicesAjustesGuardar
GO
CREATE PROCEDURE conIndicesAjustesGuardar
(
@pIndice_Id varchar(5),
@pIndice_Id_Nuevo varchar(5),
@pDescripcion varchar(50)
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM conIndicesAjustes WHERE (Indice_Id = @pIndice_Id)))
BEGIN 
	UPDATE conIndicesAjustes
	SET		@lIdentidad = conIndicesAjuste,
		Indice_Id = @pIndice_Id_Nuevo,
		Descripcion = @pDescripcion
	WHERE (Indice_Id = @pIndice_Id)
END 
ELSE 
BEGIN 
	INSERT INTO conIndicesAjustes
	(
		Indice_Id,
		Descripcion
	)
	VALUES 
	(
		@pIndice_Id,
		@pDescripcion
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 

GO

DROP PROCEDURE conIndicesAjustesDatos
GO
CREATE PROCEDURE conIndicesAjustesDatos
(
@pIndice_Id varchar(5)
)
AS
SET NOCOUNT ON 

SELECT conIndicesAjustes.conIndicesAjuste, conIndicesAjustes.Indice_Id, conIndicesAjustes.Descripcion
FROM conIndicesAjustes 
WHERE (Indice_Id = @pIndice_Id)
 


  Declare @pidentity bigint= dbo.FuncFKconIndicesAjustes(@pIndice_Id)
 Exec genAtributosGeneralesIdentityDatos @pidentity, 'conIndicesAjustes'
 RETURN @@Error 

GO

DROP PROCEDURE conIndicesAjustesEliminar
GO
CREATE PROCEDURE conIndicesAjustesEliminar
(
@pIndice_Id varchar(5) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM conIndicesAjustes 
WHERE (Indice_Id = @pIndice_Id)
 
 RETURN @@Error 

GO

DROP FUNCTION FuncFKconIndicesAjustes
GO

CREATE FUNCTION FuncFKconIndicesAjustes
(
@pIndice_Id varchar (5)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = conIndicesAjuste FROM conIndicesAjustes WHERE 
	Indice_Id = @pIndice_Id
  RETURN @pIdentity
END


GO
