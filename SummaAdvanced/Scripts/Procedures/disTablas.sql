DROP PROCEDURE disTablasGuardar
GO

CREATE PROCEDURE disTablasGuardar
(
@pFormulario_Id int,
@pTabla_Id varchar(40),
@pTipoControl varchar(50) = Null,
@pControl_Id varChar(200) = NULL,
@pEsEspecializacion bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disTablas WHERE (Formulario_Id = @pFormulario_Id) AND (Tabla_Id = @pTabla_Id)))
BEGIN 
	UPDATE disTablas
	SET	Control_Id = @pControl_Id,
		TipoControl = @pTipoControl, 
		EsEspecializacion = @pEsEspecializacion
	WHERE (Formulario_Id = @pFormulario_Id) AND (Tabla_Id = @pTabla_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disTablas
	(
		Formulario_Id,
		Tabla_Id,
		Control_Id,
		TipoControl,
		EsEspecializacion
	)
	VALUES 
	(
		@pFormulario_Id,
		@pTabla_Id,
		@pControl_Id,
		@pTipoControl,
		@pEsEspecializacion
	)
END 

GO


DROP PROCEDURE disTablasEliminar
GO
CREATE PROCEDURE disTablasEliminar
(
@pFormulario_Id varchar(30),
@pTabla_Id varchar(40) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disTablas 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Tabla_Id = ISNULL(@pTabla_Id, Tabla_Id))
 
 RETURN @@Error 

GO

GO
