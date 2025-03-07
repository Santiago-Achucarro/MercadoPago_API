DROP PROCEDURE proTurnosGuardar
GO
CREATE PROCEDURE proTurnosGuardar
(
@pTurno_Id varchar(10),
@pTurno_Id_Nueva varchar(10),
@pDescripcion varchar(100),
@pInicio varchar(5),
@pFin varchar(5)
)
AS
SET NOCOUNT ON 
DECLARE @lIdentidad int
IF (EXISTS (SELECT 1 FROM proTurnos WHERE proTurnos.Turno_Id = @pTurno_Id))
BEGIN 
	UPDATE proTurnos
	SET	@lIdentidad = proTurnos,
		Turno_Id = @pTurno_Id_Nueva,
		Descripcion = @pDescripcion,
		Inicio = @pInicio,
		Fin = @pFin
	WHERE proTurnos.Turno_Id =@pTurno_Id
END 
ELSE 
BEGIN 
	INSERT INTO ProTurnos
	(
		Turno_Id,
		Descripcion,
		Inicio,
		Fin
	)
	VALUES 
	(
		@pTurno_Id,
		@pDescripcion,
		@pInicio,
		@pFin
	)
	SET @lIdentidad =  Cast(SCOPE_IDENTITY() as int) 
END 
Select @lIdentidad as RetVal 
GO

drop FUNCTION FuncFKproTurnos
go
CREATE FUNCTION FuncFKproTurnos
(
@pTurno_Id varchar (10)
)
RETURNS int

AS
BEGIN
  DECLARE @pIdentity int
  SELECT @pIdentity = proTurnos FROM proTurnos WHERE 
	Turno_Id = @pTurno_Id
  RETURN @pIdentity
END
GO


DROP PROCEDURE proTurnosDatos
GO
CREATE PROCEDURE proTurnosDatos
(
@pTurno_Id varchar(10)
)
AS
SET NOCOUNT ON 

SELECT proTurnos.proTurnos, proTurnos.Turno_Id, proTurnos.Turno_Id as Turno_Id_Nueva,
proTurnos.Descripcion, proTurnos.Inicio, proTurnos.Fin
FROM proTurnos
WHERE proTurnos.Turno_Id = @pTurno_Id

Declare @pidentity bigint= dbo.FuncFKproTurnos(@pTurno_Id)
Exec genAtributosGeneralesIdentityDatos @pidentity, 'proTurnos'
RETURN @@Error 

GO

DROP PROCEDURE proTurnosEliminar
GO
CREATE PROCEDURE proTurnosEliminar
(
@pTurno_Id varchar(10)
)
AS
SET NOCOUNT ON 

DELETE FROM proTurnos 
WHERE  @pTurno_Id = proTurnos.Turno_Id
 RETURN @@Error 

GO

