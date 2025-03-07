DROP PROCEDURE conSituPatriGuardar
GO
CREATE PROCEDURE conSituPatriGuardar
(
@pRubro_Balance varchar(15),
@pRubro_Id char(1),
@pDescripcion char(35),
@pOrden int
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM conSituPatri WHERE (Rubro_Balance = @pRubro_Balance)))
BEGIN 
	UPDATE conSituPatri
	SET		Rubro_Id = @pRubro_Id,
		Descripcion = @pDescripcion,
		Orden = @pOrden
	WHERE (Rubro_Balance = @pRubro_Balance)
END 
ELSE 
BEGIN 
	INSERT INTO conSituPatri
	(
		Rubro_Balance,
		Rubro_Id,
		Descripcion,
		Orden
	)
	VALUES 
	(
		@pRubro_Balance,
		@pRubro_Id,
		@pDescripcion,
		@pOrden
	)
END 

GO

DROP PROCEDURE conSituPatriDatos
GO
CREATE PROCEDURE conSituPatriDatos
(
@pRubro_Balance varchar(15)
)
AS
SET NOCOUNT ON 

SELECT conSituPatri.Rubro_Balance, conSituPatri.Rubro_Id, conRubros.Descripcion as DescripcionRubros, conSituPatri.Descripcion,
	conSituPatri.Orden
FROM conSituPatri 
INNER JOIN conRubros  ON (conRubros.Rubro_Id = conSituPatri.Rubro_Id)
WHERE (Rubro_Balance = @pRubro_Balance)
 
 RETURN @@Error 

GO

DROP PROCEDURE conSituPatriEliminar
GO
CREATE PROCEDURE conSituPatriEliminar
(
@pRubro_Balance varchar(15) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM conSituPatri 
WHERE (Rubro_Balance = ISNULL(@pRubro_Balance, Rubro_Balance))
 
 RETURN @@Error 

GO

GO
