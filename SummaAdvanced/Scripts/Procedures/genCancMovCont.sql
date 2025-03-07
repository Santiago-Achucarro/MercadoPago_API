DROP PROCEDURE genCancMovContGuardar
GO
CREATE PROCEDURE genCancMovContGuardar
(
@pAsiento_Id bigint,
@pCuotaNro smallint,
@pAsiento_Id_Ap bigint,
@pCuotaNro_Ap smallint,
@pAsiento_Aplicacion bigint
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM genCancMovCont WHERE (Asiento_Id = @pAsiento_Id) AND (CuotaNro = @pCuotaNro) AND (Asiento_Id_Ap = @pAsiento_Id_Ap) AND (CuotaNro_Ap = @pCuotaNro_Ap)))
BEGIN 
	UPDATE genCancMovCont
	SET		Asiento_Aplicacion = @pAsiento_Aplicacion
	WHERE (Asiento_Id = @pAsiento_Id) AND (CuotaNro = @pCuotaNro) AND (Asiento_Id_Ap = @pAsiento_Id_Ap) AND (CuotaNro_Ap = @pCuotaNro_Ap)
END 
ELSE 
BEGIN 
	INSERT INTO genCancMovCont
	(
		Asiento_Id,
		CuotaNro,
		Asiento_Id_Ap,
		CuotaNro_Ap,
		Asiento_Aplicacion
	)
	VALUES 
	(
		@pAsiento_Id,
		@pCuotaNro,
		@pAsiento_Id_Ap,
		@pCuotaNro_Ap,
		@pAsiento_Aplicacion
	)
END 

GO

DROP PROCEDURE genCancMovContDatos
GO
CREATE PROCEDURE genCancMovContDatos
(
@pAsiento_Id bigint,
@pCuotaNro smallint,
@pAsiento_Id_Ap bigint,
@pCuotaNro_Ap smallint
)
AS
SET NOCOUNT ON 

DECLARE @pAsiento_Aplicacion bigint

SET @pAsiento_Aplicacion = (SELECT  Asiento_Aplicacion FROM genCancMovCont where
	(genCancMovCont.Asiento_Id = @pAsiento_Id) and 
	(genCancMovCont.CuotaNro = @pCuotaNro) and 
	(genCancMovCont.Asiento_Id_Ap = @pAsiento_Id_Ap) and 
	(genCancMovCont.CuotaNro_Ap = @pCuotaNro_Ap))

Exec conAsientosDatos_Private @pAsiento_Aplicacion

RETURN @@Error 

GO

DROP PROCEDURE genCancMovContEliminar
GO
CREATE PROCEDURE genCancMovContEliminar
(
@pAsiento_Id bigint,
@pCuotaNro smallint,
@pAsiento_Id_Ap bigint,
@pCuotaNro_Ap smallint
)
AS
SET NOCOUNT ON 

DELETE FROM genCancMovCont 
WHERE (Asiento_Id = @pAsiento_Id)
AND (CuotaNro = @pCuotaNro)
AND (Asiento_Id_Ap = @pAsiento_Id_Ap)
AND (CuotaNro_Ap = @pCuotaNro_Ap)
 
 RETURN @@Error 

GO

GO
