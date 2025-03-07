DROP PROCEDURE genSemaforoGuardar
GO
CREATE PROCEDURE genSemaforoGuardar
(
@pSemaforo varchar(50),
@pEmpresa_Id int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genSemaforo WHERE (Semaforo = @pSemaforo) AND (Empresa_Id = @pEmpresa_Id)))
BEGIN 
	UPDATE genSemaforo
	SET	 Semaforo = @pSemaforo
	WHERE (Semaforo = @pSemaforo) AND (Empresa_Id = @pEmpresa_Id)
END 
ELSE 
BEGIN 
	INSERT INTO genSemaforo
	(
		Semaforo,
		Empresa_Id
	)
	VALUES 
	(
		@pSemaforo,
		@pEmpresa_Id
	)
END 

GO
