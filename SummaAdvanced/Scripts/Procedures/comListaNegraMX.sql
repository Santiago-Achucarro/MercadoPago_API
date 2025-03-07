DROP PROCEDURE comListaNegraMXInsertar
GO
CREATE PROCEDURE comListaNegraMXInsertar
(
@pRFC varchar(13),
@pRazonSocial varchar(500),
@pSituacion varchar(50)
)
AS
SET NOCOUNT ON 

if not exists(SELECT 1 FROM comListaNegraMX Where RFC = @pRFC)
begin
	INSERT INTO comListaNegraMX
	(
		RFC,
		RazonSocial,
		Situacion
	)
	VALUES 
	(
		@pRFC,
		@pRazonSocial,
		@pSituacion
	)
end
GO

DROP PROCEDURE comListaNegraMXDatos
GO
CREATE PROCEDURE comListaNegraMXDatos
(
@pRFC varchar(13)
)
AS
SET NOCOUNT ON 

SELECT comListaNegraMX.RFC, comListaNegraMX.RazonSocial, comListaNegraMX.Situacion
FROM comListaNegraMX 
WHERE (RFC = @pRFC)
 
 RETURN @@Error 

GO

DROP PROCEDURE comListaNegraMXEliminar
GO
CREATE PROCEDURE comListaNegraMXEliminar
AS
SET NOCOUNT ON 

DELETE FROM comListaNegraMX 
 
RETURN @@Error 

GO


