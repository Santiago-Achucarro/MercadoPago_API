DROP PROCEDURE disTablasColumnasGuardar
GO

CREATE PROCEDURE disTablasColumnasGuardar
(
@pFormulario_Id int,
@pTabla_Id varchar(40),
@pColumna_Id varchar(100),
@pTipoControl varchar(50) = Null,
@pControl_Id varChar(200) = NULL,
@pAdicionalControl varchar(10),
@pEsEspecializacion bit
)
AS
SET NOCOUNT ON 
IF (EXISTS (SELECT 1 FROM disTablasColumnas WHERE (Formulario_Id = @pFormulario_Id) AND (Tabla_Id = @pTabla_Id) AND (Columna_Id = @pColumna_Id)))
BEGIN 
	UPDATE disTablasColumnas
	SET	Control_Id = @pControl_Id,
		TipoControl = @pTipoControl,
		AdicionalControl = @pAdicionalControl,
		EsEspecializacion = @pEsEspecializacion
	WHERE (Formulario_Id = @pFormulario_Id) AND (Tabla_Id = @pTabla_Id) AND (Columna_Id = @pColumna_Id)
END 
ELSE 
BEGIN 
	INSERT INTO disTablasColumnas
	(
		Formulario_Id,
		Tabla_Id,
		Columna_Id,
		Control_Id,
		TipoControl,
		AdicionalControl,
		EsEspecializacion
	)
	VALUES 
	(
		@pFormulario_Id,
		@pTabla_Id,
		@pColumna_Id,
		@pControl_Id,
		@pTipoControl,
		@pAdicionalControl,
		@pEsEspecializacion
	)
END 

GO


DROP PROCEDURE disTablasColumnasEliminar
GO
CREATE PROCEDURE disTablasColumnasEliminar
(
@pFormulario_Id varchar(30),
@pTabla_Id varchar(40) = NULL,
@pColumna_Id varchar(40) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM disTablasColumnas 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Tabla_Id = ISNULL(@pTabla_Id, Tabla_Id))
AND (Columna_Id = ISNULL(@pColumna_Id, Columna_Id))
 
 RETURN @@Error 

GO

GO
