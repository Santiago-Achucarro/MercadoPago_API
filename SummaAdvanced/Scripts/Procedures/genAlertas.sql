
	

DROP PROCEDURE genAlertasGuardar
GO
CREATE PROCEDURE genAlertasGuardar
(
@pAlertaId int, 
@pUsuario_id int,
@pFechaEmision datetime,
@pFechaLeido datetime = NULL,
@pMensaje varchar(max),
@pLiga varchar(254)
)
AS
SET NOCOUNT ON 
IF (@pAlertaId<>0)
BEGIN 
	UPDATE genAlertas
	SET		
		Usuario_id = @pUsuario_id,
		FechaEmision = @pFechaEmision,
		FechaLeido = @pFechaLeido,
		Mensaje = @pMensaje,
		Liga = @pLiga
	WHERE 
	AlertaId = @pAlertaId
END 
ELSE 
BEGIN 
	INSERT INTO genAlertas
	(
		Usuario_id,
		FechaEmision,
		FechaLeido,
		Mensaje,
		Liga
	)
	VALUES 
	(
		@pUsuario_id,
		@pFechaEmision,
		@pFechaLeido,
		@pMensaje,
		@pLiga
	)
	SET @pAlertaId =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @pAlertaId as RetVal 

GO

DROP PROCEDURE genAlertasDatos
GO
CREATE PROCEDURE genAlertasDatos
(
	@pAlertaId int
)
AS
SET NOCOUNT ON 

SELECT genAlertas.AlertaId, genUsuarios.Usuario_id, genUsuarios.Apellido_y_nombres as DescripcionUsuario,
	genAlertas.FechaEmision, genAlertas.FechaLeido,
	genAlertas.Mensaje, genAlertas.Liga
FROM genAlertas inner join genUsuarios on 
genAlertas.Usuario_id = genUsuarios.genUsuarios
WHERE  
AlertaId = @pAlertaId
  
RETURN @@Error 

GO

DROP PROCEDURE genAlertasEliminar
GO
CREATE PROCEDURE genAlertasEliminar
(
	@pAlertaId int
)
AS
SET NOCOUNT ON 

DELETE FROM genAlertas 
WHERE  
AlertaId = @pAlertaId

RETURN @@Error 

GO

DROP PROCEDURE genAlertasUsuario
GO
CREATE PROCEDURE genAlertasUsuario
(
	@pUsuario_Id int
)
AS
SET NOCOUNT ON 
SELECT @pUsuario_id as Usuario_id

SELECT genAlertas.AlertaId, genAlertas.FechaEmision, 
	genAlertas.Mensaje, genAlertas.Liga
FROM genAlertas 
WHERE  
genAlertas.FechaLeido is null and 
genAlertas.Usuario_Id = @pUsuario_Id
 
RETURN @@Error 

GO




DROP PROCEDURE genAlertasEliminarUsuario
GO
CREATE PROCEDURE genAlertasEliminarUsuario
( 
	@pUsuario_Id int
)
AS

DELETE FROM genAlertas Where Usuario_id = @pUsuario_id

GO

