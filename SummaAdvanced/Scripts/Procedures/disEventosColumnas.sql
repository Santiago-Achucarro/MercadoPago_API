DROP PROCEDURE disEventosColumnasGuardar
GO
CREATE PROCEDURE disEventosColumnasGuardar
(
@pFormulario_Id int,
@pControl_Id varChar(200),
@pColumna varchar(40),
@pTipoEvento varchar(30),
@pHeredado bit
)
AS
SET NOCOUNT ON 
IF (NOT EXISTS (SELECT 1 FROM disEventosColumnas WHERE (Formulario_Id = @pFormulario_Id) AND (Control_Id = @pControl_Id) AND (Columna = @pColumna) AND (TipoEvento = @pTipoEvento)))
BEGIN 
	INSERT INTO disEventosColumnas
	(
		Formulario_Id,
		Control_Id,
		Columna,
		TipoEvento,
		Heredado
	)
	VALUES 
	(
		@pFormulario_Id,
		@pControl_Id,
		@pColumna,
		@pTipoEvento,
		@pHeredado
	)
END 

GO


DROP PROCEDURE disEventosColumnasEliminar
GO
CREATE PROCEDURE disEventosColumnasEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varChar(200) = NULL,
@pColumna varchar(40) = NULL,
@pTipoEvento varchar(30) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disEventosColumnas
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
AND (Columna = ISNULL(@pColumna, Columna))
AND (TipoEvento = ISNULL(@pTipoEvento, TipoEvento))
 
RETURN @@Error 

GO
