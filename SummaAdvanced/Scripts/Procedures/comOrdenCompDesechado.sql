DROP PROCEDURE comOrdenCompDesechadoGuardar
GO
CREATE PROCEDURE comOrdenCompDesechadoGuardar
(
@pcomOrdenComp int,
@pUsuario_Id int,
@pFecha datetime
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM comOrdenCompDesechado WHERE (comOrdenComp = @pcomOrdenComp)))
BEGIN 
	UPDATE comOrdenCompDesechado
	SET		Usuario_Id = @pUsuario_Id,
		Fecha = @pFecha
	WHERE (comOrdenComp = @pcomOrdenComp)
END 
ELSE 
BEGIN 
	INSERT INTO comOrdenCompDesechado
	(
		comOrdenComp,
		Usuario_Id,
		Fecha
	)
	VALUES 
	(
		@pcomOrdenComp,
		@pUsuario_Id,
		@pFecha
	)
END 

GO

DROP PROCEDURE comOrdenCompDesechadoDatos
GO
CREATE PROCEDURE comOrdenCompDesechadoDatos
(
@pcomOrdenComp int
)
AS
SET NOCOUNT ON 

SELECT comOrdenCompDesechado.comOrdenComp, genUsuarios.Usuario_Id, genUsuarios.Apellido_y_Nombres as DescripcionUsuario, 
	comOrdenCompDesechado.Fecha
FROM comOrdenCompDesechado 
INNER JOIN comOrdenComp  ON (comOrdenComp.comOrdenComp = comOrdenCompDesechado.comOrdenComp)
INNER JOIN genUsuarios  ON (genUsuarios.genUsuarios = comOrdenCompDesechado.Usuario_Id)
WHERE (comOrdenCompDesechado.comOrdenComp = @pcomOrdenComp)
 
 RETURN @@Error 

GO

DROP PROCEDURE comOrdenCompDesechadoEliminar
GO
CREATE PROCEDURE comOrdenCompDesechadoEliminar
(
@pcomOrdenComp int
)
AS
SET NOCOUNT ON 

DELETE FROM comOrdenCompDesechado 
WHERE (comOrdenComp = @pcomOrdenComp)
 
 RETURN @@Error 

GO

