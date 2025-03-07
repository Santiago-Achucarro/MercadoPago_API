Drop Procedure genDominiosGuardar
GO
CREATE PROCEDURE genDominiosGuardar
(
@pDominio_Id char(2),
@pDescripcion char(100)
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genDominios WHERE (Dominio_Id = @pDominio_Id)))
BEGIN 
	UPDATE genDominios
	SET		Dominio_Id = @pDominio_Id,
		Descripcion = @pDescripcion
	WHERE (Dominio_Id = @pDominio_Id)
END 
ELSE 
BEGIN 
	INSERT INTO genDominios
	(
		Dominio_Id,
		Descripcion
	)
	VALUES 
	(
		@pDominio_Id,
		@pDescripcion
	)
END 

GO
Drop Procedure genDominiosDatos
GO
CREATE PROCEDURE genDominiosDatos(
@pDominio_Id char (2)
)
AS
SELECT genDominios.Dominio_Id, genDominios.Descripcion
 FROM genDominios 
 Where 
	genDominios.Dominio_Id = @pDominio_Id

GO
Drop Procedure genDominiosEliminar
GO
Create Procedure genDominiosEliminar(
@pDominio_Id char (2)
 
) 
AS 
SET NOCOUNT ON  
DELETE FROM genDominios 
	 Where 
	genDominios.Dominio_Id = @pDominio_Id
 
 RETURN @@Error 

GO

GO
