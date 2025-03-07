DROP PROCEDURE genControlesSeteosGuardar


GO
CREATE PROCEDURE genControlesSeteosGuardar
(
@pFormulario_Id varchar(30),
@pControl_Id varchar(200),
@pOrden int,
@pValor varchar(80) = NULL,
@pModificoValor Sino,
@pDeshabilitar SiNo,
@pOcultar SiNo,
@pSeteadoPorSistema Sino,
@pUsuario_Id int
)
AS
DECLARE @liFormulario int
SET NOCOUNT ON 
SET @liFormulario = dbo.FuncFKdisFormularios(@pFormulario_Id)

IF (EXISTS (SELECT 1 FROM genControlesSeteos WHERE (Formulario_Id = @liFormulario) AND (Control_Id = @pControl_Id)))
BEGIN 
	UPDATE genControlesSeteos
	SET	Orden = @pOrden,	
		Valor = @pValor,
		ModificoValor = @pModificoValor,
		Deshabilitar = @pDeshabilitar,
		Ocultar = @pOcultar,
		SeteadoPorSistema = @pSeteadoPorSistema,
		Usuario_Id = @pUsuario_Id,
		FechaUltModif =  dbo.FechaActual()
	WHERE (Formulario_Id = @liFormulario) AND (Control_Id = @pControl_Id)
END 
ELSE 
BEGIN 
	INSERT INTO genControlesSeteos
	(
		Formulario_Id,
		Control_Id,
		Orden,
		Valor,
		ModificoValor,
		Deshabilitar,
		Ocultar,
		SeteadoPorSistema,
		Usuario_Id,
		FechaUltModif
	)
	VALUES 
	(
		@liFormulario,
		@pControl_Id,
		@pOrden,
		@pValor,
		@pModificoValor,
		@pDeshabilitar,
		@pOcultar,
		@pSeteadoPorSistema,
		@pUsuario_Id,
		dbo.FechaActual()
	)
END 

GO

DROP PROCEDURE genControlesSeteosDatos
GO
CREATE PROCEDURE genControlesSeteosDatos
(
@pFormulario_Id varchar(30)
)
AS
SET NOCOUNT ON 

SELECT disFormularios.Formulario_Id, vv.Opcion as DescripcionFormularios 
FROM disFormularios 
INNER JOIN vgenMenusFormularios vv ON vv.disFormularios = disFormularios.disFormularios
WHERE (disFormularios.disFormularios = dbo.FuncFKdisFormularios(@pFormulario_Id))


SELECT 	genControlesSeteos.Control_Id, disControles.TituloLabel as Titulo,  genControlesSeteos.Orden, genControlesSeteos.Valor, genControlesSeteos.ModificoValor, genControlesSeteos.Deshabilitar, 
		genControlesSeteos.Ocultar, genControlesSeteos.SeteadoPorSistema, genControlesSeteos.Usuario_Id, disControles.TipoControl
FROM genControlesSeteos 
INNER JOIN disControles ON disControles.Formulario_Id = genControlesSeteos.Formulario_Id AND genControlesSeteos.Control_Id = disControles.Control_Id
WHERE (genControlesSeteos.Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id)) AND
	  ((disControles.TipoControl = 'SummaAdvDisenio.Controles.DisenioLupaAdv') OR 
	   (disControles.TipoControl = 'SummaAdvDisenio.Controles.DisenioTxtEditor') OR 
	   (disControles.TipoControl = 'SummaAdvDisenio.Controles.DisenioTxtNumericEditor') OR 
	   (disControles.TipoControl = 'SummaAdvDisenio.Controles.DisenioDatePicker') OR 
	   (disControles.TipoControl = 'SummaAdvDisenio.Controles.DisenioGridView'))
UNION
SELECT 	genControlesSeteos.Control_Id, disControles.Texto as Titulo,  genControlesSeteos.Orden, genControlesSeteos.Valor, genControlesSeteos.ModificoValor, genControlesSeteos.Deshabilitar, 
		genControlesSeteos.Ocultar, genControlesSeteos.SeteadoPorSistema, genControlesSeteos.Usuario_Id , disControles.TipoControl
FROM genControlesSeteos 
INNER JOIN disControles ON disControles.Formulario_Id = genControlesSeteos.Formulario_Id AND genControlesSeteos.Control_Id = disControles.Control_Id
WHERE (genControlesSeteos.Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id)) AND
	  ((disControles.TipoControl = 'SummaAdvDisenio.Controles.DisenioCheck')  OR 
	   (disControles.TipoControl = 'SummaAdvDisenio.Controles.DisenioBoton'))
UNION
SELECT 	genControlesSeteos.Control_Id, disControles.Texto as Titulo,  genControlesSeteos.Orden, genControlesSeteos.Valor, genControlesSeteos.ModificoValor, genControlesSeteos.Deshabilitar, 
		genControlesSeteos.Ocultar, genControlesSeteos.SeteadoPorSistema, genControlesSeteos.Usuario_Id, disControles.TipoControl 
FROM genControlesSeteos 
INNER JOIN disControles ON disControles.Formulario_Id = genControlesSeteos.Formulario_Id AND genControlesSeteos.Control_Id = disControles.Control_Id
WHERE (genControlesSeteos.Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id)) AND
	  (disControles.TipoControl = 'System.Windows.Forms.TabPage')
UNION
SELECT 	genControlesSeteos.Control_Id, ISNULL(disControles.TituloLabel,'') + '.' + c1.Titulo as Titulo,  genControlesSeteos.Orden, genControlesSeteos.Valor, genControlesSeteos.ModificoValor, genControlesSeteos.Deshabilitar, 
		genControlesSeteos.Ocultar, genControlesSeteos.SeteadoPorSistema, genControlesSeteos.Usuario_Id, 'Columna' 
FROM genControlesSeteos 
INNER JOIN disControlesGrillaColumnas c1 ON genControlesSeteos.Formulario_Id = c1.Formulario_Id AND
										(c1.Control_Id + '.' + c1.NombreCampo = genControlesSeteos.Control_Id)
INNER JOIN disControles ON disControles.Formulario_Id = c1.Formulario_Id AND disControles.Control_Id = c1.Control_Id
WHERE (genControlesSeteos.Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id)) 
ORDER BY Orden
 
RETURN @@Error 

GO

DROP PROCEDURE genControlesSeteosEliminar
GO
CREATE PROCEDURE genControlesSeteosEliminar
(
@pFormulario_Id varchar(30),
@pControl_Id varchar(200) = NULL
)
AS
SET NOCOUNT ON 

DELETE FROM genControlesSeteos 
WHERE (Formulario_Id = dbo.FuncFKdisFormularios(@pFormulario_Id))
AND (Control_Id = ISNULL(@pControl_Id, Control_Id))
 
 RETURN @@Error 

GO

GO
