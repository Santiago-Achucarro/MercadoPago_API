DROP PROCEDURE venLogCorreosGuardar
GO
CREATE PROCEDURE venLogCorreosGuardar
(
@pFechaHora datetime,
@pPara varchar(max),
@pvenMovimientos bigint,
@pRespuesta varchar(max)
)
AS
DECLARE @lIdentidad BIGINT

	INSERT INTO venLogCorreos
	(
		FechaHora,
		Para,
		venMovimientos,
		Respuesta
	)
	VALUES 
	(
		@pFechaHora,
		@pPara,
		@pvenMovimientos,
		@pRespuesta
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as bigint) 
Select @lIdentidad as RetVal 

GO


