DROP PROCEDURE disRelacionesTablasGuardar
GO

CREATE PROCEDURE disRelacionesTablasGuardar
(
@pFormulario_Id int,
@pTablaMaster_Id varchar(40),
@pTablaDetalle_Id varchar(40),
@pColumnaMaster_Id varchar(100),
@pColumnaMaster2_Id varchar(100) = NULL,
@pColumnaMaster3_Id varchar(100) = NULL,
@pColumnaDetalle_Id varchar(100),
@pColumnaDetalle2_Id varchar(100) = NULL,
@pColumnaDetalle3_Id varchar(100) = NULL
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disRelacionesTablas WHERE (Formulario_Id = @pFormulario_Id) AND (TablaMaster_Id = @pTablaMaster_Id) AND (TablaDetalle_Id = @pTablaDetalle_Id)))
BEGIN 
	UPDATE disRelacionesTablas
	SET	ColumnaMaster_Id = @pColumnaMaster_Id,
		ColumnaMaster2_Id = @pColumnaMaster2_Id,
		ColumnaMaster3_Id = @pColumnaMaster3_Id,
		ColumnaDetalle_Id = @pColumnaDetalle_Id,
		ColumnaDetalle2_Id = @pColumnaDetalle2_Id,
		ColumnaDetalle3_Id = ColumnaDetalle3_Id
	WHERE (Formulario_Id = @pFormulario_Id) AND (TablaMaster_Id = @pTablaMaster_Id) AND (TablaDetalle_Id = @pTablaDetalle_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disRelacionesTablas
	(
		Formulario_Id,
		TablaMaster_Id,
		TablaDetalle_Id,
		ColumnaMaster_Id,
		ColumnaMaster2_Id,
		ColumnaMaster3_Id,
		ColumnaDetalle_Id,
		ColumnaDetalle2_Id,
		ColumnaDetalle3_Id
	)
	VALUES 
	(
		@pFormulario_Id,
		@pTablaMaster_Id,
		@pTablaDetalle_Id,
		@pColumnaMaster_Id,
		@pColumnaMaster2_Id,
		@pColumnaMaster3_Id,
		@pColumnaDetalle_Id,
		@pColumnaDetalle2_Id,
		@pColumnaDetalle3_Id
	)
END 

GO


DROP PROCEDURE disRelacionesTablasEliminar
GO
CREATE PROCEDURE disRelacionesTablasEliminar
(
@pFormulario_Id varchar(30),
@pTablaMaster_Id varchar(40) = NULL,
@pTablaDetalle_Id varchar(40) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disRelacionesTablas 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (TablaMaster_Id = ISNULL(@pTablaMaster_Id, TablaMaster_Id))
AND (TablaDetalle_Id = ISNULL(@pTablaDetalle_Id, TablaDetalle_Id))
 
 RETURN @@Error 

GO

GO
